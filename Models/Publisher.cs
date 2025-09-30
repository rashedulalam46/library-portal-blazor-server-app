namespace LibraryPortalBlazorWebApp.Components.Models;

public class Publisher
{
    public int publisher_id { get; set; }
    public string publisher_name { get; set; }
    public string address { get; set; }
    public string phone { get; set; }
    public string email { get; set; }
    public DateTime? create_date { get; set; }
    public bool active { get; set; }
}