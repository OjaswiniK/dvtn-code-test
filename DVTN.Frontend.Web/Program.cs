using System.Reflection;
using Microsoft.AspNetCore.Mvc.Razor;
using DVTN.Frontend.Web.Features.HomePage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.Configure<RazorViewEngineOptions>(o =>
{
    o.ViewLocationFormats.Clear();
    o.ViewLocationFormats.Add("/Features/{1}/{0}" + RazorViewEngine.ViewExtension);
    o.ViewLocationFormats.Add("/Features/Shared/{0}" + RazorViewEngine.ViewExtension);
    o.ViewLocationFormats.Add("/Components/ViewComponents/{0}" + RazorViewEngine.ViewExtension);
});

//Register the services with the DI container
builder.Services.AddTransient<INewService, NewService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Configure Status Code Re-Direct error Pages for Dev env
app.UseStatusCodePagesWithRedirects("/ErrorPage/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();