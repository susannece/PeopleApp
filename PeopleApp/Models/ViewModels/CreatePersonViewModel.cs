using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name="Person")]
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public int CityId { get; set; }
        public List<City>? Cities { get; set; }


    }
}
