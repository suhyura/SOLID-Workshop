namespace AddressBook
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return  FirstName.ToString() + " " 
                  + MiddleName.ToString()+ " "
                  + LastName.ToString()  + " " 
                  + Phone.ToString();

        }
    }
}