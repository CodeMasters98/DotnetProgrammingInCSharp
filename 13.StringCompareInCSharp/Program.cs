// See https://aka.ms/new-console-template for more information


//Benchmark
string str1 = "Hello";
string str2 = "Hello";

Console.WriteLine("Compare by ==");
if (str1 == str2)
{
    Console.WriteLine("Strings are equal.");
}

Console.WriteLine("*******************************************");
Console.WriteLine("Compare by Equals");

if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Strings are equal (case-insensitive).");
}


Console.WriteLine("*******************************************");
Console.WriteLine("Compare by Compare");
int result = string.Compare(str1, str2);

if (result == 0)
{
    Console.WriteLine("Strings are equal.");
}
else if (result < 0)
{
    Console.WriteLine("str1 comes before str2.");
}
else
{
    Console.WriteLine("str1 comes after str2.");
}

Console.WriteLine("*******************************************");
Console.WriteLine("Compare by Compare with case check");
if (string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase) == 0)
{
    Console.WriteLine("Strings are equal (case-insensitive).");
}

Console.WriteLine("*******************************************");
Console.WriteLine("Check contain!");
string text = "The quick brown fox jumps over the lazy dog";

if (text.Contains("fox"))
{
    Console.WriteLine("The string contains 'fox'.");
}