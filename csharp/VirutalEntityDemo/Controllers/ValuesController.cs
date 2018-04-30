using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;

using VirutalEntityDemo.Models;


namespace VirutalEntityDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/WebOrders")]
    public class ValuesController : Controller
    {
        private readonly WebOrderDbContext _webOrderDbContext;

        public ValuesController(WebOrderDbContext webOrderDbContext) => this._webOrderDbContext = webOrderDbContext;

        // GET odata/weborders
        [EnableQuery]
        public IQueryable<WebOrder> Get() => _webOrderDbContext.WebOrder.AsQueryable(); 
    }
}
