using Microsoft.EntityFrameworkCore;

namespace VirutalEntityDemo.Models
{
    public class WebOrdersDbContext : DbContext
    {
        public WebOrdersDbContext(DbContextOptions options) : base(options) { }

        protected WebOrdersDbContext() { }

        public DbSet<WebOrders> WebOrders { get; set; }
    }
}
