using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int length = 100;
            int lineLength = 10;

            for(;index < length; index ++)
            {
                // string comma = ((index + 1) < 5) ? ", " : string.Empty;

                string comma = "Default Value";

                int remainder = ((index + 1) % lineLength);

                if (index + 1 < length && remainder != 0)
                {
                    comma = ", ";
                }
                else
                {
                    comma = "\r\n";
                }
                
                System.Console.Write(index.ToString("000") + comma);
            }
        }
    }
}
