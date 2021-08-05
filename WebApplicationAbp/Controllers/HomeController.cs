using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace WebApplicationAbp.Controllers
{
    [Microsoft.AspNetCore.Components.Route("[Controller]")]
    public class HomeController:AbpController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("Hello world");
        }
    }
}