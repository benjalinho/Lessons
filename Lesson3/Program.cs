using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            CountOutLoud(207, 14);
        }

        static void CountOutLoud(int number, int increment)
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
