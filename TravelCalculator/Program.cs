using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TravelCalculator.Persistence.Data;
using Microsoft.Extensions.Logging;
using TravelCalculator.Service.Countries;
using TravelCalculator.Core.Configuration;
using System.IO;
using System.Linq;
using TravelCalculator.Domain.Enums;
using System.Collections.Generic;
using TravelCalculator.Domain.Models.Entities;

namespace TravelCalculator
{
    class Program
    {
        private static ICountryService _countryService;
        public static IServiceCollection Services = new ServiceCollection();
        public static IServiceProvider ServiceProvider;
        private static ConnectionStrings _connectionString = new ConnectionStrings();
        private static IOSettings _ioSettings = new IOSettings();
        private static DataContext _dataContext; 
        static void Main(string[] args)
        {
            BootstrapServices();
            Console.WriteLine("Begin");
            var csvContent = ReadCSV();
            string[] headers = csvContent[0].Split(";");
            Dictionary<string, List<string>> csv = headers.ToDictionary(x => x, x => new List<string>());
            List<Season> seasons = new Season[csvContent.Skip(1).Select(c => c.Split(";")[0]).Count()].Select(x => new Season()).ToList();
            for (int i = 0; i < csv.Count; i++)
            {
                csv[headers[i]] = csvContent.Skip(1).Select(c => c.Split(";")[i]).ToList();
                for (var j = 0; j < csv[headers[i]].Count; j++)
                {
                    if (i == 0)
                    {
                        seasons[j].Month = (Months)Enum.ToObject(typeof(Months), int.Parse(csv[headers[i]][j]));
                    }

                    if (i == 1)
                    {
                        var countryName = csv[headers[i]][j];
                        int countryId =  _countryService.GetCountryIdByName(countryName);//repos.GetCountryIdByName(countryName);
                        seasons[j].Country.CountryName = countryName;
                        seasons[j].CountryId = countryId;
                    }

                    if (i == 2)
                    {
                        var seasonType = csv[headers[i]][j];
                        seasons[j].seasonType = seasonType == "Экскурсионный" ? SeasonType.ExcersionSeason :
                            seasonType == "Пляжный" ? SeasonType.BeachSeason :
                            seasonType == "Горнолыжный" ? SeasonType.SkiSeason : SeasonType.NoSeason;
                    }
                }
            }

            _dataContext.Seasons.AddRange(seasons);
            _dataContext.SaveChanges();

            //await _seasonRepos.AddRangeAsync(seasons)
            //{
            //    await _context.Seasons.AddRangeAsync(seasons);
            //    await _context.SaveChangesAsync();
            //};

            foreach (var season in seasons)
            {
                Console.WriteLine(season.ToString());
            }

            Console.ReadKey();
        }

        private static List<string> ReadCSV()
        {
            Console.Clear();
            Console.Write("Begin\nWrite csv file path: ");
            var csvFilePath = Console.ReadLine();
            if (string.IsNullOrEmpty(csvFilePath) || !File.Exists(csvFilePath))
            {
                Console.WriteLine("Incorrect file path!\nPress any key to continue...");
                Console.ReadKey();
                ReadCSV();
            }
            return File.ReadAllLines(csvFilePath).ToList();
        }
      

        //var countryService = ServiceProvider.GetService<ICountryService>();

        //    try
        //    {
        //        //calling the serivce
        //        countryService.GetCountriesFromContinet(1);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}

        private static void BootstrapServices()
        {
            Services.AddConfigurationOptions();
            Services.AddService();
            ServiceProvider = Services.BuildServiceProvider();
        }

    }
}