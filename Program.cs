using Microsoft.EntityFrameworkCore;
using SFO.DAL;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        

        builder.Services.AddControllersWithViews();
        // Add services to the container.
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            var ConnectionString =
                builder.Configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(ConnectionString);
        });
        var app = builder.Build();

        // Configure the HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",  // Changed from "DefaultConnection" to "default"
            pattern: "{controller=Party}/{action=Partyview}/{id?}"
        );

        // Run the application
        app.Run();
    }
}