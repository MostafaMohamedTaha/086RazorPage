using Microsoft.EntityFrameworkCore;
using razor.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorDefault")));
builder.Services.AddRazorPages()
                    .AddSessionStateTempDataProvider();
builder.Services.AddControllersWithViews()
                    .AddSessionStateTempDataProvider();

builder.Services.AddSession();
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapRazorPages();

app.Run();
