using Microsoft.EntityFrameworkCore;

namespace WpfBlazorBooks.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
