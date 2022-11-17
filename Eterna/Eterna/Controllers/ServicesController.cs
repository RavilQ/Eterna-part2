using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View(Data.service);
        }
    }
}
