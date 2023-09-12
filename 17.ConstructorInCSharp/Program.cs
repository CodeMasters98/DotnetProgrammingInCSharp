// See https://aka.ms/new-console-template for more information


using _17.ConstructorInCSharp.Models;

Person person = new Person();
person.FirstName = "Parham";
person.LastName = "Darvishi";
person.PhoneNumber = "+989129564205";
Console.WriteLine(person.FirstName);

PersonWithContsructor person1 = new PersonWithContsructor(firstName:"Parham",lastName:"Darvishi",phoneNumber:"+989129564205");
Console.WriteLine(person1.FirstName);