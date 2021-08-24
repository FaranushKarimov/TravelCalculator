using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelCalculator.Domain.Enums
{
    public enum SeasonType
    {
        [Description("Неподходящий сезон")]
        [Display(Name = "Неподходящий сезон")]
        NoSeason = 0,
        [Description("Пляжный сезон")]
        [Display(Name = "Пляжный сезон")]
        BeachSeason = 1,
        [Description("Экскурсионный сезон")]
        [Display(Name = "Экскурсионный сезон")]
        ExcersionSeason = 2,
        [Description("Горнолыжный сезон")]
        [Display(Name = "Горнолыжный сезон")]
        SkiSeason = 3
    }
}
