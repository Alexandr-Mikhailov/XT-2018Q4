using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstring;
            Console.WriteLine("Please input string to analyze");
            inputstring = Console.ReadLine();
            //inputstring = "Написать программу, которая определяет среднюю длину слова во введённой текстовой строке.";

            Console.WriteLine("Average string length is {0}", AvgStrLength(inputstring));
        }
        public static double AvgStrLength(string str)
        {
            double strlength = 0.0;
            int countstrings = 0;
            int countsletters = 0;
            int countlettersofword = 0;
            string tempstr;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < words.Length; i++)
            {
                tempstr = words[i];
                countlettersofword = 0;
                for (int j = 0; j < tempstr.Length; j++)
                {
                    if (Char.IsLetter(tempstr[j]))
                    {
                        countsletters++;
                        countlettersofword++;
                    }
                }
                if (!(countlettersofword == 0))
                {
                    countstrings++;
                }
            }
            if (!(countstrings == 0))
            {
                strlength = (double)countsletters / (double)countstrings;
            }
            return strlength;
        }
    }
}
