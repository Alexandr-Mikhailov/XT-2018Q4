using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int index1d = 4;
            int index2d = 3;
            int maxvalue = 20;
            int[,] array2d = new int[index1d, index2d];
            Random init = new Random();

            for (int i = 0; i < index1d; i++)
            {
                for (int j = 0; j < index2d; j++)
                {
                    array2d[i, j] = init.Next(maxvalue);
                }
            }

            for (int i = 0; i < index1d; i++)
            {
                for (int j = 0; j < index2d; j++)
                {
                    Console.Write("{0} ", array2d[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum of the elements on the even positions is {0}", SumOfEvenPositions(array2d));

        }
        public static int SumOfEvenPositions(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (((i + j) % 2 == 0) && (!((i == j) && (i == 0))))
                    {
                        sum += arr[i, j];
                    }

                }
            }
            return sum;
        }
    }
}
