// See https://aka.ms/new-console-template for more information
using _29.DebuggerDisplayInCSharp.Models;

Console.WriteLine("Debugger Display!");
List<Person> people = new List<Person>()
{
    new Person(){ Name = "Parham",Age = 27,Id=1},
    new Person(){ Name = "Parsa",Age = 18,Id=2},
    new Person(){ Name = "Paria",Age = 25,Id=3}
};

//Use Delegate
people.ForEach(x => Console.WriteLine($"Name: {x.Name},Age: {x.Id}"));
