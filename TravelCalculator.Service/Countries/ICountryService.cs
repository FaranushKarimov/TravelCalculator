using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TravelCalculator.Domain.Models.Entities;
using TravelCalculator.Service.Countries.Model;

namespace TravelCalculator.Service.Countries
{
    public interface ICountryService
    {
        Task<List<Responce>> GetCountriesFromContinet(int continentId);
        Task<int> GetCountryIdByName(string countryName);
    }
}
