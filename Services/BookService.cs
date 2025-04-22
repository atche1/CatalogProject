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
        //private readonly CatalogContext catalogContext;

        public void FilterBookByGenre(string genreName)
        {
            using (var catalogContext = new CatalogContext())
            {
                var category = catalogContext.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Genre.GenreName == genreName);
            }
        }
        static void PrintFilmsByCategoryName()
        {
            string categoryName = Console.ReadLine();
            var category = context.Categories.Include(c => c.FilmCategories).ThenInclude(c => c.Film).FirstOrDefault(c => c.Name == categoryName);
            if (category != null)
            {
                foreach (var fc in category.FilmCategories)
                {
                    Console.WriteLine(fc.Film.Title);
                }
            }
            else
            {
                Category newCategory = new Category() { Name = categoryName };
                context.Categories.Add(newCategory);
                context.SaveChanges();
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
    }
}
