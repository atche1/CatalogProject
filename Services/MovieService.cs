using CatalogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogProject.Services
{
    public class MovieService
    {
        public List<Movie> GetAllMovies()
        {
            using (var catalogContext = new CatalogContext())
            {
                List<Movie> movies = catalogContext.Movies.ToList();
                return movies;
            }
        }
    }
}
