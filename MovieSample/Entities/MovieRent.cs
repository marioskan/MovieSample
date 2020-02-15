using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSample.Entities
{
    public class MovieRent
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string MovieName { get; set; }
        public DateTime RentDateTime { get; set; }
    }
}