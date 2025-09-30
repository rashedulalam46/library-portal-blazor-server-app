using System;

namespace LibraryPortalBlazorWebApp.Components.Models;

public class Book
{
    public int book_id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int? author_id { get; set; }
    public int? category_id { get; set; }
    public int? publisher_id { get; set; }
    public DateTime? publish_date { get; set; }
    public string ISBN { get; set; }
    public decimal? price { get; set; }
    public DateTime? create_date { get; set; }
    public bool? active { get; set; }
}