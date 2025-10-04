using LibraryPortalBlazorServerApp;
using LibraryPortalBlazorServerApp.Services;


var builder = WebApplication.CreateBuilder(args);

// Bind ApiSettings from appsettings.json
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

// Add services
builder.Services.AddRazorComponents(); // or AddServerSideBlazor in older templates

// Add Blazor services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

// Register your application services
builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<PublisherService>();
builder.Services.AddScoped<DropdownService>();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// **This part is missing in your current file**
app.MapBlazorHub();    
app.MapFallbackToPage("/_Host");              // Maps the SignalR hub for Blazor Server

app.Run();
