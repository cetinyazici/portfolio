using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.Contact;
using BusinessLayer.ValidationRules.Portfolios;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DToLayer.ContactDtos;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IChooseusService, ChooseusManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IPortfolioService, PortfolioManager>();
            services.AddScoped<IPortfolioDetailsService, PortfolioDetailsManager>();
            services.AddScoped<IServicesService, ServicesManager>();
            services.AddScoped<ISkillsService, SkillsManager>();
            services.AddScoped<ISummaryService, SummaryManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
        }
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IChooseusDal, EfChooseusDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IPortfolioDal, EfPortfolioDal>();
            services.AddScoped<IPortfolioDetailsDal, EfPortfolioDetailsDal>();
            services.AddScoped<IServicesDal, EfServicesDal>();
            services.AddScoped<ISkillsDal, EfSkillsDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<ISummaryDal, EfSummaryDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
        }
        public static void ConfigureApplicationCookie(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/SignIn/";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.SlidingExpiration = true;
            });
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
            })
            .AddEntityFrameworkStores<Context>()
            .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider);
        }
        public static void ConfigureFluentValidation(this IServiceCollection services)
        {
            services.AddTransient<IValidator<SendMessageDto>, SendContactValiator>();
            services.AddTransient<IValidator<Portfolio>, PortfolioValid>();
        }

    }
}
