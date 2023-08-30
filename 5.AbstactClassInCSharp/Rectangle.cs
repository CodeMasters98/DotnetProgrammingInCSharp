namespace _5.AbstactClassInCSharp
{
    public class Rectangle: Shape
    {
        public void GetLB()
        {
            Console.Write("Enter  Length  :  ");

            L = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth : ");

            B = float.Parse(Console.ReadLine());
        }


        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * (L + B);
        }
    }
}
