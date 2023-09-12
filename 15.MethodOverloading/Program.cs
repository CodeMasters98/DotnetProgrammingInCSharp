namespace DotnetProgrammingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);
        }

        // adding two integer values.
        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public static int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }

}