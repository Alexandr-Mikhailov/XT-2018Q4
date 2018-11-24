using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Task01.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_input, second_input;
            float A_side, B_side;
            
            Console.WriteLine("Please input first side of rectangle");
            first_input = Console.ReadLine();
            Console.WriteLine("Please input second side of rectangle");
            second_input = Console.ReadLine();

            if ((!(float.TryParse(first_input, out A_side)) || A_side <= 0) || (!(float.TryParse(second_input, out B_side)) || B_side <= 0))
            {
                Console.WriteLine("Incorrect input, please input positive numbers");
            }
            else
            {
                Console.WriteLine("Rectangle area is {0}",Rectangle_Area(A_side, B_side));
            }
        }
        static float Rectangle_Area(float a,float b)
        {
            return a*b;
        }
    }
}
