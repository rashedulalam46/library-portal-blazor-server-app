using LibraryPortalBlazorWebApp.Components.Models;
using System.Net.Http.Json;

namespace LibraryPortalBlazorWebApp.Components.Services;

public class BookService
{
    private readonly HttpClient _http;

    public BookService(HttpClient http)
    {
        _http = http;
    }

    private readonly string baseUrl = "https://localhost:5001/api/books";

    public async Task<List<Book>> GetBooksAsync()
        => await _http.GetFromJsonAsync<List<Book>>(baseUrl) ?? new List<Book>();

    public async Task<Book?> GetBookAsync(int id)
        => await _http.GetFromJsonAsync<Book>($"{baseUrl}/{id}");

    public async Task<Book?> AddBookAsync(Book book)
    {
        var response = await _http.PostAsJsonAsync(baseUrl, book);
        return await response.Content.ReadFromJsonAsync<Book>();
    }

    public async Task<Book?> UpdateBookAsync(Book book)
    {
        var response = await _http.PutAsJsonAsync($"{baseUrl}/{book.BookId}", book);
        return await response.Content.ReadFromJsonAsync<Book>();
    }

    public async Task<bool> DeleteBookAsync(int id)
    {
        var response = await _http.DeleteAsync($"{baseUrl}/{id}");
        return response.IsSuccessStatusCode;
    }
}