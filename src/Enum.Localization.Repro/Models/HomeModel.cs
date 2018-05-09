using System.ComponentModel.DataAnnotations;

namespace Enum.Localization.Repro.Models
{
    public class HomeModel
    {
        public Vegetable Vegetable { get; set; } = Vegetable.Cauliflower;

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}