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

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        //----Juan------//
        public static List<Rectangle> SquareList = new List<Rectangle>(); //Made List for squares (JUAN)
        Random randGen = new Random();
        Size screenSize;
        int angle;
        //--------------//

        public MenuScreen()
        {
            InitializeComponent();
            JuanMethod_FlyingSquares(); //Declares the new square method
        }

        public void JuanMethod_FlyingSquares()  //method meant for creating and putting the squares into a list (JUAN)
        {
            for (int i = 0; i < 5; i++) { //for loop to create the limit of square 
                
            screenSize = new Size(this.Width, this.Height);

            int y = randGen.Next(100, screenSize.Height - 250);

            Rectangle AmongOne = new Rectangle(0, y, 30, 30);
            SquareList.Add(AmongOne);
    
        }

        }

        
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int xspeed = 35;
            int whichAngle = randGen.Next(1, 2);
            int randHeight = randGen.Next(200, 450);


            for (int i = 0; i < SquareList.Count; i++)
            {
                int x = SquareList[i].X + xspeed;
                int y = SquareList[i].Y;
                SquareList[i] = new Rectangle(x, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);

                if (SquareList[i].X >= 1067)
                {
                    x = 0;
                    y = randHeight;
                    SquareList[i] = new Rectangle(x, y, SquareList[i].Width, SquareList[i].Height);
  
                }
            
            }

            if (whichAngle == 1)
            {
                angle--;
            }

            else if (whichAngle == 2)
            {
                angle++;
            }
            
            Refresh();
        }


        private void MenuScreen_Paint(object sender, PaintEventArgs e)
        {
            int randColour = randGen.Next(1,5);

            Graphics g = this.CreateGraphics();
            //the central point of the rotation
            g.TranslateTransform(0, 0);
            //rotation procedure
            g.RotateTransform(5.0F);

            for (int i = 0; i < SquareList.Count; i++)
            {

                if (randColour == 1)
                {
                    g.DrawRectangle(Pens.Red, SquareList[i].X, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);
                }

                else if (randColour == 2)
                {
                    g.DrawRectangle(Pens.Blue, SquareList[i].X, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);
                }

                else if (randColour == 3)
                {
                    g.DrawRectangle(Pens.Yellow, SquareList[i].X, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);
                }

                else if (randColour == 4)
                {
                    g.DrawRectangle(Pens.Pink, SquareList[i].X, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);
                }

                else if (randColour == 5)
                {
                    g.DrawRectangle(Pens.Orange, SquareList[i].X, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);
                }
            }

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void howToButton_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            Form form = this.FindForm();

            form.Controls.Add(htp);
            form.Controls.Remove(this);

            htp.Location = new Point((form.Width - htp.Width) / 2, (form.Height - htp.Height) / 2);
        }
    }
}
