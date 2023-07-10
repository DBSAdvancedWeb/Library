using Microsoft.EntityFrameworkCore;
using AuthorsAPI.Models;

namespace AuthorsAPI.Data

{
    public class AuthorContext : DbContext
    {
        public AuthorContext (DbContextOptions<AuthorContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; } = default!;
    }
}
