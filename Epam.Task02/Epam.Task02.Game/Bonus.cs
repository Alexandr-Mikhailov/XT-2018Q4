using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public class Bonus : Obstacle
    {
        public Bonus(string type, int x, int y) : base(type, x, y)
        {
            this.Show = true;
            this.AddHealth = 1;
        }

        public bool Show { get; set; }

        public int AddHealth { get; set; }
    }
}
