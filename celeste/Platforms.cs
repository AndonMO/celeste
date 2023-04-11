using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celeste
{
    internal class Platforms
    {
        public int x, y;
        public int width = 75;
        public int height = 75;

        public Platforms(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
        }
    }

   
}
