namespace LibraryPortalBlazorWebApp.Components.Models;

public class Author
{
    public int AuthorId { get; set; }
    public string AuthorName { get; set; } = "";
    public string Country { get; set; } = "";
    public string Address { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public DateTime? CreateDate { get; set; }
    public bool Active { get; set; } = true;
}