using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrderDbContext : DbContext
    {
        public WebOrderDbContext() : base() { }

        public WebOrderDbContext(DbContextOptions optionsBuilder) : base(optionsBuilder) { }

        public DbSet<WebOrder> WebOrder { get; set; }
    }
}
