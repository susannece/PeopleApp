﻿using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<City>? Cities { get; set; } // = new List<City>();
    }
}
