using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesCode
{
    public class Movies
    {
        public int Mid { get; set; }
        public string moviename { get; set; }
        public DateTime dataofrelease { get; set; }
    }
    public class MovieDbContext : DbContext
    {
        public DbSet<Movies> movies { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
    public class MovieRepository
    {
        private MovieDbContext dbContext;
        public MovieRepository()
        {
            dbContext = new MovieDbContext();
        }
        public List<Movies> GetAllMovies()
        {
            return dbContext.movies.ToList();
        }
        public class MovieController : Controller
        {
            private MovieRepository repository;
            public MovieController()
            {
                repository = new MovieRepository();
            }
            public Action Index()
            {
                var movies = repository.GetAllMovies();
                return view(movies);
            }
            private Action view(List<Movies> movies)
            {
                throw new NotImplementedException();
            }
            public class MovieRepository : MovieRepository
            {
                private MovieDbContext db = new MovieDbContext();
                public IEnumerable<Movies> GetAllMovies()
                {
                    return db.movies.ToList();
                }
                public Movies GetMovieByID(int id)
                {
                    return db.movies.Find(id);
                }
                public AddMovies(Movies movie)
                {
                    db.movies.Add(movie);
                    db.SaveChanges();
                }
                public void UpdateMovie(Movies movie)
                {
                    db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                public void DeleteMovie(int id)
                {
                    var movie = db.movies.Find(id);
                    if (movie != null)
                    {
                        db.movies.Remove(movie);
                        db.SaveChanges();
                    }
                }
                public IEnumerable<Movies> GetMoviesReleaseInYear(int year)
                {
                    return db.movies.Where(m => m.dataofrelease.Year == year).ToList();
                }
                public void Displose()
                {
                    db.Dispose();
                }
            }
        }
    }
}