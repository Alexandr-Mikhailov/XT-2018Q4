﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Round
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Input x coordinate of the circle");
            input = Console.ReadLine();

            if (!double.TryParse(input, out double x))
            {
                Console.WriteLine("Coordinate x mast be a number");
            }
            else
            {
                Console.WriteLine("Input y coordinate of the circle");
                input = Console.ReadLine();

                if (!double.TryParse(input, out double y))
                {
                    Console.WriteLine("Coordinate y mast be a number");
                }
                else
                {
                    Console.WriteLine("Input radius of the circle");
                    input = Console.ReadLine();

                    if (!double.TryParse(input, out double r))
                    {
                        Console.WriteLine("Radus mast be a number");
                    }
                    else
                    {
                        Round round = new Round();

                        try
                        {
                            round.NewRound(x, y, r);
                            Console.WriteLine("Length of circumference is {0}", round.GetCircleLength());
                            Console.WriteLine("Area of the circle is {0}", round.GetArea());
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
