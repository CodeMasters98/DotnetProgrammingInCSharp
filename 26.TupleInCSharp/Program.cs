namespace MultiTreadInCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            var author = TupleReturnLiteral(1000);
            Console.WriteLine($"Author {author.Item1} {author.Item2} {author.Item3} ");
        }

        // tuple return type
        public static (string, string, long) TupleReturnLiteral(long id)
        {
            string name = string.Empty;
            string title = string.Empty;
            long year = 0;
            if (id == 1000)
            {
                name = "Parham Darvishi";
                title = "ADO.NET Programming";
                year = 2018;
            }
            // tuple literal
            return (name, title, year);
        }

        public (string name, string title, long year) TupleReturnLiteralMoreReadable(long id)
        {
            string name = string.Empty;
            string title = string.Empty;
            long year = 0;
            if (id == 1000)
            {
                name = "Mahesh Chand";
                title = "ADO.NET Programming";
                year = 2003;
            }
            // tutle literal
            return (name, title, year);
        }

        public static Tuple<string, string, int> GetTupleMethod()
        {
            // Create a 3-tuple and return it
            var author = new Tuple<string,string, int>("Parham Darvishi", "Programming C#", 2013);
            return author;
        }
    }
}