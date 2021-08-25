using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelCalculator.Domain.Enums;
using TravelCalculator.Domain.Models.Entities;

namespace TravelCalculator.Domain
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsPopularCountry { get; set; }
        public int ContinentId { get; set; }
    //    public int MonthId { get; set; }
    //    public virtual DataMonth Month { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
//
     //   public virtual ICollection<CountryMonth> CountryMonths { get; set; }
    }
}
