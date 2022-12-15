using PeopleApp.Data;
using System;

namespace PeopleApp.Models.Repos
{
    public class DatabaseCountryRepo : ICountryRepo
    {
        readonly PeopleAppDbContext _peopleAppDbContext;

        public DatabaseCountryRepo(PeopleAppDbContext peopleAppDbContext)
        {
            _peopleAppDbContext = peopleAppDbContext;
        }

        public Country Create(Country country)
        {
           _peopleAppDbContext.Add(country);
            _peopleAppDbContext.SaveChanges();
            return country;
        }

        public Country GetById(int id)
        {
            return _peopleAppDbContext.Country.SingleOrDefault(country => country.Id == id);
        }

        public List<Country> Read()
        {
            return _peopleAppDbContext.Country.ToList();
        }

        public Country Read(int id)
        {
            return _peopleAppDbContext.Country.SingleOrDefault(country => country.Id == id);
        }

        public bool Update(Country country)
        {
            _peopleAppDbContext.Update(country);
            _peopleAppDbContext.SaveChanges();
            return true;
        }
        public bool Delete(Country country)
        {
            _peopleAppDbContext.Remove(country);
            _peopleAppDbContext.SaveChanges();
            return true;
        }

    }
}
