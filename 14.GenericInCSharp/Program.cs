// See https://aka.ms/new-console-template for more information

List<int> ints = new List<int> { 1, 2, 3 };
List<long> longs = new List<long> { 1, 2, 3 };

MyLoop(ints);
MyLoop(longs);

static void MyLoop<T>(List<T> numbers)
{
    //Loop
    //For, while, do while
    foreach (var item in numbers)
    {
        Console.WriteLine($"{item}");
    }
    //for (int i = 0; i < numbers.Count; i++)
    //{
    //    Console.WriteLine($"{i}");
    //}
}






















int[] intArray = { 1, 2, 3 };
double[] doubleArray = { 1.0, 2.0, 3.0 };
string[] stringArray = { "1",  "2", "3" };

DisplayElements(intArray);
DisplayElements(doubleArray);
DisplayElements(stringArray);

static void DisplayElements<T>(T[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}