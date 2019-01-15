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
                input = @"<b>Это</b> текст <i>с</i> <font >HTML</font> кодами";
                if (input == "q" || input == "Q")
                {
                    break;
                }

                var regex = new Regex(regString);

                var match = regex.Matches(input);

                //if (match.Success)
                //{
                //    Console.WriteLine($"The text \"{input}\" contains date");
                //}
                //else
                //{
                //    Console.WriteLine($"The text \"{input}\" is not contains date");
                //}
            }
            while (true);
        }
    }
}
