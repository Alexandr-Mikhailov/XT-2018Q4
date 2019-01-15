using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task07.HTML_replacer
{
    public class Program
    {
        public const string SYMBOL = "_";

        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            string input;
            string regString = @"<.*?>";

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

                if (match.Count == 0)
                {
                    Console.WriteLine("Text is not contains HTML tags");
                }
                else
                {
                    string temp = input;

                    foreach (var item in match)
                    {
                        temp = temp.Replace(item.ToString(), SYMBOL);
                    }

                    Console.WriteLine(temp);
                }
            }
            while (true);
        }
    }
}
