using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDatabase
{
    public class City
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int Population { set; get; }

        public City(string cityName, string countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }

        public string toString()
        {
            return CityName + " " + CountryName + " " + Population;
        }
    }
}
