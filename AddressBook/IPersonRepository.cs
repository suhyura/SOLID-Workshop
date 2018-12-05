using System.Collections.Generic;

namespace AddressBook
{
    public interface IPersonRepository
    {
        IList<Person> GetAll();
        void Add(Person person);
    }
}