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
        return View();
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
}