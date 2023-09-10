// See https://aka.ms/new-console-template for more information

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