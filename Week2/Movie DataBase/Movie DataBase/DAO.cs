/*
 * Nick Muldrew
 * The DAO Class holds the Movies in a SortedDictonary while providing other methods to access the SortedDiconary objects.
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataBase
{
    class DAO
    {
        //DataField
        private SortedDictionary<int, Movie> Movies;

        /*
         * The DAO Constructer instalises the Movies SortedDictonary.
         */
        public DAO()
        {
            Movies = new SortedDictionary<int, Movie>();
        }

        /*
         * The AddMovie method checks that a movie can be added to the dictonary then does it if it can.
         */
        public void AddMovie(int Key, Movie ToAdd)
        {            
            try
            {
                Movies.Add(Key, ToAdd);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("An element with Key = \"Key\" already exists.");
            }
        }

        /*
         * The DeleteMovie takes a key and checks if its in the dictonary, if it is then it removes it.
         */
        public void DeleteMovie(int Key)
        {
            if(Movies.ContainsKey(Key))
            {
                Movies.Remove(Key);
            }
        }

        /*
         * The Search method takes a key and checks if it exists, If it does then it returns the Movie associated with that key.
         */
        public Movie Search(int Key)
        {
            Movie value;
            Movies.TryGetValue(Key, out value);
            return value;
        }

        /*
         * The GetMovies method loops through the dictonary and the adds each element to a list then returns that list.
         */
        public List<Movie> GetMovies()
        {
            List<Movie> MovieList = new List<Movie>();
            foreach(Movie i in Movies.Values){
                MovieList.Add(i);
            }
            return MovieList;
        }    
    }
}