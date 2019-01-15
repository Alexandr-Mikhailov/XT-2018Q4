using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task07.Number_validator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            string input;
            string regNormalNotation = @"^(-?[0-9]+(\.[0-9]+)?)$";
            string regScienceNotation = @"^(((-?[0-9]{1}(\.[0-9]+))|(-?[0-9]+))[Ee]-?[0-9]+)$";

            do
            {
                Console.WriteLine("Input number to analyze or q to exit");
                input = Console.ReadLine();

                if (input == "q" || input == "Q")
                {
                    break;
                }

                var regexNormal = new Regex(regNormalNotation);
                var regexScience = new Regex(regScienceNotation);

                var matchNormal = regexNormal.Match(input);
                var matchScience = regexScience.Match(input);

                if (matchNormal.Success)
                {
                    Console.WriteLine($"The number \"{input}\" is in normal notation");
                }
                else
                {
                    if (matchScience.Success)
                    {
                        Console.WriteLine($"The number \"{input}\" is in science notation");
                    }
                    else
                    {
                        Console.WriteLine($"The \"{input}\" is not a number");
                    }
                }
            }
            while (true);
        }
    }
}
