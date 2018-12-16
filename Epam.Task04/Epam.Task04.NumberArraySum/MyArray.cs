using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.NumberArraySum
{
    public class MyArray
    {
        public MyArray(int n)
        {
            this.Arr = new double[n];
        }

        public double[] Arr { get; set; }

        public int Length
        {
            get
            {
                return this.Arr.Length;
            }
        }

        public double this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new Exception("index can not be negative");
                }
                else
                {
                    if (index > this.Arr.Length - 1)
                    {
                        throw new Exception("ArgumentOutOfRangeException");
                    }
                    else
                    {
                        return this.Arr[index];
                    }
                }
            }

            set
            {
                if (index < 0)
                {
                    throw new Exception("index can not be negative");
                }
                else
                {
                    if (index > this.Arr.Length - 1)
                    {
                        throw new Exception("ArgumentOutOfRangeException");
                    }
                    else
                    {
                        this.Arr[index] = value;
                    }
                }
            }
        }

        public double Sum()
        {
            double sum = 0;

            for (int i = 0; i < this.Arr.Length; i++)
            {
                sum = sum + this.Arr[i];
            }

            return sum;
        }
    }
}
