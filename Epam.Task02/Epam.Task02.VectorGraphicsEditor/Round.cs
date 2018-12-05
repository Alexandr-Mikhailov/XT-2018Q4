using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.VectorGraphicsEditor
{
    public class Round : Circle
    {
        public Round(double x, double y, double radius) : base(x, y, radius)
        {
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(this.Radius, 2);
            return area;
        }

        public override void Draw()
        {
            Console.WriteLine($"This is Round with coordinates x0={this.X} y0={this.Y} " +
               $"and length of circumference is {this.GetLengthOfCircumference()}, it's area is {this.GetArea()}");
            Console.WriteLine();
        }
    }
}
