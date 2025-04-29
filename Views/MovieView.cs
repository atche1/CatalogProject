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
        public void AddMovie()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter director first name: ");
            string directorFirstName = Console.ReadLine();

            Console.Write("Enter director last name: ");
            string directorLastName = Console.ReadLine();
            int directorId = movieService.GetDirectorId(directorFirstName, directorLastName);

            Console.Write("Enter movie genre: ");
            string genre = Console.ReadLine();
            int genreId = movieService.GetGenreId(genre);

            Console.Write("Enter movie description: ");
            string description = Console.ReadLine();

            Console.Write("Enter movie review(0-200 symbols): ");
            string review = Console.ReadLine();

            Console.Write("Enter movie rating(1-10): ");
            decimal rating = decimal.Parse(Console.ReadLine());

            movieService.InsertMovie(title, directorId, genreId, description, review, rating);
        }
        public void AddMovieReview()
        {
            Console.Write("Enter the title of the movie: ");
            string movieTitle = Console.ReadLine();
            Movie movie = movieService.GetMovieByName(movieTitle);
            Console.Write("Enter movie review(0-200 symbols): ");
            string review = Console.ReadLine();
            if (movie == null)
            {
                Console.WriteLine("Movie doesn't exist!");
            }
            else
            {
                movie.Review = review;
                Console.WriteLine("Successfully added review.");
            }

        }
        public void AddMovieRating()
        {
            Console.Write("Enter the title of the movie: ");
            string movieTitle = Console.ReadLine();
            Movie movie = movieService.GetMovieByName(movieTitle);
            Console.Write("Enter movie rating(1-10): ");
            decimal rating = decimal.Parse(Console.ReadLine());
            if (movie == null)
            {
                Console.WriteLine("Movie doesn't exist!");
            }
            else
            {
                movie.Rating = rating;
                Console.WriteLine("Successfully added rating.");
            }

        }
        public void ChangeMovieInfo()
        {
            Console.Write("Enter the title of the movie you want to make changes on: ");
            string movieTitle = Console.ReadLine();
            Movie movie = movieService.GetMovieByName(movieTitle);
            if (movie == null)
            {
                Console.WriteLine("Movie doesn't exist!");
            }
            else
            {
                Console.Write("Enter director first name: ");
                string directorFirstName = Console.ReadLine();

                Console.Write("Enter director last name:");
                string directorLastName = Console.ReadLine();
                int directorId = movieService.GetDirectorId(directorFirstName, directorLastName);

                Console.Write("Enter movie genre:");
                string genre = Console.ReadLine();
                int genreId = movieService.GetGenreId(genre);

                Console.Write("Enter movie description:");
                string description = Console.ReadLine();

                Console.Write("Enter movie review(0-200 symbols): ");
                string review = Console.ReadLine();

                Console.Write("Enter movie rating(1-10): ");
                decimal rating = decimal.Parse(Console.ReadLine());

                movieService.UpdateMovie(movieTitle, directorId, genreId, description, review, rating);
            }
        }
    }
}
