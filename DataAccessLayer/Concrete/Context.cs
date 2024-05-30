using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= LAPTOP-KTG3A5B3; database= PortfolioDb; integrated security= true; TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Chooseus> Chooseuss { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioDetails> PortfolioDetailss { get; set; }
        public DbSet<Services> Servicess { get; set; }
        public DbSet<Skills> Skillss { get; set; }
    }
}
