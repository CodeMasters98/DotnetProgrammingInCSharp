namespace PartialClassInCSharp
{
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public partial class Person
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
