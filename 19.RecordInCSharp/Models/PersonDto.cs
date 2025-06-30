namespace _19.RecordInCSharp.Models
{
    public record PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //Creates immutable properties.
    //Implements value-based equality.
    //Generates a Deconstruct method.

    public record ProductDto2(int Id, string Name);
}
