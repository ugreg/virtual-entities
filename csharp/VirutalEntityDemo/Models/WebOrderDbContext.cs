using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrderDbContext : DbContext
    {
        public DbSet<WebOrder> WebOrder { get; set; }

        public WebOrderDbContext() : base() { }

        public WebOrderDbContext(DbContextOptions optionsBuilder) : base(optionsBuilder) { }        
    }
}
