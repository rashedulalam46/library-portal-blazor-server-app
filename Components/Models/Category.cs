namespace LibraryPortalBlazorWebApp.Components.Models;

public class Category
{
    public int CategoryId { get; set; }           // Primary key
    public string CategoryName { get; set; } = ""; // Category name
    public DateTime? CreateDate { get; set; }      // Creation date
    public bool Active { get; set; } = true;  
}