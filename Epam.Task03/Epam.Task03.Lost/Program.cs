using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03.Lost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int N = 10;

            ArrayList human = new ArrayList();

            for (int i = 1; i <= N; i++)
            {
                human.Add($"human {i}");
            }

            Display(human);

            RemoveEverySecond(human);

            Console.Write("Last person in list is ");
            Display(human);
        }

        public static void RemoveEverySecond(ArrayList data)
        {
            int count = 1;
            for (int i = 0; i < data.Count; i++)
            {
                if (count % 2 == 0)
                {
                    data.RemoveAt(i);
                    i--;
                }

                count++;
                if (i == data.Count - 1)
                {
                    i = -1;
                }

                if (data.Count == 1)
                {
                    break;
                }
            }
        }

        public static void Display(ArrayList data)
        {
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
