using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.AutoFac;
using NorthwindUI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(options => 
    options.RegisterModule(new AutoFacBusinessModule())
));

builder.Services.AddScoped<ICartSessionService, CartSessionService>();
builder.Services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
var app = builder.Build();

app.UseStaticFiles();

app.UseSession();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Product}/{action=Index}/{id?}"
    );

app.Run();
