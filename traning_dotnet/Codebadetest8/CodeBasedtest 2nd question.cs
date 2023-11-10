using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity;
namespace MovieApp.Models
{
    public class Movies
    {
        public int Mid { get; set; }
        public string MovieName { get; set; }
        public DateTime DateofRelease { get; set; }
    }
    public class MovieDbContext : MovieDbContext
    {
        public DbSet<Movies> Movies { get; set; }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Entry(Movies movie)
        {
            throw new NotImplementedException();
        }
    }
    public interface MyMovieRepositry : IDisposable
    {
        IEnumerable<Movies> GetMovies();
        Movies GetMovies(int id);
        void AddMovie(Movies movies);
        void UpdateMovie(Movies movies);
        void DeleateMovie(Movies movies);
        IEnumerable<Movies> GetMovieReleaseintheyear(int year);
    }
    public class MovieRepository :MovieRepository
    {
        private MovieDbContext db = new MovieDbContext();
        public IEnumerable<Movies> GetAllMovies()
        {
            return db.Movies.ToList();
        }
        public Movies GetMovieByID(int id)
        {
            return db.Movies.Find(id);
        }
        public AddMovie(Movies movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public void UpdateMovie(Movies movie)
        {
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteMovie(int id)
        {
            var movie = db.Movies.Find(id);
            if (movie != null)
            {
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
        }
        public IEnumerable<Movies> GetMoviesReleaseInYear(int year)
        {
            return db.Movies.Where(m => m.DateOfRelease.Year == year).ToList();
        }
        public void Displose()
        {
            db.Dispose();
        }
    }
}
