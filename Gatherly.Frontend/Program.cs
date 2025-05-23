using Gatherly.Frontend.Clients;
using Gatherly.Frontend.Components;
// using Users.hyeji.dotnet.GatherlyBlazor.Gatherly_Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

var GatherlyApiUrl = builder.Configuration["GatherlyApiUrl"] ?? throw new Exception("GatherlyApiUrl is not set");

builder.Services.AddHttpClient<StudiesClient>(client => client.BaseAddress = new Uri(GatherlyApiUrl));

builder.Services.AddHttpClient<UsersClient>(client => client.BaseAddress = new Uri(GatherlyApiUrl));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
