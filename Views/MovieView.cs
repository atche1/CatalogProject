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
        public void ShowBooksByGenre()
        {
            Console.Write("Please enter the name of the genre you want to filter with: ");
            string genreName = Console.ReadLine();
            List<Movie> movies = movieService.FilterMoviesByGenre(genreName);
            if (movies != null)
            {
                foreach (var movie in movies)
                {
                    Console.WriteLine($"- {movie.Title}");
                }
            }
            else
            {
                Console.WriteLine("There are no movies with this genre!");
            }
        }
        public void RemoveMovieByName()
        {
            Console.Write("Please enter the title of the movie that you want to remove: ");
            string movieTitle = Console.ReadLine();
            bool result = movieService.DeleteMovieByName(movieTitle);
            if (result == true)
            {
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine($"The movie with title '{movieTitle}' doesn't exists!");
            }
        }
    }
}
