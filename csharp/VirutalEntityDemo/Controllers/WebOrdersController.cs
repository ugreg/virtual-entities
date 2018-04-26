using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

using VirutalEntityDemo.Models;

namespace VirutalEntityDemo.Controllers
{
    public class WebOrdersController
    {
        private readonly WebOrdersDbContext _webOrdersDbContext;

        public WebOrdersController(WebOrdersDbContext ctx)
        {
            _webOrdersDbContext = ctx;
        }

        [EnableQuery]
        public IQueryable Get()
        {
            return _webOrdersDbContext.WebOrders.AsQueryable();
        }
    }
}
