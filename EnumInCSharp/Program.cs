// See https://aka.ms/new-console-template for more information


//Accessing Enum
using EnumInCSharp.Enums;

Days today = Days.Monday;

Permissions permissions = Permissions.Read | Permissions.Write;

var name = Enum.GetName(typeof(Days), today);
var values = Enum.GetValues(typeof(Days));

Console.ReadLine();
