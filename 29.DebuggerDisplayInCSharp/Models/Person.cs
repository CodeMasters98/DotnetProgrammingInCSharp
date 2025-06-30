using System.Diagnostics;

namespace _29.DebuggerDisplayInCSharp.Models;

[DebuggerDisplay("Person {Id}: {Name} with {Age} years old.")]
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
