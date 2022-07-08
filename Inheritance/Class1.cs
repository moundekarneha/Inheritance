using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1
    {
        //parameter constructor
        public Class1(int i)
        {
            Console.WriteLine("constructor = of class 1 - parent with value = "+i);
        }
        public void Test1()
        {
            Console.WriteLine("Test 1 = of class 1 - parent");
        }
    }
}
