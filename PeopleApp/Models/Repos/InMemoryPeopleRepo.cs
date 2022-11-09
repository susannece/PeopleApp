namespace PeopleApp.Models.Repos
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        static int idCounter = 0;
        static List<Person> peopleList = new List<Person>();

        public Person Create(Person person)
        {
            person.Id = ++idCounter;
            peopleList.Add(person);
            return person;
        }

        public List<Person> Read()
        {
            return peopleList;
        }

        public Person Read(int id)
        {
            Person? person = null;
            foreach (Person p in peopleList)
            {
                if(p.Id == id)
                {
                    person = p;
                    break;
                }
            }
            return person;
        }

        public bool Update(Person person)
        {
            Person orgPerson = Read(person.Id);
            if(orgPerson != null)
            {
                orgPerson.Name = person.Name;
                orgPerson.PhoneNumber = person.PhoneNumber;
                orgPerson.City = person.City;
                return true;
            }
            return false;
        }

        public bool Delete(Person person)
        {
            if(person != null)
            {
                peopleList.Remove(person);
                return true;
            }
            return false;
        }
    }
}
