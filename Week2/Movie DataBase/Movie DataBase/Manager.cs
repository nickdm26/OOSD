/*
 * Nick Muldrew
 * The Manager class takes in the input for each of the textBoxs and checks that its all viable as well as displays the output back onto the DisplayBoxs.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_DataBase
{
    class Manager
    {
        //DataField
        private DAO dao;

        /*
         * The Manager Constructer instalises the DAO then adds 10 Movies so it has some content.
         */
        public Manager()
        {
            dao = new DAO();
            Add("2009", "Avatar", "James Cameron");
            Add("2008", "The Dark Knight", "Christopher Nolan");
            Add("2007", "Spider-Man 3", "Sam Raimi");
            Add("2016", "Rogue One: A Star Wars Story", "Gareth Edwards");
            Add("2015", "Star Wars Ep. VII: The Force Awakens", "J.J. Abrams");
            Add("2014", "American Sniper", "Clint Eastwood");
            Add("2012", "The Avengers", "Joss Whedon");
            Add("2011", "Harry Potter and the Deathly Hallows: Part II", "David Yates");
            Add("2010", "Toy Story 3", "Lee Unkrich");
            Add("2013", "The Hunger Games: Catching Fire", "Francis Lawrence");
        }

        /*
         * The Add Method takes 3 string parameters and checks the input is viable otherwise it displays a message using the MessageBox.
         * When its viable it adds the movie into the DAO.
         */
        public void Add(String year, String title, String director)
        {
            try
            {
                int Year = Int32.Parse(year);
                if(title == "" || director == "")
                {
                    throw new ArgumentException("Title or director cant be empty");
                }else if(Year < 1900 || Year > 2200)
                {
                    throw new ArgumentException("The year must be between 1900 and 2200");
                }

                Movie newMovie = new Movie(Year, title, director);
                dao.AddMovie(Year, newMovie);
            }catch(FormatException e)
            {
                MessageBox.Show("Invalid Year");
            }
            catch(ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /*
         * Almost exactly the same as the above Add except this one takes 3 TextBox parameters instead.
         * It takes these TextBoxs instead so that once everything passes then the textboxes that take the input can be cleared.
         */
        public void Add(TextBox year, TextBox title, TextBox director)
        {
            try
            {
                int Year = Int32.Parse(year.Text);
                if (title.Text == "" || director.Text == "")
                {
                    throw new ArgumentException("Title or director cant be empty");
                }
                else if (Year < 1900 || Year > 2200)
                {
                    throw new ArgumentException("The year must be between 1900 and 2200");
                }

                Movie newMovie = new Movie(Year, title.Text, director.Text);
                dao.AddMovie(Year, newMovie);
                year.Clear();
                title.Clear();
                director.Clear();
            }
            catch (FormatException e)
            {
                MessageBox.Show("Invalid Year");
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /*
         * The PrintAll method takes in the Display Box and makes a call to the DAO to get a list of the Movies.
         * Once it has the list it loops over it and displays the Movies in the Display Box.
         */
        public void PrintAll(ListBox displayBox)
        {
            displayBox.Items.Clear();
            List<Movie> movies = dao.GetMovies();
            foreach(Movie i in movies)
            {
                displayBox.Items.Add(i.ToString());
            }
        }

        /*
         * The Search method takes The Display Box and a string representing the year.
         * Checks that the year is viable then uses the DAO.Search method to grab the value associated with the key.
         * If it gets it then it simply displays it otherwise it says that no value exists for it.
         */
        public void Search(ListBox displayBox, String year)
        {
            try
            {
                displayBox.Items.Clear();
                int Year = Int32.Parse(year);
                Movie MovieSearched = dao.Search(Year);
                if (MovieSearched != null)
                {
                    displayBox.Items.Add(MovieSearched.ToString());
                }
                else
                {
                    displayBox.Items.Add("There was no Top Movie for " + Year);
                }
            }catch(FormatException e)
            {
                MessageBox.Show("Invalid Year");
            }
        }

        /*
         * The Delete method takes a Display Box and a year as a key to delete a value in the dictonary.
         * checks if the year is valid then calls the DeleteMovie in the DAO to delete the movie if it exists.
         */
        public void Delete(ListBox displayBox, String year)
        {
            try
            {
                displayBox.Items.Clear();
                int Year = Int32.Parse(year);
                dao.DeleteMovie(Year);
            }catch(FormatException e)
            {
                MessageBox.Show("Invalid Year");
            }
        }
    }
}