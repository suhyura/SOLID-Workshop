using System.Collections.Generic;

namespace AddressBook
{
    public class PersonRepository : IPersonRepository
    {
        List<Person> persons = new List<Person>
        {
            new Person{FirstName = "Yuriy" ,MiddleName = "Valevich",LastName = "Sukhov",Phone = "32323"},
            new Person{FirstName = "Yuriy2" ,MiddleName = "Vitlev",LastName = "Sukhov",Phone = "32323"},
            new Person{FirstName = "Yuriy3" ,MiddleName = "Vl3",LastName = "4",Phone = "32323"},
            new Person{FirstName = "Paw" ,MiddleName = "",LastName = "Klim",Phone = "32323"},

        };
        public PersonRepository()
        {
                
        }
        public IList<Person> GetAll()
        {
            return persons;
        }

        public void Add(Person person)
        {
           persons.Add(person);
        }
    }
}