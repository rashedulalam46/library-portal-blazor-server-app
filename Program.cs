using LibraryPortalBlazorWebApp.Components;


using LibraryPortalBlazorWebApp.Components.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

// Register services and inject IConfiguration
builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<PublisherService>();

var app = builder.Build();

// ... existing middleware
app.Run();