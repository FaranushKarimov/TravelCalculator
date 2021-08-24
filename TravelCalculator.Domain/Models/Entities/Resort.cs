using System;
using System.Collections.Generic;
using System.Text;
using TravelCalculator.Domain.Enums;

namespace TravelCalculator.Domain.Models.Entities
{
    public class Resort
    {
        public int ResortId { get; set; }
        public int RegionId { get; set; }
        public string ResortName { get; set; }
        public string ShortDescription { get; set; }
        public SeasonType Season { get; set; }
        public virtual Region Region { get; set; }
    }
}
