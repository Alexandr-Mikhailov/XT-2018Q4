using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Ring
{
    public class Ring
    {
        public Ring(double outer, double inner)
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

        private double Inner { get; set; }

        private double Outer { get; set; }

        public double GetArea()
        {
            double area = Math.PI * ((this.Outer * this.Outer) - (this.Inner * this.Inner));
            return area;
        }

        public double GetInnerRadius()
        {
            return this.Inner;
        }

        public double GetOuterRadius()
        {
            return this.Outer;
        }
    }
}
