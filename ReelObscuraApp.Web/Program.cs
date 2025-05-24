using ReelObscuraApp.Web.Models;
using ReelObscuraApp.Web.Services;
namespace ReelObscuraApp.Web
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IMovieService, MovieService>();
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error"); // Hanterar 500-fel
                app.UseStatusCodePagesWithReExecute("/Error/{0}"); // Hanterar 404 och andra statuskoder
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage(); // Utvecklingsläge, visa detaljerade fel
            }
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}