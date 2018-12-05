using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.VectorGraphicsEditor
{
    public class Line : Figure
    {
        public Line(double x, double y, double xend, double yend) : base(x, y)
        {
            this.Xend = xend;
            this.Yend = yend;
        }

        public double Xend { get; set; }

        public double Yend { get; set; }

        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow(this.Xend - this.X, 2) + Math.Pow(this.Yend - this.Y, 2));
            return length;
        }

        public override void Draw()
        {
            Console.WriteLine($"This is Line with coordinates x0={this.X} y0={this.Y} x1={this.Xend} y1={this.Yend} " +
                $"and lenth of line is {this.GetLength()}");
            Console.WriteLine();
        }
    }
}
