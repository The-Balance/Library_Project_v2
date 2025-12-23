using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library_Project.Models;




namespace Library_Project.Controllers;

public class BookController(Context context) : Controller
{

    // Fix: Removed the empty "public IActionResult Index()" method. 
    // You can only have one Index method. Kept this one because it loads the books.
    public IActionResult Index()
    {
        var books = context.Books.ToList();

        // Eski kod: return Content("Gelen kayýt: " + books.Count);
        // Yeni kod:
        return View(books);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Book book)
    {
        if (!ModelState.IsValid) return View(book);

        context.Add(book);
        await context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Borrow(int bookId, int userId)
{
        var book = await context.Books.FindAsync(bookId);

        var user = await context.Users.FindAsync(userId);

    if (book == null || user == null)
        return NotFound();

    if (!book.CanBeBorrowed() || !user.CanBorrow())
        return BadRequest("Book cannot be borrowed");

    var loan = new Loan
    {
        BOOK_ID = book.BOOK_ID,
        USER_ID = user.USER_ID,
        LOAN_DATE = DateTime.Now,
        DUE_DATE = DateTime.Now.AddDays(14),
        STATUS = true
    };



    context.Loans.Add(loan);
    await context.SaveChangesAsync();

    return RedirectToAction(nameof(Index));
}
public async Task<IActionResult> Return(int loanId)
{
    var loan = await context.Loans
        .Include(l => l.Book)
        .FirstOrDefaultAsync(l => l.LOAN_ID == loanId);

    if (loan == null)
        return NotFound();

    loan.CloseLoan();


    await context.SaveChangesAsync();

    return RedirectToAction(nameof(Index));
}

}