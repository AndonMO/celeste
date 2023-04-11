using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace celeste
{
    internal class Balls
    {
        public int ballX, ballY, ballSpeed;
        public int size = 5;

        public Balls(int _x, int _y, int _speed)
        {
            ballX = _x;
            ballY = _y;
            ballSpeed = _speed;
        }

        public void Move(int Width, int Height)
        {

            ballY += ballSpeed; 
        }

        public bool Collision(Player p)
        {
            Rectangle ballrec = new Rectangle(ballX, ballY, size, size);
            Rectangle herorec = new Rectangle(p.x, p.y, p.width, p.height);
            
            if (ballrec.IntersectsWith(herorec))
            {
                return true;
            }
            return false;
        }
    }
}
