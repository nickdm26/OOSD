using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Counter.Controllers
{
    public class WordController : Controller
    {
        // GET: Word
        public ActionResult Index()
        {
            int arrayCount;
            List<String> words;

            if (Session["WordSession"] == null)
            {
                Session["WordSession"] = 0;
                words = new List<String>();
                words.Add("Apple");
                words.Add("Banana");
                words.Add("Carrot");
                words.Add("Dates");
                words.Add("EggPlant");
                words.Add("Fig");
                words.Add("GrapeFruit");

                Session["Words"] = words;

                arrayCount = (int)Session["WordSession"];    
            }
            else if ((int)Session["WordSession"] == 7)
            {
                Session["WordSession"] = 0;
                arrayCount = (int)Session["WordSession"];
                words = (List<String>)Session["Words"];
            }
            else
            {
                arrayCount = (int)Session["WordSession"];
                words = (List<String>)Session["Words"];
            }

            ViewBag.word = words[arrayCount];
            arrayCount++;
            Session["WordSession"] = arrayCount;

            return View();
        }
    }
}