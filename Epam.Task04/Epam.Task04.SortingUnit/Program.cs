using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.SortingUnit
{
    public class Program
    {
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

            SortingUnit sort = new SortingUnit();

            SortingUnit.CompareType<int> CompareInt;

            sort.Sorting(int_array, CompareInt);


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
