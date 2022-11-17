using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult blog()
        {
            return View();
        }
    }
}
