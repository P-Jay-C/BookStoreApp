using BookStoreApp.Repository;
using Microsoft.Extensions.FileProviders;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<BookRepository>();

#if DEBUG

        builder.Services.AddRazorPages().AddRazorRuntimeCompilation(); // Prevent rebuilding of project to update view
#endif

        var app = builder.Build();

        //app.Use(async (context, next) =>
        //{
        //    await context.Response.WriteAsync("Hello My first Middle Ware");

        //    await next();
        //});
        if (builder.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();

        //app.UseStaticFiles(new StaticFileOptions()
        //{
        //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
        //    RequestPath = "/MyStaticFiles"

        //});



        app.UseRouting();

        app.UseEndpoints(endpoints => {
            endpoints.MapDefaultControllerRoute();
        });
     

        app.Run();
    }
}