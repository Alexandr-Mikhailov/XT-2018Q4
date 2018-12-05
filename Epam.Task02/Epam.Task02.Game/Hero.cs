using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public class Hero : Movable
    {
        public Hero(string type, int x, int y) : base(type, x, y)
        {
            this.Step = 0;
            this.Health = 1;
        }

        public int Health { get; set; }

        public int Step { get; set; }

        public override void Move()
        {
            switch (this.Step)
            {
                case 1:
                    this.X++;
                    break;
                case 2:
                    this.X--;
                    break;
                case 3:
                    this.Y++;
                    break;
                case 4:
                    this.Y--;
                    break;
                default: break;
            }

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
