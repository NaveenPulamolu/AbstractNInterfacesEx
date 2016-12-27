using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNInterfaceDemo
{
    class Class1 : Class2, Isample
    {
        public void Print()
        {
            Console.WriteLine("This method does the printing process");
        }

        public void Fax()
        {
            Console.WriteLine("This method does the faxing process");
        }
        public override void hi()
        {
            Console.WriteLine("I am a abstract class");
        }
}
}
