using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrderDbContext : DbContext
    {
        protected WebOrderDbContext() { }

        public WebOrderDbContext(DbContextOptionsBuilder optionsBuilder) { }

        public DbSet<WebOrder> WebOrder { get; set; }
    }
}
