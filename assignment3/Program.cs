using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int number = 150;
            int increment = 13;
            for (; index <= number; index += increment)
                
            {
                if (index+increment <= number) {
                    System.Console.Write(index+", ");
                }
                else
                {
                    System.Console.Write(index+"\r\n");
                }
            }
        }
    }
}
