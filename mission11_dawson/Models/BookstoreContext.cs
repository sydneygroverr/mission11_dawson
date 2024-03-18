using Microsoft.EntityFrameworkCore;

namespace mission11_dawson.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext (DbContextOptions<BookstoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set;}

    }
}
