namespace _17.ConstructorInCSharp.Models
{
    public class PersonWithContsructor
    {
        public PersonWithContsructor(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
