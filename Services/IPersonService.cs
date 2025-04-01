using MVC_Assignment1.Models;

namespace MVC_Assignment1.Services
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetOldest();
        List<Person> GetMales();
        List<string> GetFullNames();
        List<Person> FilterByBirthYear(string condition);
    }
}
