using Microsoft.EntityFrameworkCore;
using BooksApi.Models;

namespace BooksApi.Data;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options){}

    public DbSet<Books> Books { get; set; } = null!;
}