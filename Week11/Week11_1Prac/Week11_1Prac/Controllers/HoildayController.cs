using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week11_1Prac.Models;

namespace Week11_1Prac.Controllers
{
    public class HoildayController : Controller
    {
        // GET: Hoilday
        public ActionResult Index()
        {
            List<Hoilday> HoildaysList = new List<Hoilday>();
            Hoilday Newyear = new Hoilday();
            Newyear.Name = "New Year's Day";
            Newyear.Date = new DateTime(2018, 1, 1);
            Newyear.Picture = "../Images/New_years_day.jpg";

            Hoilday Anzac = new Hoilday();
            Anzac.Name = "Anzac Day";
            Anzac.Date = new DateTime(2018, 4, 25);
            Anzac.Picture = "../Images/anzac_day.png";

            Hoilday Waitangi = new Hoilday();
            Waitangi.Name = "Waitangi Day";
            Waitangi.Date = new DateTime(2018, 2, 6);
            Waitangi.Picture = "../Images/waitangi_day.png";

            HoildaysList.Add(Newyear);
            HoildaysList.Add(Anzac);
            HoildaysList.Add(Waitangi);

            Random ran = new Random();
            int ranNum = ran.Next(HoildaysList.Count);

            Hoilday CurrentHoilday = HoildaysList[ranNum];
            DateTime currentTime = DateTime.Now;
            TimeSpan ts = CurrentHoilday.Date - currentTime;

            ViewBag.Name = CurrentHoilday.Name;
            ViewBag.DaysLeft = ts.Days;
            ViewBag.Image = CurrentHoilday.Picture;
            

            return View();
        }
    }
}