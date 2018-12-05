using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.VectorGraphicsEditor
{
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y, double xend, double yend) : base(x, y)
        {
            this.Xend = xend;
            this.Yend = yend;
        }

        public double Xend { get; set; }

        public double Yend { get; set; }

        public double GetsideA()
        {
            double length;

            if (this.Xend >= this.X)
            {
                length = this.Xend - this.X;
            }
            else
            {
                length = this.X - this.Xend;
            }

            return length;
        }

        public double GetsideB()
        {
            double length;

            if (this.Yend >= this.Y)
            {
                length = this.Yend - this.Y;
            }
            else
            {
                length = this.Y - this.Yend;
            }

            return length;
        }

        public double GetArea()
        {
            double area = this.GetsideA() * this.GetsideB();
            return area;
        }

        public override void Draw()
        {
            Console.WriteLine($"This is Rectangle with coordinates x0={this.X} y0={this.Y} x1={this.Xend} y1={this.Yend} " +
                $", with sides {this.GetsideA()} and {this.GetsideB()}, it's area is {this.GetArea()}");
            Console.WriteLine();
        }
    }
}
