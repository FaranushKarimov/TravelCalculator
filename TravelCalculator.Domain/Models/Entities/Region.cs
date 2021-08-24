using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCalculator.Domain.Models.Entities
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public virtual ICollection<Resort> Resorts { get; set; }
        public virtual Country Country { get; set; }
    }
}
