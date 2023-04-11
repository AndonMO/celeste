using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celeste
{
    internal class Spikes
    {
        public int x, y, xSpeed, ySpeed;
        public int xSize = 20;
        public int ySize = 20;

        public Spikes(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
    }
}
