using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.VectorGraphicsEditor
{
    public class Circle : Figure
    {
        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double GetLengthOfCircumference()
        {
            double length = 2 * Math.PI * this.Radius;
            return length;
        }

        public override void Draw()
        {
            Console.WriteLine($"This is Circle with coordinates x0={this.X} y0={this.Y} " +
               $"and length of circumference is {this.GetLengthOfCircumference()}");
            Console.WriteLine();
        }
    }
}
