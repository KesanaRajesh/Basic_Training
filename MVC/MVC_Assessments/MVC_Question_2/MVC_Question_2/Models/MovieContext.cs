using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Question_2.Models
{
    public class MovieContext: DbContext
    {
        public MovieContext() : base("name=MoviesDB") { }
        public DbSet<Movie> Movie { get; set; }

    }
}