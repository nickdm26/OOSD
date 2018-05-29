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
     * The QuestionDB is used to hold a List of Questions which a user makes there way through.
     */
    public class QuestionDB
    {
        public List<Question> QuestionsDB;  //The list DataField

        /*
         * The QuestionDB Constructer
         */
        public QuestionDB()
        {
            QuestionsDB = new List<Question>();
        }

        /*
         * The AddQuestion method adds a Question to the List
         */
        public void AddQuestion(Question question)
        {
            QuestionsDB.Add(question);
        }

        /*
         * The QuestionCount method returns the amount of Questions in the list.
         */
        public int QuestionCount()
        {
            return QuestionsDB.Count;
        }

        /*
         *  The GetQuestionAt method returns the Question at the specifed index
         */
        public Question GetQuestionAt(int index)
        {
            return QuestionsDB.ElementAt(index);
        }

        /*
         * The DeleteQuestionAt method Deletes the Question at the Specfied index
         */
        public void DeleteQuestionAt(int index)
        {
            QuestionsDB.RemoveAt(index);
        }

        /*
         *  The TotalScore method returns the Score as a string eg. 2 / 10
         */
        public string TotalScore()
        {
            int CorrectNum = 0;
            for(int i = 0; i < QuestionCount(); i++)
            {
                if (GetQuestionAt(i).Mark)
                {
                    CorrectNum++;
                }
            }
            return CorrectNum + " / " + QuestionCount();
        }

        /*
         * The QuestionRoundScore returns the Score for that round
         */
        public int QuestionRoundScore()
        {
            int CorrectNum = 0;
            for (int i = 0; i < QuestionCount(); i++)
            {
                if (GetQuestionAt(i).Mark)
                {
                    CorrectNum++;
                }
            }
            return CorrectNum;
        }
    }
}