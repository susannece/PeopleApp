using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public interface ICountryService
    {
        Country Create(CreateCountryViewModel createCountry);
        List<Country> All();
        List<Country> Search(string search);
        Country FindById(int id);
        bool Edit(int id, CreateCountryViewModel countryViewModel);
        bool Remove(int id);

        public Country? LastAdded();
    }
}
