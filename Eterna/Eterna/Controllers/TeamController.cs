using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult team()
        {
            return View(Data.card);
        }

        public IActionResult Detail(int id)
        {
            foreach (var item in Data.card)
            {
                if (item.Id==id)
                {
                    return View(item);
                }
            }
            return View(null);
        }
    }
}
