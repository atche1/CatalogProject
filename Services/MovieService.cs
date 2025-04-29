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
                    catalogContext.Movies.Remove(movie);
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Movie GetMovieByName(string movieTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie != null)
                {
                    return movie;
                }
                else
                {
                    return null;
                }
            }
        }
        public bool InsertMovie(string title, int directorId, int genreId, string description, string review, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var existingMovie = catalogContext.Movies.FirstOrDefault(m => m.Title == title);
                if (existingMovie != null)
                {
                    return false;
                }
                var newMovie = new Movie
                {
                    Title = title,
                    DirectorId = directorId,
                    GenreId = genreId,
                    Description = description,
                    Review = review,
                    Rating = rating
                };
                catalogContext.Movies.Add(newMovie);
                catalogContext.SaveChanges();
                return true;
            }
        }
        public int GetDirectorId(string firstName, string lastName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var director = catalogContext.Directors
                    .FirstOrDefault(d => d.FirstName == firstName && d.LastName == lastName);
                return director.Id;
            }
        }
        public int GetGenreId(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Genres
                    .FirstOrDefault(g => g.GenreName == genreName);

                return genre.Id;
            }
        }
        public bool InsertMovieReview(string movieTitle, string review)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie.Review == null)
                {
                    movie.Review = review;
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool InsertMovieRating(string movieTitle, int rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.FirstOrDefault(m => m.Title == movieTitle);
                if (movie.Rating == null)
                {
                    movie.Rating = rating;
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
