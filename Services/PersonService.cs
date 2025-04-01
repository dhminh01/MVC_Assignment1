using MVC_Assignment1.Models;
using MVC_Assignment1.Data;

namespace MVC_Assignment1.Services
{
    public class PersonService : IPersonService
    {
        private readonly List<Person> _people;

        //Get data from DummyData class
        public PersonService()
        {
            _people = DummyData.GetPeople();
        }
        public List<Person> GetAll()
        {

            return _people;
        }

        public List<Person> GetMales()
        {

            return _people.Where(p => p.Gender == Gender.Male).ToList();
        }

        public Person GetOldest()
        {

            return _people.OrderBy(p => p.DateOfBirth).First();
        }

        public List<string> GetFullNames()
        {

            return _people.Select(p => p.FullName).ToList();
        }
        public List<Person> FilterByBirthYear(string condition)
        {

            return condition.ToLower() switch
            {
                "equal" => _people.Where(p => p.DateOfBirth.Year == 2000).ToList(),
                "greater" => _people.Where(p => p.DateOfBirth.Year > 2000).ToList(),
                "less" => _people.Where(p => p.DateOfBirth.Year < 2000).ToList(),
                _ => new List<Person>()
            };
        }

    }
}