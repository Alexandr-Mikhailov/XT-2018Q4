using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public class Monster : Movable
    {
        public Monster(string type, int x, int y) : base(type, x, y)
        {
            this.AddHealth = -1;
        }

        public int AddHealth { get; set; }

        public override void Move()
        {
            Random r = new Random();
            this.X += r.Next(-1, 1);
            this.Y += r.Next(-1, 1);
            if (this.X < 0)
            {
                this.X = 0;
            }

            if (this.Y < 0)
            {
                this.Y = 0;
            }
        }
    }
}
