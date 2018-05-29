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

namespace Trivia_Quiz.Controllers
{
    public class HighScoreController : Controller
    {
        // GET: HighScore
        /*
         * The HighScoreController Index method access's the Database and uses linq to get the specfic information.
         * This information is then passed over to the view where it is then displayed inside a table.
         * The information gotten is from the current month and then it calculates the average score for each player from that month.
         */
        public ActionResult Index()
        {
            QuizDBDataContext db = new QuizDBDataContext();     //Creates a instance of the DB

            DateTime now = DateTime.Now;    //The current DateTime

            var Scores = from Re in db.tblResults           //The anonyomous datatype returned from the DB which is all Results from the current month.
                         join Pl in db.tblPlayers
                         on Re.PlayerID equals Pl.PlayerID
                         where Re.ResultDateTime.Month == now.Month
                         select new { Pl.PlayerName, Re.Score, Re.ResultDateTime };

            var nwScores = Scores.GroupBy(S => S.PlayerName)        //The anonyomous datatype which is the PlayerName, the average score for that player from this month and the GamesPlayed.
                                 .Select(a => new { PlayerName = a.Key, Avg = a.Average(av => av.Score), Count = a.Count() })
                                 .OrderByDescending(c => c.Avg);    //Orders the data by the Players average Score.
            
            List<Average> PlayerAverages = new List<Average>();

            foreach (var group in nwScores)     //Loops through the variable nwScores
            {
                Average nwAvg = new Average(group.PlayerName, group.Avg, group.Count);      //Sets each playerName, AverageScore and Games PLayed  to a Average object.
                PlayerAverages.Add(nwAvg);                  //Adds that current Average object to the PlayerAverages list.
            }
            
            ViewBag.Now = DateTime.Now.ToString("MMMM");

            ViewBag.AVG = PlayerAverages;       //Passes the PlayerAverages List to the ViewBag so it can be quickly accessed from the view.
            return View();
        }
    }
}