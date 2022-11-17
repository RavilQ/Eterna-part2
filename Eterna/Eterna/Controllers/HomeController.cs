using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel {
            
                Sservice = Data.service,
                Feature =Data.feature,
                Slide=Data.Sliders
            };

            return View(home);
        }

        public IActionResult detail(int id)
        {


            foreach (var item in Data.service)
            {
                if (item.Id == id)
                {
                    return View(item);
                }
            }


            return View(null);

        }
    }
}
