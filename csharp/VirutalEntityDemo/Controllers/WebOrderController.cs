using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

using VirutalEntityDemo.Models;

namespace VirutalEntityDemo.Controllers
{
    public class WebOrderController
    {
        private readonly WebOrderDbContext _webOrderDbContext;

        public WebOrderController(WebOrderDbContext ctx)
        {
            _webOrderDbContext = ctx;
        }

        [EnableQuery]
        public IQueryable Get()
        {
            return _webOrderDbContext.WebOrder.AsQueryable();
        }
    }
}
