using System.IO;
using System;
using Newtonsoft.Json;
using ReadAndMapFromJsonInCSharp;

public class Program
{
    public static void Main()
    {
        string jsonDataStrFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "People.json");
        string jsonDataStr = File.ReadAllText(jsonDataStrFilePath);
        List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonDataStr);
        Console.WriteLine(jsonDataStr);
    }
}