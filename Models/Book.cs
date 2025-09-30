using System;

namespace LibraryPortalBlazorWebApp.Components.Models;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public int? AuthorId { get; set; }
    public int? CategoryId { get; set; }
    public int? PublisherId { get; set; }
    public DateTime? PublishDate { get; set; }
    public string ISBN { get; set; } = "";
    public decimal? Price { get; set; }
    public DateTime? CreateDate { get; set; }
    public bool Active { get; set; } = true;
}