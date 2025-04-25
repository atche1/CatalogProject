using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogProject.Services
{
    public class BookService
    {
        public List<Book> FilterBookByGenre(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Books.Include(b => b.Genre).Where(b => b.Genre.GenreName == genreName).ToList();
                return genre;
            }
        }
        public List<Book> GetAllBooks()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Book> books = catalogContext.Books.ToList();
                return books;
            }
        }
        public List<Author> GetAllAuthors()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Author> authors = catalogContext.Authors.ToList();
                return authors;
            }
        }
        public Book DeleteBookByName(string bookTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var book = catalogContext.Books.FirstOrDefault(b => b.Title == bookTitle);
                catalogContext.SaveChanges();
                return book;
            }//if a trqbva da e tuka
        }
    }
}
