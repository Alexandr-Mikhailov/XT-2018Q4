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

            for (int i = 0; i < 10; i++)
            {
                arr.Add(i);
            }

            arr.Arr[1] = 4;
            arr[2] = 1;

            int s = arr[1];

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            bool a = arr.Remove(9);
            a = arr.Remove(3);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
