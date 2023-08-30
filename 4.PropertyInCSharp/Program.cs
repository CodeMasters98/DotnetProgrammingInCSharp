using _4.PropertyInCSharp;

//Read and write property
Student student = new Student();
student.FirstName = "Parham";
student.LastName = "Darvishi";
student.Score = 90;

//Readonly Properties
Console.WriteLine(student.ScoreDescription);
Console.WriteLine("**************************");

Console.WriteLine("Number of Objects: {0}", Counter.NumberofObjects);
Counter object1 = new Counter();
Console.WriteLine("Number of Objects: {0}", Counter.NumberofObjects);
Counter object2 = new Counter();
Console.WriteLine("Number of Objects: {0}", Counter.NumberofObjects);