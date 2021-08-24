using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelCalculator.Domain.Enums
{
    public enum Months
    {
        [Description("Январь")]
        [Display(Name = "Январь")]
        January = 1,
        [Description("Февраль")]
        [Display(Name = "Февраль")]
        February = 2,
        [Description("Март")]
        [Display(Name = "Март")]
        March = 3,
        [Description("Апрель")]
        [Display(Name = "Апрель")]
        April = 4,
        [Description("Май")]
        [Display(Name = "Май")]
        May = 5,
        [Description("Июнь")]
        [Display(Name = "Июнь")]
        June = 6,
        [Description("Июль")]
        [Display(Name = "Июль")]
        Jule = 7,
        [Description("Август")]
        [Display(Name = "Август")]
        August = 8,
        [Description("Сентябрь")]
        [Display(Name = "Сентябрь")]
        September = 9,
        [Description("Октябрь")]
        [Display(Name = "Октябрь")]
        October = 10,
        [Description("Ноябрь")]
        [Display(Name = "Ноябрь")]
        November = 11,
        [Description("Декабрь")]
        [Display(Name = "Декабрь")]
        December = 12 
    }
}
