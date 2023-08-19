namespace DotnetProgrammingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 26;
            person.FirstName = "Parham";
            person.LastName = "Darvishi";
            person.PhoneNumber = "09129564205";
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
    }
}