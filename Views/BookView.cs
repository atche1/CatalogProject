using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogProject.Services;
using CatalogProject.Models;

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
        }
        public void ShowAllAuthors()
        {
            List<Author> authors = bookService.GetAllAuthors();
            foreach (var author in authors)
            {
                Console.WriteLine($"- {author.FirstName} {author.LastName}");
            }
        }
        public void ShowBooksByGenre()
        {
            Console.Write("Please enter the name of the genre you want to filter with: ");
            string genreName = Console.ReadLine();
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
        }
        public void RemoveBookByName()
        {
            Console.Write("Please enter the title of the book that you want to remove: ");
            string bookTitle = Console.ReadLine();
            bool result = bookService.DeleteBookByName(bookTitle);
            if (result==true)
            {
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine($"The book with title '{bookTitle}' doesn't exists!");
            }
        }
        public void AddBook()
        {
            Console.Write("Enter the title:");
            string title = Console.ReadLine();

            Console.Write("Enter author first name:");
            string authorFirstName = Console.ReadLine();

            Console.Write("Enter author last name:");
            string authorLastName = Console.ReadLine();
            int authorId = bookService.GetAuthorId(authorFirstName, authorLastName);

            Console.Write("Enter book genre:");
            string genre = Console.ReadLine();
            int genreId = bookService.GetGenreId(genre);

            Console.Write("Enter book description:");
            string description = Console.ReadLine();

            Console.Write("Enter book review(0-200 symbols):");
            string review = Console.ReadLine();

            Console.Write("Enter book rating(1-10):");
            decimal rating = decimal.Parse(Console.ReadLine());

            bookService.InsertBook(title, authorId, genreId, description, review, rating);
        }
        public void AddBookReview()
        {
            Console.Write("Enter the title of the book: ");
            string bookTitle = Console.ReadLine();
            Book book = bookService.GetBookByName(bookTitle);
            Console.Write("Enter book review(0-200 symbols):");
            string review = Console.ReadLine();
            if (book == null)
            {
                Console.WriteLine("Book doesn't exist!");
            }
            else
            {
                book.Review = review;
                Console.WriteLine("Successfully added review.");
            }
            
        }
        public void AddBookRating()
        {
            Console.Write("Enter the title of the book: ");
            string bookTitle = Console.ReadLine();
            Book book = bookService.GetBookByName(bookTitle);
            Console.Write("Enter book rating(1-10):");
            decimal rating = decimal.Parse(Console.ReadLine());
            if (book == null)
            {
                Console.WriteLine("Book doesn't exist!");
            }
            else
            {
                book.Rating = rating;
                Console.WriteLine("Successfully added rating.");
            }

        }
    }
}
