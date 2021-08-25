using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCalculator.Domain.Models.Entities
{
    public class Continent
    {
        public int Id { get; set; }
        public string ContinentName { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
    }
}
