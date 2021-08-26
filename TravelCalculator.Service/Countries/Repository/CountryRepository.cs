using System;
using System.Collections.Generic;
using System.Text;
using TravelCalculator.Core.Repository;
using TravelCalculator.Domain.Models.Entities;
using TravelCalculator.Persistence.Data;

namespace TravelCalculator.Service.Countries.Repository
{
    public class CountryRepository : GenericRepository<DataContext,Country,int>
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }
    }


}
