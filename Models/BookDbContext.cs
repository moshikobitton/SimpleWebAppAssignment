using Microsoft.EntityFrameworkCore;

namespace SimpleWebApplication.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {}

        public DbSet<Book> books { get; set; }
    }

}
