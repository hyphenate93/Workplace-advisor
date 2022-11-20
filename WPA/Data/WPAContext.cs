using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WPA.Models;


namespace WPA.Data
{
    public class WpaContext : DbContext
    {
        protected WpaContext(DbSet<CompanyModel> company)
        {
            Company = company;
        }

        public WpaContext(DbContextOptions options, DbSet<CompanyModel> company) : base(options)
        {
            Company = company;
        }




        public WpaContext()
        {
            var test = "stop";
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EMNAM9I\\MSSQLSERVER01;Database=WorkPlaceAdvisor;Integrated Security=True;",
                builder => { builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null); });
            base.OnConfiguring(optionsBuilder);
        }
    

    public DbSet<CompanyModel> Company { get; set; }

    }

}

