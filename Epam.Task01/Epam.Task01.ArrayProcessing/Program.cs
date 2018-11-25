using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxindex = 20;
            int maxvalue = 100;
            int[] arraytoprocess = new int[maxindex];
            Random init = new Random();

            for (int i = 0; i < arraytoprocess.Length; i++)
            {
                arraytoprocess[i] = init.Next(maxvalue);
            }

            Console.WriteLine("Unsorted array");
            
            foreach (int i in arraytoprocess)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            ArraySort(arraytoprocess, 0, arraytoprocess.Length - 1);

            Console.WriteLine("Sorted array");

            foreach (int i in arraytoprocess)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Minimum element of array is {0}", arraytoprocess[0]);
            Console.WriteLine("Maximum element of array is {0}", arraytoprocess[arraytoprocess.Length-1]);
        }
        public static void ArraySort(int[] arr, int left, int right)
        {
            int i = left;
            int j = right;
            int x = arr[(left + right) / 2];
            do
            {
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                if (i <= j)
                {
                    int y = arr[i];
                    arr[i] = arr[j];
                    arr[j] = y;
                    i++;
                    j--;
                }
            }
            while (i < j);
            if (left < j)
                ArraySort(arr, left, j);
            if (left < right)
                ArraySort(arr, i, right);
        }
    }
}
