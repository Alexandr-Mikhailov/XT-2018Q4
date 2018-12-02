using System;
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
            double x, y, r;
            string input;

            Console.WriteLine("Input x coordinate of the round");
            input = Console.ReadLine();

            if (!(double.TryParse(input, out x)))
            {
                Console.WriteLine("Coordinate x mast be a number");
            }
            else
            {
                Console.WriteLine("Input y coordinate of the round");
                input = Console.ReadLine();

                if (!(double.TryParse(input, out y)))
                {
                    Console.WriteLine("Coordinate y mast be a number");
                }
                else
                {
                    Console.WriteLine("Input radius of the round");
                    input = Console.ReadLine();

                    if (!(double.TryParse(input, out r)))
                    {
                        Console.WriteLine("Radus mast be a number");
                    }
                    else
                    {
                        Round round = new Round();

                        try
                        {
                            round.NewRound(x, y, r);
                            Console.WriteLine(round.GetCircleLength());
                            Console.WriteLine(round.GetArea());
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
