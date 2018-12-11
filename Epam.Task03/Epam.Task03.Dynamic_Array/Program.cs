using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03.Dynamic_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>(3);
            DynamicArray<string> arr_string = new DynamicArray<string>(3);

            for (int i = 0; i < 7; i++)
            {
                arr_string.Add($"string{i}");
            }

            for (int i = 0; i < 10; i++)
            {
                arr.Add(i);
            }

            arr.Arr[1] = 4;
            arr[2] = 1;

            int s = arr[1];

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            bool a = arr.Remove(3);
            a = arr_string.Remove("string4");
            
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            foreach (var item in arr_string)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            a = arr_string.Insert(2, "string_");

            foreach (var item in arr_string)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
