using System.ComponentModel.DataAnnotations;

namespace Library_Project.Models;

    
public class Book
{
    [Key]
    public int BOOK_ID { get; set; }

    [Required]
    public string TITLE { get; set; }

    [Required]
    public string AUTHOR { get; set; }

    public string CATEGORY { get; set; }
    public int PUBLICATION_YEAR { get; set; }

    [Range(0, int.MaxValue)]
    public int STOCK { get; set; }

    public bool STATUS { get; set; }

    public ICollection<Loan> Loans { get; set; }
}