using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_number;
            int number_of_lines;

            Console.WriteLine("Please input number of output lines");
            input_number = Console.ReadLine();

            if ((!(int.TryParse(input_number, out number_of_lines)) || number_of_lines <= 0))
            {
                Console.WriteLine("Incorrect input, please input positive integer number");
            }
            else
            {
                for (int i = 0; i < number_of_lines; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
