using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task07.Date_existance
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
            string regString = @"((0[1-9]|[12]\d)|(0[13-9]|1[012])-30|(0[13578]|1[02])-31)-(0[1-9]|1[012])-[0-9]{4}";

            do
            {
                Console.WriteLine("Input text to analyze or q to exit");
                input = Console.ReadLine();

                if (input == "q" || input == "Q")
                {
                    break;
                }

                var regex = new Regex(regString);

                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine($"The text \"{input}\" contains date");
                }
                else
                {
                    Console.WriteLine($"The text \"{input}\" is not contains date");
                }
            }
            while (true);
        }
    }
}
