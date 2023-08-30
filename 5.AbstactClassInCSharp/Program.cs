using _5.AbstactClassInCSharp;

namespace DotnetProgrammingInCSharp
{
    
    class Program
    {
        public static void Calculate(Shape S)
        {

            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());
        }

        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            R.GetLB();
            Calculate(R);

            Console.WriteLine();

            Circle C = new Circle();
            C.GetRadius();
            Calculate(C);
            Console.ReadLine();
        }
    }

}