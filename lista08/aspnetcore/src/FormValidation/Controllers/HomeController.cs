using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormValidation.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Car car)
        {
            if (car.Year < 1900 || car.Year > 2100)
                ModelState.AddModelError("Year", "Zły rok");
            if (!new List<string> { "P", "ON", "LPG", "EE" }.Contains(car.Fuel)) 
                ModelState.AddModelError("Fuel", "Złe paliwo");
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            return View();
        }
    }
}
