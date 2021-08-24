using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TravelCalculator.Persistence.Data;

namespace TravelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var services = new ServiceCollection();
            services.AddDbContext<DataContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
