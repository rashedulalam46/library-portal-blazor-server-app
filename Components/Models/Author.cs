namespace LibraryPortalBlazorWebApp.Components.Models;

public class Author
{
   public int AuthorId { get; set; }           // Primary key
    public string AuthorName { get; set; } = ""; // Author name
    public string Country { get; set; } = "";    // Country code or name
    public string Address { get; set; } = "";    // Address
    public string Phone { get; set; } = "";      // Phone number
    public string Email { get; set; } = "";      // Email
    public DateTime? CreateDate { get; set; }    // Creation date
    public bool Active { get; set; } = true;     // Active status
}