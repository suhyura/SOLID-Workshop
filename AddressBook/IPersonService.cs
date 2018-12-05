using System.Collections.Generic;

namespace AddressBook
{
    public interface IPersonService
    {
        IList<Person> Search(string pattern);
        void Add(Person person);
        IList<Person> GetAll();
    }
}