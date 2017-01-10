using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormModel.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FormModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "IndexTitle";
            return View();
        }
        [Route("person")]
        public IActionResult Person()
        {
            ViewBag.Title = "Person";
            return Person();
        }

        [Route("string")]
        public IActionResult String()
        {
            ViewBag.Title = "StringTitle";
            return Content("String");
        }

        [Route("picture")]
        public IActionResult Picture()
        {
            ViewBag.Title = "Picture";
            return File("picture.jpg", "image/jpg");
        }

        [Route("json")]
        public IActionResult Json()
        {
            ViewBag.Title = "Json";
            return Json(new char[5] { 'a', 'b', 'c', 'd', 'e' });
        }

        

        [HttpPost]
        public ActionResult Index(Person person)
        {
            return View();
        }
    }
}
