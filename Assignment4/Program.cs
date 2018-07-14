using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            speek(207, 7);
        }

        static void speek(int number, int increment)
        {
            int index = 0;
            for (; index <= number; index += increment)

            {
                if (index + increment <= number)
                {
                    System.Console.Write(index + ", ");
                }
                else
                {
                    System.Console.Write(index + "\r\n");
                }
            }
        }


    }
}
