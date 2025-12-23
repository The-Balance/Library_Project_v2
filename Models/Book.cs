using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Project.Models;

[Table("Books", Schema = "dbo")]
public class Book
{
    [Key]
    public int BOOK_ID { get; set; }

    public string TITLE { get; set; } = string.Empty;
    public string AUTHOR { get; set; } = string.Empty;
    public string CATEGORY { get; set; } = string.Empty;

    public int PUBLICATION_YEAR { get; set; }
    public int PAGE { get; set; }
    public int STOCK { get; set; }

    public bool STATUS { get; set; }

    public string LANGUAGE { get; set; } = string.Empty;
    public double RATING { get; set; }
    public string PUBLISHING_HOUSE { get; set; } = string.Empty;

    public ICollection<Loan>? Loans { get; set; }

    public bool CanBeBorrowed()
    {
        return STATUS && STOCK > 0;
    }
}
