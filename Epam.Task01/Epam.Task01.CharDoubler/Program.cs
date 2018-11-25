using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstring;
            string stringdoubler;
            
            Console.Write("Please input first string to analyze: ");
            inputstring = Console.ReadLine();
            
            Console.Write("Please input second string to analyze: ");
            stringdoubler = Console.ReadLine();
            
            Console.WriteLine("Final string is: {0}", StringCharDoubler(inputstring, stringdoubler));
        }
        public static string StringCharDoubler(string inputstr, string doublestr)
        {
            StringBuilder temp = new StringBuilder("");
            for (int i = 0; i < inputstr.Length; i++)
            {
                temp.Append(inputstr[i]);
                for (int j = 0; j < doublestr.Length; j++)
                {
                    if (inputstr[i] == doublestr[j])
                    {
                        temp.Append(inputstr[i]);
                        break;
                    }
                }
            }
            return temp.ToString();
        }
    }
}
