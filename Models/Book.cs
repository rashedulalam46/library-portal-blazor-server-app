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
	

	public bool active { get; set; }
    }

    // DTO for reading/fetching book data
    public class BookRead
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AuthorId { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }
        public DateTime? PublishDate { get; set; }
        public string ISBN { get; set; }
        public decimal? Price { get; set; }
        public bool Active { get; set; }
        public DateTime? CreateDate { get; set; }

        // Optionally: if you want to return related names
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public string PublisherName { get; set; }
    }
