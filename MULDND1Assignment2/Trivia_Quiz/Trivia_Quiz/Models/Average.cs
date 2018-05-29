/*
 * Nicholas Muldrew
 * OOSD Assignment 2
 * MULDND1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trivia_Quiz.Models
{
    /*
     * The Average class is used to store the that should be displayed on the highscores page.
     */
    public class Average
    {
        public string PlayerName { get; set; }          //DataFields
        public double PlayerAverageScore { get; set; }
        public int GamesPlayed { get; set; }

        /*
         * The Average Constructer is used to instalise all the DataFields.
         */
        public Average(string PlayerName, double PlayerAverageScore, int GamesPlayed)
        {
            this.PlayerName = PlayerName;
            this.PlayerAverageScore = PlayerAverageScore;
            this.GamesPlayed = GamesPlayed;
        }
    }
}