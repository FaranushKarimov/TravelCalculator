using System;
using System.Collections.Generic;
using System.Text;
using TravelCalculator.Domain.Enums;

namespace TravelCalculator.Domain.Models.Entities
{
    public class Season
    {
        public int Id { get; set; }
        public Months Month { get; set; }
        public int CountryId { get; set; }
        public SeasonType seasonType { get; set; }
        public virtual Country Country { get; set; }
    }
}
