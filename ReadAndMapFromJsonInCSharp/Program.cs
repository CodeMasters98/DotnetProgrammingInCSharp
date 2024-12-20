﻿using Newtonsoft.Json;
using ReadAndMapFromJsonInCSharp;

public class Program
{
    public static void Main()
    {
        //read from file
        string jsonDataStrFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "People.json");
        string jsonDataStr = File.ReadAllText(jsonDataStrFilePath);
        List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonDataStr);
        Console.WriteLine(jsonDataStr);
    }
}