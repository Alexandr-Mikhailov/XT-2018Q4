using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task1.CheckSimplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int N;
            Console.WriteLine("Введите целое положительное число");
            n = Console.ReadLine();
            if (!Int32.TryParse(n, out N) || (N <= 0))
                Console.WriteLine("Некорректный ввод");
            else
                Console.WriteLine(IsSimple(N)? "Число простое" : "Число не является простым");
        }
        static Boolean IsSimple(int N)
        {
            if (N == 1)
                return false;
            int sqr_N = (int)Math.Sqrt(N);
            for (int i = 2; i <= sqr_N; i++)
                if (N % i == 0)
                    return false;
            return true;
        }
    }
}
