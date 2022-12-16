using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PeopleApp.Models.ViewModels
{
    public class CreateCityViewModel
    {
        [Display(Name = "City")]
        [Required]
        public string? Name;
        public List<Person>? Persons { get; set; }
        public int CountryId { get; set; }
        public List<Country>? Countries { get; set; }
        public CreateCityViewModel() 
        {
            Countries = new List<Country>(); 
        }

    }
}
