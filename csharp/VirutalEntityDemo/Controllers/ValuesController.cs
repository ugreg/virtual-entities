using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VirutalEntityDemo.Models;

namespace VirutalEntityDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/WebOrders")]
    public class ValuesController : Controller
    {
        private readonly WebOrderDbContext _webOrderDbContext;

        public ValuesController(WebOrderDbContext webOrderDbContext) => this._webOrderDbContext = webOrderDbContext;

        // GET api/weborders
        [HttpGet]
        public IEnumerable<WebOrder> Get() => _webOrderDbContext.WebOrder; 
    }
}
