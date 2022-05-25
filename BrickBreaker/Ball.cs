using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class Ball
    {
        public int x, y, xSpeed, ySpeed, size;
        public Color colour;
        //int randgen = new Random();

        public static Random rand = new Random();
        

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;

        }

        public void Move()
        {
            x = x + xSpeed;
            y = y + ySpeed;
        }


        // checks if ball hits a block and returns it to game screen 
        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(blockRec))
            {

                //checks to see where the ball collides
                if (ySpeed > 0)
                {
                    y = b.y - size;

                }
                else
                {
                    y = b.y + size;
                }

                ySpeed *= -1;
            }

            return blockRec.IntersectsWith(ballRec);
        }

        //checks if ball hits paddle 
        //public void PaddleCollision(Paddle p)
        //{
        //    Rectangle ballRec = new Rectangle(x, y, size, size);
        //    Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

        //    //revereses speed on contact 
        //    if (ballRec.IntersectsWith(paddleRec))
        //    {
        //        //moves ball above paddle 
        //        y = p.y - size;

        //        ySpeed *= -1;

        //    }
        //}

        //check if ball hits wall 
        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                MenuScreen.soundList[6].Play(); //Plays Bounce sound
                xSpeed *= -1;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                MenuScreen.soundList[6].Play(); //Plays Bounce sound
                xSpeed *= -1;
            }
           // Collision with top wall
            if (y <= 2)
            {
                MenuScreen.soundList[6].Play(); //Plays Bounce sound
                ySpeed *= -1;
            }
        }


        //check if ball hits bottom and returns the value back to game screen
        public bool BottomCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y >= UC.Height)
            {
                MenuScreen.soundList[5].Play(); //Plays a sad sound (JUAN)
                didCollide = true;
            }

            return didCollide;
        }

        //public void Vent(Ventblock v)
        //{
        //    Rectangle ventRec1 = new Rectangle();
        //    Rectangle ventRec2 = new Rectangle(v.x, v.y, v.width, v.height);
        //    Rectangle ballRec = new Rectangle(x, y, size, size);

        //    if (ballRec.IntersectsWith(ventRec1))
        //    {
        //        y = v.y;
        //        x = v.x;

        //    }
        //    if (ballRec.IntersectsWith(ventRec2))
        //    {
        //        y = v.y;
        //        x = v.x; 
        //    }
        //}

        // rough broken code for ball angle based on paddle speed 
        
        public void PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            //revereses speed on contact 
            if (ballRec.IntersectsWith(paddleRec))
            {
                MenuScreen.soundList[6].Play(); //Plays Bounce sound
                //moves ball above paddle 
                y = p.y - size;



                //if paddle is moving in the left direction increase the angle based off of its speed.
                if (p.speed < 0)
                {
                    ySpeed *= -1;
                        if (xSpeed > 4)
                        { 
                        xSpeed -= 2;
                        }
                }

                if (p.speed > 0)
                {
                    ySpeed *= -1;
                    
                    xSpeed += 2;
                }

            }
        }
    }
}
