using CatalogProject.Views;

namespace CatalogProject
{
    public class Program
    {
        private static BookView bookView = new BookView();
        private static MovieView movieView = new MovieView();
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Catalog Project ===");
                Console.WriteLine("1. Manage Movies");
                Console.WriteLine("2. Manage Books");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":
                        ShowMovieMenu();
                        break;
                    case "2":
                        ShowBookMenu();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ShowMovieMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Movie Menu ===");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. View All Movies");
            Console.WriteLine("3. Filter Movies by Genre");
            Console.WriteLine("4. Edit Movie");
            Console.WriteLine("5. Delete Movie");
            Console.WriteLine("6. Add Review to Movie");
            Console.WriteLine("7. Add Rating to Movie");
            Console.WriteLine("8. Search for Movie by it's Description");
            Console.WriteLine("9. Sort Movies in Alphabetical Order");
            Console.WriteLine("0. Return to Main Menu");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    movieView.AddMovie();
                    break;
                case "2":
                    movieView.ShowAllMovies();
                    break;
                case "3":
                    movieView.ShowMoviesByGenre();
                    break;
                case "4":
                    movieView.ChangeMovieInfo();
                    break;
                case "5":
                    movieView.RemoveMovieByName();
                    break;
                case "6":
                    movieView.AddMovieReview();
                    break;
                case "7":
                    movieView.AddMovieRating();
                    break;
                case "8":
                    movieView.SearchMovieByDescription();
                    break;
                case "9":
                    movieView.ShowSortedMovies();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Console.ReadLine();
                    break;
            }
        }

        static void ShowBookMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Book Menu ===");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Filter Books by Genre");
            Console.WriteLine("4. Edit Book");
            Console.WriteLine("5. Delete Book");
            Console.WriteLine("6. Add Review to Book");
            Console.WriteLine("7. Add Rating to Book");
            Console.WriteLine("8. Search for Book by it's Description");
            Console.WriteLine("9. Sort Books in Alphabetical Order");
            Console.WriteLine("0. Return to Main Menu");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bookView.AddBook();
                    break;
                case "2":
                    bookView.ShowAllBooks();
                    break;
                case "3":
                    bookView.ShowBooksByGenre();
                    break;
                case "4":
                    bookView.ChangeBookInfo();
                    break;
                case "5":
                    bookView.RemoveBookByName();
                    break;
                case "6":
                    bookView.AddBookReview();
                    break;
                case "7":
                    bookView.AddBookRating();
                    break;
                case "8":
                    bookView.SearchBookByDescription();
                    break;
                case "9":
                    bookView.ShowSortedBooks();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
