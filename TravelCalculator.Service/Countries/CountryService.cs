using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelCalculator.Domain;
using TravelCalculator.Domain.Models.Entities;
using TravelCalculator.Service.Countries.Model;
using TravelCalculator.Service.Countries.Repository;

namespace TravelCalculator.Service.Countries
{
    public class CountryService : ICountryService
    {
        private readonly CountryRepository _countryRepository;

        public CountryService(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<List<Responce>> GetCountriesFromContinet(int continentId)
        {
            return await _countryRepository.Entities.Include(x => x.Seasons).Where(x => x.ContinentId == continentId).Select(x => new Responce
            { Id = x.CountryId, CountryName = x.CountryName, IsPopularCountry = x.IsPopularCountry,Months = x.Seasons.Select(x => 
            new MonthResponce {Month = x.Month.ToString(),SeasonType = x.seasonType.ToString() }).ToList()}).ToListAsync();
        }

        public async Task<int> GetCountryIdByName(string countryName)
        {
            var country = await _countryRepository.Entities.FirstOrDefaultAsync(x => x.CountryName == countryName);
            if (country == null)
            {
                country = new Country
                {
                    CountryName = countryName
                };
                await _countryRepository.Create(country);
            }
            return country.CountryId;
        }
    }
}
