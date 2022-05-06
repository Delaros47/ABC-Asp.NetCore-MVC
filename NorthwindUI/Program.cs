using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.AutoFac;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(options => 
    options.RegisterModule(new AutoFacBusinessModule())
));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Product}/{action=Index}/{id?}"
    );

app.Run();
