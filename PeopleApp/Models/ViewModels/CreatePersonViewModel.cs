using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name="Person")]
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }


    }
}
