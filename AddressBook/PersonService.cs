using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private IPersonValidator _personValidator;

        public PersonService(IPersonRepository personRepository, IPersonValidator validator)
        {
            _personValidator = validator;
            _personRepository = personRepository;
        }

        public IList<Person> Search(string pattern)
        {
            return _personRepository.GetAll().Where(p => p.ToString().Contains(pattern)).ToList();
        }

        public void Add(Person person)
        {
            if (_personValidator.Validate(person))
            {
                _personRepository.Add(person);
            }
           
        }

        public IList<Person> GetAll()
        {
            return (Search(string.Empty));
        }

    }
}