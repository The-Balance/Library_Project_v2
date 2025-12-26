using Library_Project.Models;

public class Borrow
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public AppUser User { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }

    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public bool IsReturned { get; set; }
}
