namespace AddressBook
{
    public class PersonValidator : IPersonValidator
    {
        public bool Validate(Person person)
        {
            return person.Equals(null);
        }
    }
}