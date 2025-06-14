using Microsoft.AspNetCore.Mvc;

namespace EfDemo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
