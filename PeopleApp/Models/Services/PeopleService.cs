﻿using PeopleApp.Models.ViewModels;
using PeopleApp.Models.Repos;

namespace PeopleApp.Models.Services
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepo _peopleRepo;
        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }
        public Person Create(CreatePersonViewModel createPerson)
        {
            if(string.IsNullOrWhiteSpace(createPerson.Name) || string.IsNullOrWhiteSpace(createPerson.City) || string.IsNullOrWhiteSpace(createPerson.PhoneNumber)) 
            {
                throw new ArgumentException("Name, City, Phonenumber not allowed with white space or empty.");
            }
            Person person = new Person()
            {
                Name = createPerson.Name,
                PhoneNumber = createPerson.PhoneNumber,
                City = createPerson.City
            };
            person = _peopleRepo.Create(person);
            return person;
        }

        public bool Edit(int id, CreatePersonViewModel editPerson)
        {
            throw new NotImplementedException();
        }

        public Person FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}