using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task07.Email_finder
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
            string regString = @"\b([a-z1-9]([a-z1-9\._\-]*[a-z1-9])?@([a-z1-9_\-]+\.)+[a-z]{2,6})\b";

            do
            {
                Console.WriteLine("Input text to analyze or q to exit");
                input = Console.ReadLine();
                
                if (input == "q" || input == "Q")
                {
                    break;
                }

                var regex = new Regex(regString, RegexOptions.IgnoreCase);

                var match = regex.Matches(input);

                if (match.Count == 0)
                {
                    Console.WriteLine($"The input text is not contains Emails");
                }
                else
                {
                    Console.WriteLine("Email(s) found:");

                    foreach (var item in match)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            while (true);
        }
    }
}
