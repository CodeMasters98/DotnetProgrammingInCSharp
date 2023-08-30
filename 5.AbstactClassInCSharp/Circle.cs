namespace _5.AbstactClassInCSharp
{
    public class Circle:Shape
    {
        public void GetRadius()
        {

            Console.Write("Enter  Radius  :  ");
            R = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return 3.14F * R * R;
        }
        public override float Circumference()
        {
            return 2 * 3.14F * R;
        }
    }
}
