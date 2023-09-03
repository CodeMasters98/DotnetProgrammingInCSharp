using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExterntionMethodInCSharp
{
    public static class SecondClass
    {
        // Method 4
        public static void M4(this FirstClass fc)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this FirstClass fc, string str)
        {
            Console.WriteLine(str);
        }
    }
}
