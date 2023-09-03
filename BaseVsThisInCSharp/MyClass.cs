namespace BaseVsThisInCSharp
{
    public class MyClass
    {
        private int value;

        public MyClass(int x)
        {
            this.value = x; // Using 'this' to access the current instance's members
        }

        public MyClass() : this(0) // Calling another constructor in the same class using 'this'
        {
            // Constructor logic
        }
    }
}
