using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
