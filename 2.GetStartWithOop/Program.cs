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

            Person person2 = new();
            person2.Age = 26;
            person2.FirstName = "Parham";
            person2.LastName = "Darvishi";
            person2.PhoneNumber = "09129564205";

            Person person3 = new()
            {
                FirstName = "Parham",
                LastName = "Darvishi",
                PhoneNumber = "09129564205"
            };
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