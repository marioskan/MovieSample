using MovieSample.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace MovieSample.Data
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieRent> Rents { get; set; }

        protected override void OnModelCreating(DbModelBuilder model)
        {

        }
    }
}