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
        NoSeason,
        [Description("Пляжный сезон")]
        [Display(Name = "Пляжный сезон")]
        BeachSeason,
        [Description("Экскурсионный сезон")]
        [Display(Name = "Экскурсионный сезон")]
        ExcersionSeason,
        [Description("Горнолыжный сезон")]
        [Display(Name = "Горнолыжный сезон")]
        SkiSeason
    }
}
