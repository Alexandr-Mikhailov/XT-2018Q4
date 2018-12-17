using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.CustomSort
{
    public class Program
    {
        public delegate int CompareType<T>(T first, T second);

        public static void Sorting<T>(T[] arr, CompareType<T> compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare(arr[j], arr[i]) < 0)
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] int_array = new int[]
            {
                1, -20, 3, 0, -5, 7, 2, -11, 0, 15
            };

            double[] double_array = new double[]
            {
                1.5, -20.0, 3.7, 0.5, -5.1, 7.9, 2.0, -11.24, 0.0, 15.8
            };

            char[] char_array = new char[4];
            char_array[0] = 'T';
            char_array[1] = 'f';
            char_array[2] = 'a';
            char_array[3] = 's';

            Console.WriteLine("Unsorted int array");

            Display(int_array);

            Console.WriteLine("Sorted int array");

            Sorting(int_array, CompareInt);

            Display(int_array);

            Console.WriteLine("Unsorted double array");

            Display(double_array);

            Console.WriteLine("Sorted double array");

            Sorting(double_array, CompareDouble);

            Display(double_array);

            Console.WriteLine("Unsorted char array");

            Display(char_array);

            Console.WriteLine("Sorted char array");

            Sorting(char_array, CompareChar);

            Display(char_array);
        }

        public static int CompareInt(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else
            {
                if (a == b)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static int CompareDouble(double a, double b)
        {
            if (a > b)
            {
                return 1;
            }
            else
            {
                if (a == b)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static int CompareChar(char a, char b)
        {
            if ((int)char.ToLower(a) > (int)char.ToLower(b))
            {
                return 1;
            }
            else
            {
                if ((int)char.ToLower(a) == (int)char.ToLower(b))
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static void Display<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
