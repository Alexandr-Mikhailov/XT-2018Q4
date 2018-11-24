using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.X_masTree
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
                XmasTree(number_of_lines);
            }
        }
        public static void XmasTree(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < (2 * N - 1); k++)
                    {
                        if ((k >= (N - 1 - j)) && (k <= (N - 1 + j)))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
