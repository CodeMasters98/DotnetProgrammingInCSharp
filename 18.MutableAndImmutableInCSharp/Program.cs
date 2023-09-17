// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string str = string.Empty;

for (int i = 0; i < 1000; i++)
{
    str += "Modified ";
}


StringBuilder strB = new StringBuilder();

for (int i = 0; i < 10000; i++)
{
    strB.Append("Modified ");
}

