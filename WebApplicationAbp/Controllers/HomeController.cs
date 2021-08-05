using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace WebApplicationAbp.Controllers
{
    [Route("[controller]")]
    public class HomeController : AbpController
    {
        [HttpGet("{user}")]
        public IActionResult Index(string user)
        {
            
            return Content(user);
        }
    }
}