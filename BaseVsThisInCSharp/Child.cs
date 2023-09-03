using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVsThisInCSharp
{
    public class Child : Parent
    {
        public Child(int x, int y) : base(x)
        {
            // Constructor logic in the derived class
        }
    }
}
