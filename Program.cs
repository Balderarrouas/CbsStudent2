using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CbsStudent2.Models;
using CbsStudent2.Data;
using Microsoft.AspNetCore.Identity;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CbsStudent2Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CbsStudent2Context") ?? throw new InvalidOperationException("Connection string 'CbsStudent2Context' not found.")));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddIdentity<IdentityUser,IdentityRole>()
.AddDefaultUI()
.AddEntityFrameworkStores<CbsStudent2Context>();
/*
builder.Services.AddDbContext<CbsStudent2Context>(options =>
    options.UseSqlite("CbsStudent2Context"));
    */
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
