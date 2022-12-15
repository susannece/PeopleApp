using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class Person 
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }

        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
