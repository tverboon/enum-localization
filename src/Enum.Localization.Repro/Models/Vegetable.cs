using System.ComponentModel.DataAnnotations;

namespace Enum.Localization.Repro.Models
{
    public enum Vegetable
    {
        [Display(Name = "Kale")]
        Kale,

        [Display(Name = "Spinach")]
        Spinach,

        [Display(Name = "Cauliflower")]
        Cauliflower
    }
}