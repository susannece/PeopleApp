using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PeopleApp.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        [Display(Name = "Country")]
        [Required]
        public string? Name { get; set; }
        public List<City>? Cities { get; set; }
        public CreateCountryViewModel() { Cities = new List<City>(); }

    }
}
