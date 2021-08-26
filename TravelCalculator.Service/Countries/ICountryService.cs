using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TravelCalculator.Domain.Models.Entities;

namespace TravelCalculator.Service.Countries
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountriesFromContinet(int continentId);
    }
}
