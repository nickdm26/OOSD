using System.Linq;
using System.Net;
using System.Web.Mvc;
using Weather.Other;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            WorldDBDataContext db = new WorldDBDataContext();

            var PopulatedCity = (from city in db.cities
                                 where string.Equals(city.CountryCode, "NLD")
                                 orderby city.Population descending
                                 select city).Take(1);

            foreach(var ci in PopulatedCity)
            {
                ViewBag.INFO = ci.Name + " " + ci.Population;
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Code)
        {
            WorldDBDataContext db = new WorldDBDataContext();

            var PopulatedCity = (from city in db.cities
                                 where string.Equals(city.CountryCode, Code.ToUpper())
                                 orderby city.Population descending
                                 select city).Take(1);
            string cityName;
            string urlString = null;
            bool doesFind = false;

            foreach (var ci in PopulatedCity)
            {
                ViewBag.INFO = ci.Name + " " + ci.Population;
                cityName = ci.Name;
                urlString = "http://api.openweathermap.org/data/2.5/weather?q=" + cityName.TrimEnd(' ') + "&APPID=fb300d1d716285d725075a0c628b3cd7";
                doesFind = true;
            }

            if (doesFind)
            {
                HttpClient client = new HttpClient();
                string fetchedJSON = client.GetStringAsync(urlString).Result;

                List<JObject> JsonArrayObs = new List<JObject>();

                JObject baseObject = JObject.Parse(fetchedJSON);
                JObject SYSChild = (JObject)baseObject["sys"];
                JsonArrayObs = baseObject["weather"].Select(e => (JObject)e).ToList();
                JObject MainChild = (JObject)baseObject["main"];
                JObject WindChild = (JObject)baseObject["wind"];

                string strName = (string)baseObject["name"];
                string strCountry = (string)SYSChild["country"];
                string strMain = (string)JsonArrayObs[0]["main"];
                string strDescription = (string)JsonArrayObs[0]["description"];
                string strTemp = (string)MainChild["temp"];
                string strHumidity = (string)MainChild["humidity"];
                string strPressure = (string)MainChild["pressure"];
                string strSpeed = (string)WindChild["speed"];
                string strDegrees = (string)WindChild["deg"];
                
                ViewBag.NAME = strName;
                ViewBag.COUNTRY = strCountry;
                ViewBag.MAIN = strMain;
                ViewBag.DESCRIPTION = strDescription;
                ViewBag.TEMPERATURE = strTemp;
                ViewBag.HUMIDITY = strHumidity;
                ViewBag.PRESSURE = strPressure;
                ViewBag.SPEED = strSpeed;
                ViewBag.DEGREES = strDegrees;
            }

            return View("Search");
        }
    }
}