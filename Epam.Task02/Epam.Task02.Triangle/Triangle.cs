using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Triangle
{
    public class Triangle
    {
        private double Side_a { get; set; }

        private double Side_b { get; set; }

        private double Side_c { get; set; }

        public void NewTriangle(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new Exception("Sides can not be negative");
            }
            else
            {
                if ((a > (b + c)) || (b > (a + c)) || (c > (a + b)))
                {
                    throw new Exception($"The triangle with sides {a} , {b} and {c} is impossible");
                }
                else
                {
                    this.Side_a = a;
                    this.Side_b = b;
                    this.Side_c = c;
                }
            }
        }

        public double GetPerimeter()
        {
            return this.Side_a + this.Side_b + this.Side_c;
        }

        public double GetArea()
        {
            return Math.Sqrt(this.GetPerimeter()
                * (this.GetPerimeter() - 2 * this.Side_a)
                * (this.GetPerimeter() - 2 * this.Side_b)
                * (this.GetPerimeter() - 2 * this.Side_c)) / 4;
        }
    }
}
