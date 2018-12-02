using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Round
{
    public class Round
    {
        private double Center_x { get; set; }

        private double Center_y { get; set; }

        private double Radius { get; set; }

        public void NewRound(double x, double y, double radius)
        {
            this.Center_x = x;
            this.Center_y = y;

            if (radius >= 0)
            {
                this.Radius = radius;
            }
            else
            {
                throw new Exception("Radius can not be negative");
            }
        }

        public double GetCircleLength()
        {
            return 2 * Math.PI * this.Radius;
        }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
