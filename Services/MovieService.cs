using CatalogProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProject.Services
{
    public class MovieService
    {
        public List<Movie> GetAllMovies()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Movie> movies = catalogContext.Movies.ToList();
                return movies;
            }
        }
        public List<Director> GetAllDirectors()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Director> directors = catalogContext.Directors.ToList();
                return directors;
            }
        }
        public List<Movie> FilterMoviesByGenre(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Movies.Include(m => m.Genre).Where(m => m.Genre.GenreName == genreName).ToList();
                return genre;
            }
        }
        public bool DeleteMovieByName(string movieTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie != null)
                {
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
