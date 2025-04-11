using System;
using System.Collections.Generic;

namespace CatalogProject.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? GenreId { get; set; }

    public string? Description { get; set; }

    public string? Review { get; set; }

    public decimal? Rating { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Genre? Genre { get; set; }
}
