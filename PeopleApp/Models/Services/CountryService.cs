using PeopleApp.Models.Repos;
using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepo _countryRepo;

        public CountryService(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }

        public Country Create(CreateCountryViewModel createCountry)
        {
            if (string.IsNullOrWhiteSpace(createCountry.Name))
            {
                throw new ArgumentNullException("Country name not allowed with white space or empty.");
            }
            return _countryRepo.Create(new Country(createCountry.Name)); 
        }

        public List<Country> All()
        {
            return _countryRepo.Read();
        }

        public bool Edit(int id, CreateCountryViewModel countryViewModel)
        {
            throw new NotImplementedException();
        }

        public Country FindById(int id)
        {
            return _countryRepo.GetById(id);
        }

        public Country? LastAdded()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            Country country = _countryRepo.GetById(id);
            bool success = _countryRepo.Delete(country);
            return success;
        }

        public List<Country> Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
