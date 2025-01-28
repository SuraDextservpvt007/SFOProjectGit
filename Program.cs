using Microsoft.EntityFrameworkCore;
using SFO.Models;



public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
      options.UseSqlServer(
          builder.Configuration.GetConnectionString("DefaultConnection"))
             .EnableSensitiveDataLogging() // Enable to see full queries
             .LogTo(Console.WriteLine) // Logs to console for debugging
  );

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        
        app.MapControllerRoute(
     name: "DefaultConnection",
     pattern: "{controller=Login}/{action=Login}/{id?}"
 );

        // Run the application
        app.Run();
    }
}
