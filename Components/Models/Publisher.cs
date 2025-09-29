namespace LibraryPortalBlazorWebApp.Components.Models;

public class Publisher
{
    public int PublisherId { get; set; }
    public string PublisherName { get; set; } 
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime? CreateDate { get; set; }
    public bool Active { get; set; } 
}