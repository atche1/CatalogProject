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
            Book book = bookService.DeleteBookByName(bookTitle);
            if (book != null)
            {
                Console.WriteLine("Successfully deleted!");
            }
            else
            {
                Console.WriteLine($"The book with title '{book.Title}' doesn't exists!");
            }
        }
    }
}
