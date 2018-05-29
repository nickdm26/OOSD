using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Animal_Picker.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal
        [HttpGet]
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Animal)
        {
            Session["Animal"] = Animal;
            ViewBag.Animal = (string)Session["Animal"];
            return View("FormPart2");
        }

        [HttpPost]
        public ActionResult Display(string name)
        {
            Session["Text"] = name;
            ViewBag.Animal = (string)Session["Animal"];
            ViewBag.Text = (string)Session["Text"];

            return View();
        }
    }
}