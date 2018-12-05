using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.VectorGraphicsEditor
{
    public class Ring : Figure
    {
        public Ring(double x, double y, double outer, double inner) : base(x, y)
        {
            if ((inner < 0) || (outer < 0))
            {
                throw new Exception("Radius cannot be less then zero");
            }
            else
            {
                if (inner > outer)
                {
                    throw new Exception("Outer radius cannot be less then inner");
                }
                else
                {
                    this.Inner = inner;
                    this.Outer = outer;
                }
            }
        }

        public double Inner { get; set; }

        public double Outer { get; set; }

        public double GetArea()
        {
            double area = Math.PI * (Math.Pow(this.Outer, 2) - Math.Pow(this.Inner, 2));
            return area;
        }

        public override void Draw()
        {
            Console.WriteLine($"This is Ring with coordinates x0={this.X} y0={this.Y} " +
              $"and outer radius is {this.Outer} and inner radius is {this.Inner}, it's area is {this.GetArea()}");
            Console.WriteLine();
        }
    }
}
