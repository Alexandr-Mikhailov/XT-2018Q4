using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.NumberArraySum
{
    public class Program
    {
        private const int N = 8;

        public static void Main(string[] args)
        {
            MyArray array = new MyArray(N);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine(array.Sum());
        }
    }
}
