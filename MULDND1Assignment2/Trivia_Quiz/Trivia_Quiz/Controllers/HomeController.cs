/*
 * Nicholas Muldrew
 * OOSD Assignment 2
 * MULDND1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trivia_Quiz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*
         * The HomeController Index method simply checks if a User is currently logged in and Sets the ViewBag if someone is logged in.
         */ 
        public ActionResult Index()
        {
            if(Session["User"] != null)     //Checks if someone is logged in
            {
                string User = (string)Session["User"];
                int UserID = (int)Session["UserID"];
                if (User != null)
                {
                    ViewBag.User = User;        //Passes the Current Users name from the Session to the ViewBag so it can be displayed in the view.
                }
            }            
           
            return View();
        }
    }
}