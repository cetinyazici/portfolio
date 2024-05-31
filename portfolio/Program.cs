using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IChooseusService, ChooseusManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IPortfolioDetailsService, PortfolioDetailsManager>();
builder.Services.AddScoped<IServicesService, ServicesManager>();
builder.Services.AddScoped<ISkillsService, SkillsManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IChooseusDal, EfChooseusDal>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IPortfolioDal, EfPortfolioDal>();
builder.Services.AddScoped<IPortfolioDetailsDal, EfPortfolioDetailsDal>();
builder.Services.AddScoped<IServicesDal, EfServicesDal>();
builder.Services.AddScoped<ISkillsDal, EfSkillsDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
