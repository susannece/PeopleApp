using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Person>? Persons { get; set; } // = new List<Person>();

        public int CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
