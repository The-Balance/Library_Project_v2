using System.ComponentModel.DataAnnotations;

namespace Library_Project.Models;

public class User
{
    [Key]
    public int USER_ID { get; set; }

    [Required]
    public string NAME { get; set; }

    [Required]
    [EmailAddress]
    public string EMAIL { get; set; }

    public string PHONE { get; set; }

    public DateTime REGISTRATION_DATE { get; set; }

    public ICollection<Loan> Loans { get; set; }

}