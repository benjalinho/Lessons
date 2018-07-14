using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string newline = "\r\n";

            System.Console.Write("I found out how to code!\r\n");
            System.Console.Write(string.Concat("I found out how to code!", newline));
            System.Console.Write("I found out how to code!"+ newline);
            System.Console.WriteLine("I found out how to code!");
        }
    }
}
