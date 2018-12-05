using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02.Game
{
    public class Field
    {
        public Field(int width, int height)
        {
            if ((width <= 0) || (height <= 0))
            {
                throw new Exception("Width or Heght must be positive");
            }
            else
            {
                this.Width = width;
                this.Heght = height;
            }
        }

        public int Width { get; set; }

        public int Heght { get; set; }
    }
}
