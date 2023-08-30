namespace _5.AbstactClassInCSharp
{
    public abstract class Shape
    {
        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();
    }
}
