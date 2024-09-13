using Ksenya_Modul7.Models;
using Microsoft.EntityFrameworkCore;
using MusicCatalog.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddControllersWithViews();

      //  builder.Services.AddScoped<Person, Song>;
        // Add services to the container.
        builder.Services.AddRazorPages();

        //builder.Services.AddDbContext<DataBaseContext>(options =>
        //   options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        string connectionString =
            builder.Configuration.GetConnectionString("ApplicationContextConnectionString") ?? throw new InvalidDataException("Connection string ApplicationContextConnectionString is not found");
        builder.Services.AddDbContext<MyDbContext>(context => context.UseMySQL(connectionString));

        using var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}