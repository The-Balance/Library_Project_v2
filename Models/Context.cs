using Microsoft.EntityFrameworkCore;

namespace Library_Project.Models;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Book> Library { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Loan> Loans { get; set; }
}