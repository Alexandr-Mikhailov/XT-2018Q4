using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04.NumberArraySum
{
    public static class Program
    {
        private const int N = 8;

        public static byte Sum(this byte[] param)
        {
            byte sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static sbyte Sum(this sbyte[] param)
        {
            sbyte sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static short Sum(this short[] param)
        {
            short sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static ushort Sum(this ushort[] param)
        {
            ushort sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static int Sum(this int[] param)
        {
            int sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static uint Sum(this uint[] param)
        {
            uint sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static long Sum(this long[] param)
        {
            long sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static ulong Sum(this ulong[] param)
        {
            ulong sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static float Sum(this float[] param)
        {
            float sum = 0.0f;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static double Sum(this double[] param)
        {
            double sum = 0.0f;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static decimal Sum(this decimal[] param)
        {
            decimal sum = 0;
            for (int i = 0; i < param.Length; i++)
            {
                sum += param[i];
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            int[] array1 = new int[N];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i;
            }

            Console.WriteLine(array1.Sum());

            float[] array2 = new float[N];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = (float)i + 1.5f;
            }

            Console.WriteLine(array2.Sum());
        }
    }
}
