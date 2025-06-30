// See https://aka.ms/new-console-template for more information
using _19.RecordInCSharp.Models;

//Mutable record
PersonDto pe1 = new PersonDto() { Id = 1, Name = "Parham" };
PersonDto pe2 = new PersonDto() { Id = 1, Name = "Parham" };
//pe1.Name = "Parham2"; //-> You can change it
Console.WriteLine($"Mutable: {pe1 == pe2}");


//Immutable  record
var p1 = new ProductDto2(1, "Parham");
var p2 = new ProductDto2(1, "Parham");
//p1.Name = "test"; //-> you can not change it

//if you want to change record propery value in Immutable form
var p3 = p1 with { Name = "Reza" };

Console.WriteLine($"Immutable: {p1 == p2}");