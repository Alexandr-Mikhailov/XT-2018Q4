using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int thousand = 1000;
            int Sum_3_5 = 0;
            for (int i = 3; i < thousand; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    Sum_3_5 += i;
                }
            }
            Console.WriteLine("Sum of numbers is {0}", Sum_3_5);
        }
    }
}
