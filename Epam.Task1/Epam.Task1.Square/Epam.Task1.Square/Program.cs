using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int N;
            Console.WriteLine("Введите целое нечетное положительное число");
            n = Console.ReadLine();
            if (!Int32.TryParse(n, out N) || (N <= 0) || (N % 2 == 0))
                Console.WriteLine("Некорректный ввод");
            else
                Square(N);
        }
        static void Square(int N)
        {
            int half_N = N / 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(((i == j) && (i == half_N))? " " : "*");
                Console.WriteLine();
            }
        }
    }
}
