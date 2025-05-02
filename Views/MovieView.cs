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
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void ShowAllDirectors()
        {
            List<Director> directors = movieService.GetAllDirectors();
            foreach (var director in directors)
            {
                Console.WriteLine($"- {director.FirstName} {director.LastName}");
            }
        }
        public void ShowAllGenres()
        {
            List<Genre> genres = movieService.GetAllGenres();
            foreach (var genre in genres)
            {
                Console.WriteLine($"- {genre.GenreName}");
            }

        }
        public void ShowMoviesByGenre()
        {
            Console.Write("Please enter the name of the genre you want to filter with: ");
            Console.WriteLine();
            Console.WriteLine("Genres to choose from:");
            ShowAllGenres();
            Console.WriteLine();
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
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
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
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void AddMovie()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Directors to choose from:");
            ShowAllDirectors();
            Console.WriteLine();

            Console.Write("Enter director first name: ");
            string directorFirstName = Console.ReadLine();

            Console.Write("Enter director last name: ");
            string directorLastName = Console.ReadLine();
            int directorId = movieService.GetDirectorId(directorFirstName, directorLastName);
            Console.WriteLine();

            Console.WriteLine("Genres to choose from:");
            ShowAllGenres();
            Console.WriteLine();
            
            Console.Write("Enter movie genre: ");
            string genre = Console.ReadLine();
            int genreId = movieService.GetGenreId(genre);
            Console.WriteLine();

            Console.Write("Enter movie description: ");
            string description = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter movie review(0-200 symbols): ");
            string review = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter movie rating(1-10): ");
            decimal rating = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            if (movieService.InsertMovie(title, directorId, genreId, description, review, rating) == true)
            {
                Console.WriteLine("Successfully added!");
            }
            else
            {
                Console.WriteLine("Successfully NOT added!!");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void AddMovieReview()
        {
            Console.Write("Enter the title of the movie: ");
            string movieTitle = Console.ReadLine();
            Console.WriteLine();
            Movie movie = movieService.GetMovieByName(movieTitle);
            Console.Write("Enter movie review(0-200 symbols): ");
            string review = Console.ReadLine();
            Console.WriteLine();
            if (movie == null)
            {
                Console.WriteLine("Movie doesn't exist!");
            }
            else
            {
                if (movieService.InsertMovieReview(movieTitle, review) == true)
                {
                    Console.WriteLine("Successfully added review.");
                }
                else
                {
                    Console.WriteLine("There is already review for that movie!");
                }
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void AddMovieRating()
        {
            Console.Write("Enter the title of the movie: ");
            string movieTitle = Console.ReadLine();
            Console.WriteLine();
            Movie movie = movieService.GetMovieByName(movieTitle);
            Console.Write("Enter movie rating(1-10): ");
            decimal rating = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            if (movie == null)
            {
                Console.WriteLine("Movie doesn't exist!");
            }
            else
            {
                if (movieService.InsertMovieRating(movieTitle, rating) == true)
                {
                    Console.WriteLine("Successfully added rating.");
                }
                else
                {
                    Console.WriteLine("There is already rating for that movie!");
                }
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void ChangeMovieInfo()
        {
            Console.Write("Enter the title of the movie you want to make changes on: ");
            string movieTitle = Console.ReadLine();
            Console.WriteLine();
            Movie movie = movieService.GetMovieByName(movieTitle);
            if (movie == null)
            {
                Console.WriteLine("Movie doesn't exist!");
            }
            else
            {
                Console.WriteLine("Directors to choose from:");
                ShowAllDirectors();
                Console.WriteLine();
                Console.Write("Enter director first name: ");
                string directorFirstName = Console.ReadLine();

                Console.Write("Enter director last name:");
                string directorLastName = Console.ReadLine();
                int directorId = movieService.GetDirectorId(directorFirstName, directorLastName);
                Console.WriteLine();

                Console.WriteLine("Genres to choose from:");
                ShowAllGenres();
                Console.WriteLine();
                Console.Write("Enter movie genre:");
                string genre = Console.ReadLine();
                int genreId = movieService.GetGenreId(genre);
                Console.WriteLine();

                Console.Write("Enter movie description:");
                string description = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter movie review(0-200 symbols): ");
                string review = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter movie rating(1-10): ");
                decimal rating = decimal.Parse(Console.ReadLine());
                Console.WriteLine();

                movieService.UpdateMovie(movieTitle, directorId, genreId, description, review, rating);

                Console.WriteLine("Successfully updated!");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void SearchMovieByDescription()
        {
            Console.Write("Enter movie description: ");
            string description = Console.ReadLine();
            List<Movie> movies = movieService.MatchMovieByDescription(description);
            if (movies != null)
            {
                Console.WriteLine("Movies that match your description: ");
                foreach (Movie movie in movies)
                {
                    Console.WriteLine($"- {movie.Title}");
                }
            }
            else
            {
                Console.WriteLine("No movies found that match your description.");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void ShowSortedMovies()
        {
            Console.WriteLine("Here are the sorted movies: ");
            List<Movie> movies = movieService.GetMoviesAlphabetically();
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"- {movie.Title}");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}
