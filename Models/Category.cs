namespace LibraryPortalBlazorWebApp.Components.Models;

public class Category
{
   public int category_id { get; set; }
    public string category_name { get; set; }
    public DateTime? create_date { get; set; }
    public bool active { get; set; }
}