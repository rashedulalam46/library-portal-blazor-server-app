namespace LibraryPortalBlazorWebApp.Components.Models;

public class Publisher
{
    public int PublisherId { get; set; }            // Primary key
    public string PublisherName { get; set; } = ""; // Publisher name
    public string Address { get; set; } = "";       // Address
    public string Phone { get; set; } = "";         // Phone number
    public string Email { get; set; } = "";         // Email address
    public DateTime? CreateDate { get; set; }       // Creation date
    public bool Active { get; set; } = true;        // Active stat
}