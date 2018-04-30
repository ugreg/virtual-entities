using System.Linq;
using Microsoft.AspNet.OData;

using VirutalEntityDemo.Models;

namespace VirutalEntityDemo.Controllers
{
    public class WebOrderController
    {
        private readonly WebOrderDbContext _webOrderDbContext;

        public WebOrderController(WebOrderDbContext context)
        {
            _webOrderDbContext = context;
        }

        [EnableQuery]
        public IQueryable Get()
        {
            return _webOrderDbContext.WebOrder.AsQueryable();
        }
    }
}
