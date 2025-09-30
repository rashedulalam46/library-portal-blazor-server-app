namespace LibraryPortalBlazorWebApp.Components.Models;

public class Category
{
    public int CategoryId { get; set; }           
    public string CategoryName { get; set; } 
    public DateTime? CreateDate { get; set; }      
    public bool Active { get; set; } = true;  
}