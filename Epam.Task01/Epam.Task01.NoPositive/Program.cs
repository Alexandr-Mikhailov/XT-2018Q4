using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int index1d = 4;
            int index2d = 3;
            int index3d = 2;
            int maxvalue = 100;
            int[, ,] array3d = new int[index1d, index2d, index3d];
            Random init = new Random();

            for (int i = 0; i < index1d; i++)
            {
                for (int j = 0; j < index2d; j++)
                {
                    for (int k = 0; k < index3d; k++)
                    {
                        array3d[i, j, k] = init.Next(maxvalue) - maxvalue / 2;
                    }
                }
            }

            foreach (int i in array3d)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            NoPositive(array3d);

            foreach (int i in array3d)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void NoPositive(int[, ,] arr)
        {
            int firstdimension = arr.GetUpperBound(0);
            int seconddimension = arr.GetUpperBound(1);
            int thirddimension = arr.GetUpperBound(2);

            for (int i = 0; i <= firstdimension; i++)
            {
                for (int j = 0; j <= seconddimension; j++)
                {
                    for (int k = 0; k <= thirddimension; k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
