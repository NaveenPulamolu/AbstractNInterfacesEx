using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Print();
            obj.Fax();
            obj.hi();
            Console.ReadLine();

        }
    }
}
