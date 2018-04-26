using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrderDbContext : DbContext
    {
        public WebOrderDbContext(DbContextOptionsBuilder optionsBuilder) { }

        protected WebOrderDbContext() { }

        public DbSet<WebOrder> WebOrder { get; set; }
    }
}
