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
                Console.WriteLine(book.Title);
            }
        }
    }
}
