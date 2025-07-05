namespace _25_1.FuncInCSharp
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //Sample 1
            Func<int, string> convertToString = number => "Value is " + number;
            string result = convertToString(5);

            //Sample 2
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
        }
    }
}
