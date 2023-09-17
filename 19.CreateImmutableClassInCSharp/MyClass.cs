namespace _19.CreateImmutableClassInCSharp
{
    class MyClass
    {
        private readonly string myStr;

        public MyClass(string str)
        {
            myStr = str;
        }

        public string GetStr
        {
            get { return myStr; }
        }
    }
}
