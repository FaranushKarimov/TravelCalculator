using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TravelCalculator.Core.Configuration;
using TravelCalculator.Persistence.Data;
using TravelCalculator.Service.Countries;

namespace TravelCalculator
{
    public static class Bootstrapper
    {
        private static IConfigurationRoot _configuration = new ConfigurationBuilder()
          // .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

        public static void AddConfigurationOptions(this IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<ConnectionStrings>(_configuration.GetSection("ConnectionStrings"));
            services.Configure<IOSettings>(_configuration.GetSection("IOSettings"));
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));
        }
        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<ICountryService, CountryService>();
        }
    }
}
