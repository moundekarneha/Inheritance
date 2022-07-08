 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        public void ProgData()
        {
            Console.WriteLine("Hey this is a program class method");
        }
        static void Main(string[] args)
        {
           
            Class2 c2 = new Class2(10);
            Object obj = new Object();
            Console.WriteLine("Get type = "+ obj.GetType());
            //Class1 cobj = new Class1();
            //Console.WriteLine("Get type = " + cobj.GetType());
           // cobj.Test1();
            Class1 p;
            p = new Class2(20);
            Class1 c1; 
            c1 = c2;
            p.Test1();
            c2.Test1(); //class1 method -parent
            c2.Test2(); //class2 method -child

            Console.ReadLine();
        }
    }
}
