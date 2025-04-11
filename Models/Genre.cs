using System;
using System.Collections.Generic;

namespace CatalogProject.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
