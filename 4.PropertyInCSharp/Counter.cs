namespace _4.PropertyInCSharp
{
    public class Counter
    {
        private static int number = 0;
        public Counter()
        {
            number++;
        }

        public static int NumberofObjects
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}
