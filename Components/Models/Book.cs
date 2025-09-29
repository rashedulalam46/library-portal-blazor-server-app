using System;

namespace LibraryPortalBlazorWebApp.Components.Models;

public class Book
{
    public int BookId { get; set; }               // Primary key
    public string Title { get; set; } = "";       // Book title
    public string Description { get; set; } = ""; // Book description
    public int? AuthorId { get; set; }            // Author ID
    public int? CategoryId { get; set; }          // Category ID
    public int? PublisherId { get; set; }         // Publisher ID
    public DateTime? PublishDate { get; set; }    // Publish date
    public string ISBN { get; set; } = "";        // ISBN number
    public decimal? Price { get; set; }           // Price
    public DateTime? CreateDate { get; set; }     // Creation date
    public bool Active { get; set; } = true;    
}