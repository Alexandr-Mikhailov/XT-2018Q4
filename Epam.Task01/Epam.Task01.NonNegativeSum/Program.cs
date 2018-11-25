using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxindex = 20;
            int maxvalue = 100;
            int[] arraytosum = new int[maxindex];
            Random init = new Random();

            for (int i = 0; i < arraytosum.Length; i++)
            {
                arraytosum[i] = init.Next(maxvalue) - maxvalue/2;
            }

            Console.WriteLine("Array to Sum");

            foreach (int i in arraytosum)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sum of non-negative elements is {0}", NonNegativeSum(arraytosum));
        }
        public static int NonNegativeSum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
