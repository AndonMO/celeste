using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celeste
{
    internal class Player
    {
        public int x, y;
        public int xSpeed = 6;
        public int ySpeed = -15;
        public int width = 20;
        public int height = 20;

        public Player(int _x, int _y, int _width, int _height, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;

        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= ySpeed;
            }
            if (direction == "down")
            {
                y += ySpeed;
            }
            if (direction == "left")
            {
                x -= xSpeed;
            }
            if (direction == "right")
            {
                x += xSpeed;
            }
        }
    }
}
