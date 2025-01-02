using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Question_2.Repository;
using MVC_Question_2.Models;


namespace MVC_Question_2.Repository
{
    public class MovieRepository
    {       
            private readonly MovieContext _context;

            public MovieRepository(MovieContext context)
            {
                _context = context;
            }

            public IEnumerable<Movie> GetAll() => _context.Movie.ToList();

        public Movie GetById(int id) => _context.Movie.Find(id);

        public void Insert(Movie movie) => _context.Movie.Add(movie);

        public void Update(Movie movie)
        {
            _context.Entry(movie).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }
        }

        public void Save() => _context.SaveChanges();
    }
}
