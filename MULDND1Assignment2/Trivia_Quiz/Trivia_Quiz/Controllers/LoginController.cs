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
    public class LoginController : Controller
    {
        // GET: Login
        /*
         * The LoginController Login method useing GET is used to check if a user is logged in.
         * If they are not logged in then it redirects them back to the Home/Index page.
         */
        [HttpGet]
        public ActionResult Login()
        {
            if(Session["User"] != null)     //Checks if a User is logged in.
            {
                return Redirect("../Home/Index");   //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
            }else
            {
                return View();
            }            
        }

        /*
         * The LoginController Login method useing POST is called once the submit button has been pressed.
         * Checks if the passed in User and Password exist in the DataBase and then Sets the PlayerID and UserName into a Session.
         * If the User and Password are incorrect then It sets the Session User and UserID to null.
         */
        [HttpPost]
        public ActionResult Login(string Username, string passWord)
        {
            QuizDBDataContext db = new QuizDBDataContext();     //Creates a instance of the DB

            if (db.tblPlayers.Where(u => u.PlayerName == Username && u.PlayerPassword == passWord).Any())       //Uses linq to check if the Username and password are correct.
            {
                var userID = (from pl in db.tblPlayers        //Uses linq to loop through and get the Data from tblPlayers for the first specfic user.
                                where string.Equals(pl.PlayerName, Username) && string.Equals(pl.PlayerPassword, passWord)
                                select pl.PlayerID).First();                                
                
                Session["UserID"] = userID;     //Sets the UserID Session to the first Matching UserID from the DB Query      
                Session["User"] = Username;     //Sets the User Session to the UserName
                
                return Redirect("../Home/Index");   //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
            }
            Session["User"] = null;     //The User and UserID Sessions are set to null if no user is found in the DB.
            Session["UserID"] = null;

            return View();
        }

        /*
         * The LoginController LogOut method using Get is called when someone clicks the link to LogOut
         * The Session User is set to null and then its redirected back to the home page.
         */
        [HttpGet]
        public ActionResult LogOut()
        {
            Session["User"] = null;
            return Redirect("../Home/Index");   //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
        }

        /*
         * The LoginController Register method useing GET is used to check if a user is logged in.
         * If they are not logged in then it redirects them back to the Home/Index page.
         */
        [HttpGet]
        public ActionResult Register()
        {
            if (Session["User"] != null)            //Checks if a User is logged in.
            {
                return Redirect("../Home/Index");   //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
            }
            else
            {
                return View();
            }
        }

        /*
         * The LoginController Register method using POST is used to add a new User to the DataBase
         */
        [HttpPost]
        public ActionResult Register(string Username, string passWord)
        {
            QuizDBDataContext db = new QuizDBDataContext();     //Creates a instance of the Database

            tblPlayer player = new tblPlayer        //Creates a new instance of tblPlayer to be added to the DataBase
            {
                PlayerName = Username,
                PlayerPassword = passWord
            };

            db.tblPlayers.InsertOnSubmit(player);      

            try                 //Try catch statement used to save the new User into the DataBase
            {
                db.SubmitChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);       //Writes the Error to the console
            }
            return Redirect("Login");       //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
        }
    }
}