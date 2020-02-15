using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSample.Entities
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Genre Genre { get; set; }
        public Rating Rating { get; set; }
    }
}