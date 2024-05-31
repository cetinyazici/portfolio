using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.Contact;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DToLayer.ContactDtos;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation();

// FluentValidation kurallarýný kaydedin
builder.Services.AddTransient<IValidator<SendMessageDto>, SendContactValiator>();

builder.Services.AddDbContext<Context>();

// Register services
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IChooseusService, ChooseusManager>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IPortfolioDetailsService, PortfolioDetailsManager>();
builder.Services.AddScoped<IServicesService, ServicesManager>();
builder.Services.AddScoped<ISkillsService, SkillsManager>();

// Register data access layers
builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IChooseusDal, EfChooseusDal>();
builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IPortfolioDal, EfPortfolioDal>();
builder.Services.AddScoped<IPortfolioDetailsDal, EfPortfolioDetailsDal>();
builder.Services.AddScoped<IServicesDal, EfServicesDal>();
builder.Services.AddScoped<ISkillsDal, EfSkillsDal>();

builder.Services.AddAutoMapper(typeof(Program));

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

app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();
