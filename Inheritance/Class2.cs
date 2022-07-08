using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class2 : Class1
    {
        public Class2(int a):base(a)
        {
            Console.WriteLine("constructor = of class 2 - child");
        }
        public void Test2()
        {
            Console.WriteLine("Test 2 = of class 2 - child");
        }
    }
}
