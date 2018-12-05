using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Ring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double r1, r2;
            string input;

            do
            {
                Console.WriteLine("Input outer radius of the ring");
                input = Console.ReadLine();
                if (!double.TryParse(input, out r1))
                {
                    Console.WriteLine("Outer radius must be a number");
                }
                else
                {
                    break;
                }
            }
            while (true);

            do
            {
                Console.WriteLine("Input inner radius of the ring");
                input = Console.ReadLine();
                if (!double.TryParse(input, out r2))
                {
                    Console.WriteLine("Inner radius must be a number");
                }
                else
                {
                    break;
                }
            }
            while (true);

            try
            {
                Ring ring = new Ring(r1, r2);
                Console.WriteLine("The ring with outer radis {0} and inner radius {1} has area {2}", ring.GetOuterRadius(), ring.GetInnerRadius(), ring.GetArea());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
