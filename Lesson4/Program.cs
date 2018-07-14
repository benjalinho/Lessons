using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        public static string DefaultName = String.Empty;

        static void Main(string[] args)
        {
            string name = "Benjamin";
            System.Console.WriteLine(name);

            string[] tenNames = new string[10];
            tenNames[0] = "Benjamin";
            tenNames[1] = "Brian";
            tenNames[2] = "Emily";
            tenNames[3] = "Margaret";
            for (int index = 0; index < tenNames.Length; index++)
            {
                string outputString = "tenNames[";
                outputString += index;
                outputString += "]:";
                outputString += tenNames[index];
                System.Console.WriteLine(outputString);
                System.Console.WriteLine($"tenNames[{index}]:{tenNames[index]}");
            }


            string[] names = { "Benjamin", "Brian", "Emily", "Margaret" };
            for (int index = 0; index < names.Length; index++)
            {
                System.Console.WriteLine($"names[{index}]:{names[index]}");
            }

            string defaultName = Program.DefaultName;

            List<string> people = new List<string>();
            people.Add("Benjamin");
            people.Add("Brian");
            people.Add("Emily");
            people.Add("Margaret");

            for (int index = 0; index < people.Count; index++)
            {
                System.Console.WriteLine($"people[{index}]:{people[index]}");
            }

            people.Add("Star Wars: A New Hope");


            foreach(string person in people)
            {
                System.Console.WriteLine($"person:{person}");
            }

            foreach(string currentName in tenNames)
            {
                //if (!string.IsNullOrEmpty(currentName))
                if(!string.IsNullOrEmpty(currentName) && !currentName.StartsWith("B"))
                {
                    System.Console.WriteLine($"currentName:{currentName}");
                }
            }
        }
    }
}
