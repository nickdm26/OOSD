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
using Trivia_Quiz.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Trivia_Quiz.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        /*
         * The QuizController Index method using GET is used to make the API call to retrive the 10 Questions.
         * When the request is complete a JSON string is returned and it must be looped over and passed into the Question class for processing.
         * Each Question is then added to the QuestionDB class.
         * Returns the User to the Home Page if they are not logged in.
         */
        public ActionResult Index()
        {
            int QuestionCount = 10;     //Number of questions used

            if (Session["User"] == null)    //Checks if the user is logged in.
            {
                return Redirect("../Home/Index");       //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
            }
            else
            {
                string url = "https://opentdb.com/api.php?amount=10&type=multiple";     //The url used to make the Api call.
                HttpClient client = new HttpClient();
                string fetchedJSON = client.GetStringAsync(url).Result;         //The Api call is made and the Result is saved as a string.

                QuestionDB questions = new QuestionDB();        //Creates a instance of the QuestionDB class.

                for (int i = 0; i < QuestionCount; i++)
                {
                    Question question = new Question(fetchedJSON, i);   //Loops over the amount of questions there are passing in the JSON and the Number the Question is.
                    questions.AddQuestion(question);                    //Adds the Question to the QuestionDB instance
                }

                Session["Questions"] = questions;   //Sets the questions into a Session
                int num = 0;
                int displayNum = num;
                num++;
                Session["Count"] = num;     //Sets the Current Question number into a session

                return View(questions.GetQuestionAt(displayNum));       //Passes a model into the View
            }            
        }

        /*
         * The QuizController Continue method using POST is used to continue displaying the rest of the questions.
         * Passes a string to the ViewBag if representing if the answer was true, false
         * Returns the User to the Home Page if no one is logged in.
         */
        [HttpPost]
        public ActionResult Continue(string Questions)
        {
            if (Session["User"] == null)        //Checks if a User is logged in.
            {
                return Redirect("../Home/Index");       //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
            }
            else
            {
                QuestionDB questions = (QuestionDB)Session["Questions"];    //The QuestionDB instance is set from the Session Questions
                int num = (int)Session["Count"];                            //The Current question number is retrived from the Session

                if (questions.GetQuestionAt(num - 1).IsAnswer(Questions))   //Checks if the user got the previous question correct
                {
                    string yes = "Correct";
                    ViewBag.ANS = yes;              //Sets ViewBag based on answer.
                }
                else
                {
                    string no = "InCorrect";
                    ViewBag.ANS = no;               //Sets ViewBag based on answer.
                }

                int displayNum = num;
                num++;
                Session["Count"] = num;

                if (num > questions.QuestionCount())    //Checks if the last question has been completed
                {
                    Session["Finshed"] = true;          //Calls the Score method and sets the Finshed Session to true.
                    return Score();
                }
                Session["Finshed"] = false;             
                return View(questions.GetQuestionAt(displayNum));       //Passes a model into the View
            }          
        }

        /*
         * The QuizController StartQuiz method using Get is used to redirect the User to the Home Page because this page cant be accessed using a GET request.
         */
        [HttpGet]
        public ActionResult StartQuiz()
        {
            return Redirect("../Home/Index");       //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
        }        

        /*
         * The QuizController Score method using GET is used to display the final score that the user got as well as saving that result into the DataBase.
         */
        [HttpGet]
        public ActionResult Score()
        {
            if ((Session["User"] == null) || ((bool)Session["Finshed"] == false))   //Checks that a User is logged in and All the questions have been answered.
            {
                return Redirect("../Home/Index");       //return Redirect used instead of return View because Return View simply displays the View without calling the relevant controller method causing the page to be static.
            }
            else
            {
                QuestionDB questions = (QuestionDB)Session["Questions"];    //The QuestionDB instance is set from the Session Questions
                QuizDBDataContext db = new QuizDBDataContext();             //Creates a instance of the Database
                tblResult result = new tblResult                            //Creates a new instance of tblResult to be saved into the Database
                {
                    PlayerID = (int)Session["UserID"],      //Sets the PlayerID from the ID stored in the Session
                    Score = questions.QuestionRoundScore(), //Sets the Score for the round as well as the current DateTime stamp
                    ResultDateTime = DateTime.Now
                };
                                
                db.tblResults.InsertOnSubmit(result);
                try     //Try catch used to submit the changes to the Database
                {
                    db.SubmitChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                
                ViewBag.TotalScore = questions.TotalScore();

                return View("Score");
            }
        }
    }
}