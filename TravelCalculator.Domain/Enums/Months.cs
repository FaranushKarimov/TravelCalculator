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
        January,
        [Description("Февраль")]
        [Display(Name = "Февраль")]
        February,
        [Description("Март")]
        [Display(Name = "Март")]
        March,
        [Description("Апрель")]
        [Display(Name = "Апрель")]
        April,
        [Description("Май")]
        [Display(Name = "Май")]
        May,
        [Description("Июнь")]
        [Display(Name = "Июнь")]
        June,
        [Description("Июль")]
        [Display(Name = "Июль")]
        Jule,
        [Description("Август")]
        [Display(Name = "Август")]
        August,
        [Description("Сентябрь")]
        [Display(Name = "Сентябрь")]
        September,
        [Description("Октябрь")]
        [Display(Name = "Октябрь")]
        October,
        [Description("Ноябрь")]
        [Display(Name = "Ноябрь")]
        November,
        [Description("Декабрь")]
        [Display(Name = "Декабрь")]
        December 
    }
}
