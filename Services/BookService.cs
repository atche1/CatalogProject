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
        public bool DeleteBookByName(string bookTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var book = catalogContext.Books.FirstOrDefault(b => b.Title == bookTitle); 
                if (book != null)
                {
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool InsertBook(string title, int authorId, int genreId, string description, string review, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var existingBook = catalogContext.Books.FirstOrDefault(b => b.Title == title);
                if (existingBook != null)
                {
                    return false;
                }
                var newBook = new Book
                {
                    Title = title,
                    AuthorId = authorId,
                    GenreId = genreId,
                    Description = description,
                    Review = review,
                    Rating = rating
                };
                catalogContext.Books.Add(newBook);
                catalogContext.SaveChanges();
                return true;
            }
        }
        public int GetAuthorId(string firstName, string lastName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var author = catalogContext.Authors
                    .FirstOrDefault(a => a.FirstName == firstName && a.LastName == lastName);
                return author.Id;
            }
        }
        public int GetGenreId(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var genre = catalogContext.Genres
                    .FirstOrDefault(g => g.GenreName == genreName);

                return genre.Id;
            }
        }
    }
}
