using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Input first side of the triangle");
            input = Console.ReadLine();

            if (!double.TryParse(input, out double x))
            {
                Console.WriteLine("Side mast be a number");
            }
            else
            {
                Console.WriteLine("Input second side of the triangle");
                input = Console.ReadLine();

                if (!double.TryParse(input, out double y))
                {
                    Console.WriteLine("Side mast be a number");
                }
                else
                {
                    Console.WriteLine("Input third side of the triangle");
                    input = Console.ReadLine();

                    if (!double.TryParse(input, out double z))
                    {
                        Console.WriteLine("Side mast be a number");
                    }
                    else
                    {
                        Triangle triangle = new Triangle();

                        try
                        {
                            triangle.NewTriangle(x, y, z);
                            Console.WriteLine("Triangle perimeter is {0}",triangle.GetPerimeter());
                            Console.WriteLine("Triangle area is {0}", triangle.GetArea());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }
                }
            }
        }
    }
}
