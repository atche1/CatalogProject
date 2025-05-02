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
        public List<Genre> GetAllGenres()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Genre> genres = catalogContext.Genres.ToList();
                return genres;
            }
        }
        public bool DeleteBookByName(string bookTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var book = catalogContext.Books.FirstOrDefault(b => b.Title == bookTitle); 
                if (book != null)
                {
                    catalogContext.Books.Remove(book);
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Book GetBookByName(string bookTitle)
        {
            using (var catalogContext = new CatalogContext())
            {
                var book = catalogContext.Books.FirstOrDefault(b => b.Title == bookTitle);
                if (book != null)
                {
                    return book;
                }
                else
                {
                    return null;
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
        public bool UpdateBook(string title, int authorId, int genreId, string description, string review, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var existingBook = catalogContext.Books.FirstOrDefault(b => b.Title == title);
                if (existingBook == null)
                {
                    return false;
                }
                existingBook.AuthorId = authorId;
                existingBook.GenreId = genreId;
                existingBook.Description = description;
                existingBook.Review = review;
                existingBook.Rating = rating;

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
        public bool InsertBookReview(string bookTitle, string review)
        {
            using(var catalogContext = new CatalogContext())
            {
                var book = catalogContext.Books.FirstOrDefault(b => b.Title == bookTitle);
                if (book.Review==null)
                {
                    book.Review = review;
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool InsertBookRating(string bookTitle, decimal rating)
        {
            using (var catalogContext = new CatalogContext())
            {
                var book = catalogContext.Books.FirstOrDefault(b => b.Title == bookTitle);
                if (book.Rating == null)
                {
                    book.Rating = rating;
                    catalogContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<Book> MatchBookByDescription(string description)
        {
            using (var catalogContext = new CatalogContext())
            {
                var keywords = description.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                List<Book> books = catalogContext.Books
                    .Where(b => b.Description != null &&
                                keywords.Any(kw => b.Description.ToLower().Contains(kw)))
                    .ToList();
                return books;
            }
        }
        public List<Book> GetBooksAlphabetically()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Book> books = catalogContext.Books
                    .OrderBy(b => b.Title)
                    .ToList();
                return books;
            }
        }
    }
}
