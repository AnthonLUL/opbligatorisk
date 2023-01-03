using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int LengthInMinutes { get; set; }
        public string CountryOfOrigin { get; set; }

        public Movie(int id, string movieName, int lengthInMinutes, string countryOfOrigin)
        {
            Id = id;
            MovieName = movieName;
            LengthInMinutes = lengthInMinutes;
            CountryOfOrigin = countryOfOrigin;
        }
        public Movie()
        {

        }
    }
}
