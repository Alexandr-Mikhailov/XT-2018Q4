using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public class Obstacle
    {
        public Obstacle(string type, int x, int y)
        {
            this.Type = type;
            this.X = x;
            this.Y = y;
        }

        public string Type { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
