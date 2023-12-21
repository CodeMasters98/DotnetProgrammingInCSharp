// See https://aka.ms/new-console-template for more information
object data = "1376";

if (data is int number)
{
    Console.WriteLine($"data is number: {number}");
}
else if (data is string text)
{
    Console.WriteLine($"data is string: {text}");
}
else
{
    Console.WriteLine($"unknown type");
}
