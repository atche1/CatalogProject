using CatalogProject.Models;
using CatalogProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProject.Views
{
    internal class MovieView
    {
        private static MovieService movieService = new MovieService();
        public void ShowAllMovies()
        {
            List<Movie> movies = movieService.GetAllMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine($"- {movie.Title}");
            }
        }
        public void ShowAllDirectors()
        {
            List<Director> directors = movieService.GetAllDirectors();
            foreach (var director in directors)
            {
                Console.WriteLine($"- {director.FirstName} {director.LastName}");
            }
        }
    }
}
