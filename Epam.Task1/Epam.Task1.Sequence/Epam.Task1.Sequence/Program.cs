using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int N;
            Console.WriteLine("Введите положительное число");
            n = Console.ReadLine();
            if (!Int32.TryParse(n, out N) || (N <= 0))
                Console.WriteLine("Некорректный ввод");
            else
                Sequence(N);
        }
        static void Sequence(int N)
        {
            if (N > 1)
            {
                Console.Write("1");
                for (int i = 2; i <= N; i++)
                    Console.Write(", {0}", i);
            }
            else Console.Write(N);
            Console.WriteLine();            
        }
    }
}
