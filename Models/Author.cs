namespace LibraryPortalBlazorWebApp.Components.Models;

public class Author
{
   public int author_id { get; set; }
    public string author_name { get; set; }
    public string country { get; set; }
    public string address { get; set; }
    public string phone { get; set; }
    public string email { get; set; }
    public DateTime? create_date { get; set; }
    public bool active { get; set; }
}