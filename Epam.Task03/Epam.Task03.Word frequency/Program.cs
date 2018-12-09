using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03.Word_frequency
{
    public class Program
    {
        public const char Space = ' ';
        public const char Dot = '.';

        public static void Main(string[] args)
        {
            string input, input_text;

            Console.WriteLine("Input english text");
            input = Console.ReadLine();
            input_text = RemovePunctuation(input);

            string[] words = input_text.Split(new char[] { Space, Dot }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, int>();

            foreach (var text in words)
            {
                if (dictionary.ContainsKey(text.ToLower()))
                {
                    dictionary[text.ToLower()] += 1;
                }
                else
                {
                    dictionary.Add(text.ToLower(), 1);
                }
            }

            Console.WriteLine("Text contains words :");

            foreach (var i in dictionary)
            {
                Console.WriteLine($"word {i.Key} {i.Value} time(s)");
            }
        }

        public static string RemovePunctuation(string text)
        {
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetterOrDigit(text[i]) && ((text[i] != Space) || (text[i] != Dot)))
                {
                    temp.Append(Space);
                }
                else
                {
                    temp.Append(text[i]);
                }
            }

            return temp.ToString();
        }
    }
}
