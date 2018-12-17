using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.CustomSortDemo
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
            string[] array_string = new string[]
            {
                "str4", "str", "str2", "str10", "st", "str1", "Str"
            };

            Console.WriteLine("Unsorted string array");

            Display(array_string);

            Console.WriteLine("Sorted string array");

            Sorting(array_string, CompareStringLength);

            Display(array_string);
        }

        public static int CompareStringLength(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return 1;
            }
            else
            {
                if (a.Length < b.Length)
                {
                    return -1;
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if ((int)char.ToLower(a[i]) > (int)char.ToLower(b[i]))
                        {
                            return 1;
                        }

                        if ((int)char.ToLower(a[i]) < (int)char.ToLower(b[i]))
                        {
                            return -1;
                        }
                    }

                    return 0;
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
