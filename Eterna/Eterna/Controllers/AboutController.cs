using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
