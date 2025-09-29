using System;

namespace LibraryPortalBlazorWebApp.Components.Models;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int AuthorId { get; set; }
    public int CategoryId { get; set; }
    public int PublisherId { get; set; }
}