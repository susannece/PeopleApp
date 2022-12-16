using PeopleApp.Models.ViewModels;
using PeopleApp.Models.Repos;

namespace PeopleApp.Models.Services
{
    public class PeopleService : IPeopleService
    {
         IPeopleRepo _peopleRepo;
        private readonly ICityRepo _cityRepo;
        public PeopleService(IPeopleRepo peopleRepo, ICityRepo cityRepo)
        {
            _peopleRepo = peopleRepo;
            _cityRepo = cityRepo;
        }
        public Person Create(CreatePersonViewModel createPerson)
        {
            if(string.IsNullOrWhiteSpace(createPerson.FullName) || string.IsNullOrWhiteSpace(createPerson.PhoneNumber)) 
            {
                throw new ArgumentException("Name, and Phonenumber not allowed with white space or empty.");
            }

            var city = _cityRepo.GetById(createPerson.CityId);
            if(city == null)
            {
                throw new ArgumentException("There is no city.");
            }
            Person person = new Person()
            {
                FullName = createPerson.FullName,
                PhoneNumber = createPerson.PhoneNumber,
                City = city
            };
            _peopleRepo.Create(person);
            return person;
        }

        public bool Edit(int id, CreatePersonViewModel editPerson)
        {
            throw new NotImplementedException();
        }

        public Person FindById(int id)
        {
            return _peopleRepo.GetById(id);
        }

        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public bool Remove(int id)
        {
            Person person = _peopleRepo.GetById(id);   
            bool success = _peopleRepo.Delete(person);
            return success;
        }

        public List<Person> Search(string search)
        {
            throw new NotImplementedException();
        }

        /*
        public Person? LastAdded()
        {
            List<Person> persons = _peopleRepo.Read();  
            if(persons.Count < 1)
            {
                return null;
            }
            else
            {
               // return persons[persons.Count-1];
                return persons.Last();
            }
        }
        */

    }
}
