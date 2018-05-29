/*
 * Nicholas Muldrew
 * OOSD Assignment 2
 * MULDND1
 */

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trivia_Quiz.Models
{
    /*
     * The Question Class is used to store information about a specfic question.
     * It also performs other functions such as reading in a JSON string and then extracting the information from that to set its data Fields.
     */
    public class Question
    {
        public string Category { get; set; }        //DataFields, some are extras becasue they leave room for extra functionality thats not been fully implemented
        public bool Type { get; set; }
        public string Difficulty { get; set; }
        public string QuestionRan { get; set; }
        public string Answer_Multiple { get; set; }
        public bool Answer_TrueFalse { get; set; }
        public string[] InCorrectAnswers { get; set; }
        public bool InCorrectAnswer { get; set; }
        public string[] Options { get; set; }
        public bool Mark { get; set; }

        /*
         * Question constructer is used to set the correct data fields for a multiple answers Question.
         */
        public Question(string category, bool type, string difficulty, string question, string answer_Multiple, string[] inCorrectAnswers)
        {
            this.Category = category;
            this.Type = type;
            this.Difficulty = difficulty;
            this.QuestionRan = question;
            this.Answer_Multiple = answer_Multiple;
            this.InCorrectAnswers = inCorrectAnswers;
        }

        /*
         * Question constructer is used to set the correct data fields for a true, false Question.
         */
        public Question(string category, bool type, string difficulty, string question, bool answer_TrueFalse, bool inCorrectAnswer)
        {
            this.Category = category;
            this.Type = type;
            this.Difficulty = difficulty;
            this.QuestionRan = question;
            this.Answer_TrueFalse = answer_TrueFalse;
            this.InCorrectAnswer = inCorrectAnswer;
        }

        /*
         * FillOptions is used to randomly fill the string array Options with the 4 diffrent options making sure that the Answer doesnt always get displayed in the same location.
         */
        public void FillOptions()
        {
            if (Type)
            {
                List<string> listOptions = new List<string>();  //Creates a list of string and passes in the three wrong answers and the 1 correct one.
                listOptions.Add(InCorrectAnswers[0]);
                listOptions.Add(InCorrectAnswers[1]);
                listOptions.Add(InCorrectAnswers[2]);
                listOptions.Add(Answer_Multiple);

                Options = new string[4];
                Random ran = new Random();
                
                for(int i = 0; i < 4; i++)
                {
                    int ranNum = ran.Next(listOptions.Count);       //Creates a random number between 0 and the size of the listOptions List

                    Options[i] = listOptions[ranNum];               //Sets the next option to the random option pulled from the list.
                    listOptions.RemoveAt(ranNum);                   //Removes the random option from the list so it cant be choosen again.
                }
            }
        }

        /*
         * IsAnswer is used to check if the inputed string is the correct answer
         * Sets the boolean Mark to true if its correct
         */
        public bool IsAnswer(string input)
        {
            Mark = string.Equals(input, Answer_Multiple);
            return Mark;
        }

        /*
         * The Question Constructer is used to take in a JSON string and a int representing the questionNum
         * Prases the JSON and then Saves the contents to its various data fields
         * Also uses the HttpUtility to decode the text and make sure its not encoded.
         */
        public Question(string fetchedJSON, int questionNum)
        {
            List<JObject> JsonArrayObs = new List<JObject>();
            List<JValue> answers = new List<JValue>();
            JObject baseObject = JObject.Parse(fetchedJSON);

            JsonArrayObs = baseObject["results"].Select(e => (JObject)e).ToList();                      //Converting the JSON objects into a List of JObjects
            answers = JsonArrayObs[questionNum]["incorrect_answers"].Select(e => (JValue)e).ToList();   //Converting the JSON objects into a List of JValues


            if (string.Equals("multiple", (string)JsonArrayObs[0]["type"]))     //Checks if the Question is a multiple answers one or just boolean.
            {
                Type = true;
            }else
            {
                Type = false;
            }

            Category = (string)JsonArrayObs[questionNum]["category"];               //Saving the parsed JSON Fields into normal data fields
            Difficulty = (string)JsonArrayObs[questionNum]["difficulty"];           
            QuestionRan = (string)JsonArrayObs[questionNum]["question"];
            Answer_Multiple = (string)JsonArrayObs[questionNum]["correct_answer"];
            InCorrectAnswers = new string[3];
            InCorrectAnswers[0] = (string)answers[0];
            InCorrectAnswers[1] = (string)answers[1];
            InCorrectAnswers[2] = (string)answers[2];

            Difficulty = HttpUtility.HtmlDecode(Difficulty);                    //Decodeing the DataFields
            Category = HttpUtility.HtmlDecode(Category);
            QuestionRan = HttpUtility.HtmlDecode(QuestionRan);
            Answer_Multiple = HttpUtility.HtmlDecode(Answer_Multiple);
            InCorrectAnswers[0] = HttpUtility.HtmlDecode(InCorrectAnswers[0]);
            InCorrectAnswers[1] = HttpUtility.HtmlDecode(InCorrectAnswers[1]);
            InCorrectAnswers[2] = HttpUtility.HtmlDecode(InCorrectAnswers[2]);

            FillOptions();              //Calls FillOptions to make sure the answer is not always in the same spot.
        }
    }
}