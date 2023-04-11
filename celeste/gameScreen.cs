using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celeste
{
    public partial class gameScreen : UserControl
    {
        List<Platforms> platforms = new List<Platforms>();
        List<Balls> balls = new List<Balls>();
        Random randGen = new Random();

        Player hero;
        bool canJump;

        int Counter;

        Boolean aDown, dDown, wDown, sDown;

        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        public gameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            gameEngine.Enabled = true;

            hero = new Player(200, 300, 20, 20, 6, -8);

            int x = -120;
            int y = 400;

            for (int i = 0; i < 3; i++)
            {
                x = x + 150;
                y = 400;
                Platforms newplatforms = new Platforms(x, y, 75, 50);
                platforms.Add(newplatforms);
            }
        }

        private void gameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
            }
        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
            }
        }

        private void gameEngine_Tick(object sender, EventArgs e)
        {
            #region Move Controls
            if (wDown && hero.y > 0 && canJump == true)
            {
                hero.y = 300;
            }
            if (sDown && hero.y < this.Height - hero.height)
            {
                hero.Move("down");
            }  
            if (aDown && hero.x > 0)
            {
                hero.Move("left");
            }
            if (dDown && hero.x < this.Width - hero.width)
            {
                hero.Move("right");
            }
            #endregion

            //gravity
            #region gravity
            hero.y -= hero.ySpeed;
            #endregion

            //collison with platform
            #region collisions with platforms
            Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.width, hero.height);

            foreach (Platforms p in platforms)
            {
                Rectangle r = new Rectangle(p.x, p.y, p.width, p.height);

                if (heroRec.IntersectsWith(r))
                {
                    hero.y += hero.ySpeed;
                    canJump = true;
                }
                else if (hero.y >= 381)
                {
                    canJump = false;
                }
            }
            #endregion

            //collision with balls
            #region collision with balls
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].Collision(hero) == true)
                {
                    Form1.ChangeScreen(this, new gameOver());
                    gameEngine.Enabled = false;
                }
            }
            #endregion

            //player void
            #region player void
            if (hero.y >= this.Height)
            {
                Form1.ChangeScreen(this, new gameOver());
                gameEngine.Enabled = false;
            }
            #endregion

            //move balls
            #region ball code
            Counter++;

            if (Counter == 20)
            {
                for (int i = 0; i < 1; i++)
                {
                    Balls newBall = new Balls(randGen.Next(0, this.Width - 10), 0, 3);
                    balls.Add(newBall);
                }
                Counter = 0;
            }

            foreach (Balls b in balls)
            {
                b.Move(this.Width, this.Height);
            }

            for (int i = 0; i < balls.Count(); i++)
            {
                if (balls[i].ballY > this.Height)
                {
                    balls.RemoveAt(i);
                }
            }
            #endregion

            Refresh();
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.width, hero.height);
            foreach (Platforms p in platforms)
            {
                e.Graphics.FillRectangle(blackBrush, p.x, p.y, p.width, p.height);
            }
            foreach (Balls b in balls)
            {
                e.Graphics.FillRectangle(blackBrush, b.ballX, b.ballY, b.size, b.size);
            }

        }
    }
}
