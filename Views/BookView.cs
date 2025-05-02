using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogProject.Services;
using CatalogProject.Models;
using System.IO;

namespace CatalogProject.Views
{
    public class BookView
    {
        private static BookService bookService = new BookService(); 
        public void ShowAllBooks()
        {
            List<Book> books = bookService.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"- {book.Title}");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void ShowAllAuthors()
        {
            List<Author> authors = bookService.GetAllAuthors();
            foreach (var author in authors)
            {
                Console.WriteLine($"- {author.FirstName} {author.LastName}");
            }
        }
        public void ShowAllGenres()
        {
            List<Genre> genres = bookService.GetAllGenres();
            foreach (var genre in genres)
            {
                Console.WriteLine($"- {genre.GenreName}");
            }
        }
        public void ShowBooksByGenre()
        {
            Console.Write("Please enter the name of the genre you want to filter with: ");
            Console.WriteLine();
            Console.WriteLine("Genres to choose from:");
            ShowAllGenres();
            Console.WriteLine();
            string genreName = Console.ReadLine();
            Console.WriteLine();
            List<Book> books = bookService.FilterBookByGenre(genreName);
            if (books != null)
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"- {book.Title}");
                }
            }
            else
            {
                Console.WriteLine("There are no books with this genre!");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void RemoveBookByName()
        {
            Console.Write("Please enter the title of the book that you want to remove: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine();
            bool result = bookService.DeleteBookByName(bookTitle);
            if (result==true)
            {
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine($"The book with title '{bookTitle}' doesn't exists!");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void AddBook()
        {
            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Authors to choose from:");
            ShowAllAuthors();
            Console.WriteLine();

            Console.Write("Enter author first name: ");
            string authorFirstName = Console.ReadLine();

            Console.Write("Enter author last name: ");
            string authorLastName = Console.ReadLine();
            int authorId = bookService.GetAuthorId(authorFirstName, authorLastName);
            Console.WriteLine();

            Console.WriteLine("Genres to choose from:");
            ShowAllGenres();
            Console.WriteLine();
            Console.Write("Enter book genre: ");
            string genre = Console.ReadLine();
            int genreId = bookService.GetGenreId(genre);
            Console.WriteLine();

            Console.Write("Enter book description: ");
            string description = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter book review(0-200 symbols): ");
            string review = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter book rating(1-10): ");
            decimal rating = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            if (bookService.InsertBook(title, authorId, genreId, description, review, rating) == true)
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
        public void AddBookReview()
        {
            Console.Write("Enter the title of the book: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine();
            Book book = bookService.GetBookByName(bookTitle);
            Console.Write("Enter book review(0-200 symbols): ");
            string review = Console.ReadLine();
            Console.WriteLine();
            if (book == null)
            {
                Console.WriteLine("Book doesn't exist!");
            }
            else
            {
                if (bookService.InsertBookReview(bookTitle, review) == true) {
                    Console.WriteLine("Successfully added review.");
                }
                else
                {
                    Console.WriteLine("There is already review for that book!");
                }
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void AddBookRating()
        {
            Console.Write("Enter the title of the book: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine();
            Book book = bookService.GetBookByName(bookTitle);
            Console.Write("Enter book rating(1-10): ");
            decimal rating = decimal.Parse(Console.ReadLine());
            Console.WriteLine();
            if (book == null)
            {
                Console.WriteLine("Book doesn't exist!");
            }
            else
            {
                if (bookService.InsertBookRating(bookTitle, rating) == true)
                {
                    Console.WriteLine("Successfully added rating.");
                }
                else
                {
                    Console.WriteLine("There is already rating for that book!");
                }
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void ChangeBookInfo()
        {
            Console.Write("Enter the title of the book you want to make changes on: ");
            string bookTitle =Console.ReadLine();
            Console.WriteLine();
            Book book = bookService.GetBookByName(bookTitle);
            if (book == null)
            {
                Console.WriteLine("Book doesn't exist!");
            }
            else
            {
                Console.WriteLine("Authors to choose from:");
                ShowAllAuthors();
                Console.WriteLine();

                Console.Write("Enter author first name: ");
                string authorFirstName = Console.ReadLine();

                Console.Write("Enter author last name: ");
                string authorLastName = Console.ReadLine();
                int authorId = bookService.GetAuthorId(authorFirstName, authorLastName);
                Console.WriteLine();

                Console.WriteLine("Genres to choose from:");
                ShowAllGenres();
                Console.WriteLine();
                Console.Write("Enter book genre: ");
                string genre = Console.ReadLine();
                int genreId = bookService.GetGenreId(genre);
                Console.WriteLine();

                Console.Write("Enter book description: ");
                string description = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter book review(0-200 symbols): ");
                string review = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter book rating(1-10): ");
                decimal rating = decimal.Parse(Console.ReadLine());
                Console.WriteLine();

                bookService.UpdateBook(bookTitle, authorId, genreId, description, review, rating);
                Console.WriteLine("Successfully updated!");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void SearchBookByDescription()
        {
            Console.Write("Enter book description: ");
            string description = Console.ReadLine();
            List<Book> books = bookService.MatchBookByDescription(description);
            if (books!=null)
            {
                Console.WriteLine("Books that match your description: ");
                foreach (Book book in books)
                {
                    Console.WriteLine($"- {book.Title}");
                }
            }
            else
            {
                Console.WriteLine("No books found that match your description.");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        public void ShowSortedBooks()
        {
            Console.WriteLine("Here are the sorted books: ");
            List<Book> books = bookService.GetBooksAlphabetically();
            foreach (Book book in books)
            {
                Console.WriteLine($"- {book.Title}");
            }
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}
