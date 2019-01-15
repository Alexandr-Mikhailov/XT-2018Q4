using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task07.Time_counter
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
            string regString = @"\b(([0-1]?[0-9]|[2][0-3]):([0-5][0-9]))\b";

            do
            {
                Console.WriteLine("Input text to analyze or q to exit");
                input = Console.ReadLine();

                if (input == "q" || input == "Q")
                {
                    break;
                }

                var regex = new Regex(regString);

                var match = regex.Matches(input);

                Console.WriteLine($"The text contains dates {match.Count} time(s)");
            }
            while (true);
        }
    }
}
