// See https://aka.ms/new-console-template for more information

using System.Configuration;

string connectionString = ConfigurationManager.ConnectionStrings["Test"].ToString();

Console.WriteLine(connectionString);
