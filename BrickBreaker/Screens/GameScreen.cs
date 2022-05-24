/*  Created by: 
 *  Project: Brick Breaker
 *  Date: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, rightArrowDown;

        //boolean for the ball movement
        Boolean ballStart;

        //boolean for key presses and ball
        Boolean spaceDown, ballFollow;


        int level;

        // Game values
        int lives;

        // Paddle and Ball objects
        Paddle paddle;
        Ball ball;


        // list of all blocks for current level
        List<Block> blocks = new List<Block>();


        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush blockBrush = new SolidBrush(Color.Red);

        #endregion

        //bill

        List<PowerUp1> power = new List<PowerUp1>();
        int powerChosen;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();

        }


        public void OnStart()
        {
            level = 1;
            //set life counter
            lives = 3;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = spaceDown = ballFollow = false;

            // setup starting paddle values and create paddle object
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = (this.Height - paddle.height) - 85;

            // Creates a new ball
            int xSpeed = 6;
            int ySpeed = 6;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);

            pauseLabel.Visible = false;




            #region Creates blocks for generic level. Need to replace with code that loads levels.
            //wait until adrian is done making the levels and importing them into an xml file

            //TODO - replace all the code in this region eventually with code that loads levels from xml files
            levelOne();
            #endregion

            // start the game engine loop
            gameTimer.Enabled = true;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    if (gameTimer.Enabled)
                    {
                        gameTimer.Enabled = false;
                        MenuScreen.soundList[3].Play(); //Plays pause sound
                        pauseLabel.Visible = true;
                        pauseLabel.Text = $"PAUSED";
                    }
                    else
                    {
                        gameTimer.Enabled = true;
                        MenuScreen.soundList[3].Play(); //Plays pause sound
                        pauseLabel.Visible = false;
                    }

                    break;


            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }
        public void PowerUps()
        {
            Random randGen = new Random();
            powerChosen = randGen.Next(0, 5);

            if (powerChosen == 0)
            {
                PowerUp1 longPaddle = new PowerUp1(ball.x, ball.y, ball.size, ball.size, "longPaddle");
                power.Add(longPaddle);
            }
            if (powerChosen == 1)
            {
                PowerUp1 shortPaddle = new PowerUp1(ball.x, ball.y, ball.size, ball.size, "shortPaddle");
                power.Add(shortPaddle);
            }
            if (powerChosen == 2)
            {
                PowerUp1 fastPaddle = new PowerUp1(ball.x, ball.y, ball.size, ball.size, "fastPaddle");
                power.Add(fastPaddle);
            }
            if (powerChosen == 3)
            {
                PowerUp1 fastBall = new PowerUp1(ball.x, ball.y, ball.size, ball.size, "fastBall");
                power.Add(fastBall);
            }
            if (powerChosen == 4)
            {
                PowerUp1 slowBall = new PowerUp1(ball.x, ball.y, ball.size, ball.size, "slowBall");
                power.Add(slowBall);
            }
            if(powerChosen == 5)
            {
                PowerUp1 slowPaddle = new PowerUp1(ball.x, ball.y, ball.size, ball.size, "slowPaddle");
                power.Add(slowPaddle);
            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            #region PowerUps
            foreach (PowerUp1 p in power)
            {
                for (int i = 0; i < power.Count(); i++)
                {
                    power[i].y += 4;
                    if (power[i].y >= this.Height - 30)
                    {
                        power.RemoveAt(i);
                    }
                }
            }


            #endregion

            //has the ball move witht the arrow clicks
            if (ballFollow == false)
            {
                // Move the paddle and the ball together
                if (leftArrowDown && paddle.x > 0)
                {
                    ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                    ball.y = (this.Height - paddle.height) - 85;
                    paddle.Move("left");
                }
                if (rightArrowDown && paddle.x < (this.Width - paddle.width))
                {
                    ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                    ball.y = (this.Height - paddle.height) - 85;
                    paddle.Move("right");
                }
            }
            else
            {
                // Move the paddle
                if (leftArrowDown && paddle.x > 0)
                {
                    paddle.Move("left");
                }
                if (rightArrowDown && paddle.x < (this.Width - paddle.width))
                {
                    paddle.Move("right");
                }
            }
            //is space is pressed then move ball
            if (spaceDown == true)
            {
               // MenuScreen.soundList[1].Play(); //Plays pause sound
                ballStart = true;
                ballFollow = true;
            }
            if (ballStart == true)
            {
                //moves the ball
                ball.Move();
            }

            // Check for collision with top and side walls
            ball.WallCollision(this);

            // Check for ball hitting bottom of screen and end game if lives = 0
            if (ball.BottomCollision(this))
            {
                lives--;

                // Moves the ball back to origin
                ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                ball.y = (this.Height - paddle.height) - 85;

                if (lives == 0)
                {
                    gameTimer.Enabled = false;
                    JuanMethod_OnEnd();
                    //OnEnd();
                }
                ballStart = false;
                ballFollow = false;
            }

            // Check for collision of ball with paddle, (incl. paddle movement)
            ball.PaddleCollision(paddle);

            // Check if ball has collided with any blocks
            foreach (Block b in blocks)
            {
                if (ball.BlockCollision(b))
                {
                    
                     MenuScreen.soundList[8].Play(); //Plays destroy block sound
                    blocks.Remove(b);

                    if (blocks.Count == 0 && level < 5)
                    {

                        level++;
                        levelOne();
                    }
                    break;
                }
            }
            Refresh();
        }

        public void OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();
            MenuScreen ps = new MenuScreen();

            ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);

            form.Controls.Add(ps);
            form.Controls.Remove(this);
        }

        public void JuanMethod_OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();
            GameOverScreen gos = new GameOverScreen();

            gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);

            form.Controls.Add(gos);
            form.Controls.Remove(this);
        }
        public void JuanMethod_OnVictory()
        {
            // Goes to the victory screen
            Form form = this.FindForm();
            VictoryScreen vs = new VictoryScreen();

            vs.Location = new Point((form.Width - vs.Width) / 2, (form.Height - vs.Height) / 2);

            form.Controls.Add(vs);
            form.Controls.Remove(this);
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws paddle
            paddleBrush.Color = paddle.colour;
            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);

            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(blockBrush, b.x, b.y, b.width, b.height);
            }

            // Draws ball
            e.Graphics.FillRectangle(ballBrush, ball.x, ball.y, ball.size, ball.size);

            foreach(PowerUp1 p in power)
            {
                //if()
            }
        }
        public void levelOne()
        {
            // current level


            // variables for block x and y values
            string blockX;
            string blockY;
            int intX;
            int intY;

            // create xml reader
            XmlTextReader reader = new XmlTextReader("Resources/level1.xml");

            reader.ReadStartElement("level");

            //Grabs all the blocks for the current level and adds them to the list
            while (reader.Read())
            {
                reader.ReadToFollowing("x");
                blockX = reader.ReadString();

                reader.ReadToFollowing("y");
                blockY = reader.ReadString();

                if (blockX != "")
                {
                    intX = Convert.ToInt32(blockX);
                    intY = Convert.ToInt32(blockY);
                    Block b = new Block(intX, intY, level);
                    blocks.Add(b);
                }
            }
            // close reader
            reader.Close();
        }
    }

}
