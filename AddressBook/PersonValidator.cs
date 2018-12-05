namespace AddressBook
{
    public class PersonValidator
    {
        public bool Validate(Person person)
        {
            return person.Equals(!null);
        }
    }
}