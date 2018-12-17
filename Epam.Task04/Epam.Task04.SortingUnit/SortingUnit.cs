using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.SortingUnit
{
    public delegate int CompareType<T>(T first, T second);

    public class SortingUnit
    {
        public event EventHandler SortingFinished;

        public void Sorting<T>(T[] arr, CompareType<T> compare)
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

            this.SortingFinished(this, EventArgs.Empty);
        }

        public int CompareInt(int a, int b)
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

        public int CompareDouble(double a, double b)
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

        public int CompareChar(char a, char b)
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

        public int CompareStringLength(string a, string b)
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
    }
}
