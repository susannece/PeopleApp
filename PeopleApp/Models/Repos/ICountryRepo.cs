namespace PeopleApp.Models.Repos
{
    public interface ICountryRepo
    {
        Country Create(Country country);
        List<Country> Read();
        Country Read(int id);
        Country GetById(int id);
        bool Update(Country country);
        bool Delete(Country country);
    }
}
