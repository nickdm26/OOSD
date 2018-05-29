/*
 * Nick Muldrew
 * Movie Class is used to hold the details about a movie.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_DataBase
{
    class Movie
    {
        //The Movie Datafields
        private int year;
        private String title;
        private String director;

        /*
         * The Year get and set method.
         */
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        /*
         * The Title Get and set method.
         */
        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /*
         * The Director Get and set method.
         */
        public String Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
        
        /*
         * The Movie Constructer.
         */
        public Movie()
        {

        }

        /*
         * The Movie constructer takes three parameters and then sets them to their datafields.
         */
        public Movie(int year, String title, String director)
        {
            this.year = year;
            this.title = title;
            this.director = director;
        }

        /*
         * The ToString method prints out the details of movie in a easy to read fashion.
         */
        public override String ToString()
        {
            String CustomString = year.ToString() + " , " + title + " , " + director;
            return CustomString;
        }
    }
}
