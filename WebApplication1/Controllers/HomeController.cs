using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]

    public class HomeController : ControllerBase
    {
        
        public HomeController()
        {
            
        }

        [HttpGet]
        [Route("Home/Index")]        
        public IActionResult Index()
        {
                       
            return Ok();
        }
    }
}
