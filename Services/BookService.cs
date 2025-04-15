using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogProject.Models;

namespace CatalogProject.Services
{
    public class BookService
    {
        //private readonly CatalogContext catalogContext;

        public void FilterBookByCategory(string categoryName)
        {

        }
        public List<Book> GetAllBooks()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Book> books = catalogContext.Books.ToList();
                return books;
            }
        }
    }
}
