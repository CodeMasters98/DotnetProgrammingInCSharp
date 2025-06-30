namespace DelegateInCSharp
{
    //Step 1
    public delegate void MyDelegate(string msg); //declaring a delegate

    public class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello World");
        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }
}