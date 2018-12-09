using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Epam.Task02.VectorGraphicsEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Figure line = new Line(0, 0, 3, 4);
            Figure circle = new Circle(0, 0, 1);
            Figure rect = new Rectangle(0, 0, 3, 4);
            Figure round = new Round(0, 0, 1);
            Figure ring = new Ring(0, 0, 2, 1);

            line.Draw();
            circle.Draw();
            rect.Draw();
            round.Draw();
            ring.Draw();
        }
    }
}
