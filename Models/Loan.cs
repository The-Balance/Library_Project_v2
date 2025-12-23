using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Project.Models;
    
public class Loan
{
    [Key]
    public int LOAN_ID { get; set; }

    [ForeignKey("Book")]
    public int BOOK_ID { get; set; }

    [ForeignKey("User")]
    public int USER_ID { get; set; }

    public DateTime LOAN_DATE { get; set; }

    public DateTime DUE_DATE { get; set; }

    public DateTime? RETURN_DATE { get; set; }

    public bool STATUS { get; set; }

    public Book Book { get; set; }
    public User User { get; set; }

}