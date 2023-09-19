using System.IO;
using System;
public class Program
{
    public static void Main()
    {
        // Store the path of the textfile in your system
        string file = @"D:\Parham\Projects\DotnetProgrammingInCSharp\22.ReadFromFileInCSharp\Files\Info.txt";

        Console.WriteLine("Reading File using File.ReadAllText()");

        // To read the entire file at once
        if (File.Exists(file))
        {
            // Read all the content in one string
            // and display the string
            string str = File.ReadAllText(file);
            Console.WriteLine(str);
        }
        Console.WriteLine();

        Console.WriteLine("Reading File using File.ReadAllLines()");

        // To read a text file line by line
        if (File.Exists(file))
        {
            // Store each line in array of strings
            string[] lines = File.ReadAllLines(file);

            foreach (string ln in lines)
                Console.WriteLine(ln);
        }
        Console.WriteLine();

        Console.WriteLine("Reading File using StreamReader");

        // By using StreamReader
        if (File.Exists(file))
        {
            // Reads file line by line
            StreamReader Textfile = new StreamReader(file);
            string line;

            while ((line = Textfile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            Textfile.Close();

            Console.ReadKey();
        }
        Console.WriteLine();
    }
}