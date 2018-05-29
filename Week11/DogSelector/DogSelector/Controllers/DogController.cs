using DogSelector.Content;
using DogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogSelector.Controllers
{
    public class DogController : Controller
    {
        // GET: Dog
        [HttpGet]
        public ActionResult NewDogForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewDogForm(bool GoodWithKids, bool Drooling, Enums.ELength Length, Enums.EScale ActivityLvl, Enums.EScale SheddingLvl, Enums.EScale GroomingLvl, Enums.EScale IntelligenceLvl, Enums.ESize Size)
        {
            MakeDogDatabase DogDB = new MakeDogDatabase();
            List<Dog> DogList = DogDB.makeDatabase();
            Dog newDog = new Models.Dog { GoodWithChildren = GoodWithKids, Drools = Drooling, Coatlength = Length, ActivityLevel = ActivityLvl, SheddingLevel = SheddingLvl, GroomingLevel = GroomingLvl, IntelligenceLevel = IntelligenceLvl, Size = Size };
                   
            foreach(Dog dog in DogList)
            {
                if (dog.CompareTo(newDog))
                {
                    return View("NewDogConfirm", dog);
                }
            }

            Dog firstDog = DogList[0];
            return View("NewDogConfirm", firstDog);
        }
    }
}