using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TravelCalculator.Domain;
using TravelCalculator.Domain.Models.Entities;

namespace TravelCalculator.Persistence.Data
{
    public class DataContext:DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        //public DbSet<Region> Regions { get; set; }
        //public DbSet<Month> Months { get; set; }
        //public DbSet<CountryMonth> CountryMonths { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Season> Seasons { get; set; }
        //public DbSet<Continent> Continents { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            Database.EnsureCreated(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder();
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            //builder.AddJsonFile("appsettings.json");
            //var config = builder.Build();
            //string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql("User ID=postgres; Password=mspz3jic; Host=localhost; Port=5432; Database=Seasons; Integrated Security=true; Pooling=true;");
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
