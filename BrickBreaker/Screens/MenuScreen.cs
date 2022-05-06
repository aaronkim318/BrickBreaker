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

            int y = randGen.Next(40, screenSize.Height - 40);

            Rectangle AmongOne = new Rectangle(0, y, 15, 15);
            SquareList.Add(AmongOne);
         //       sleep(1000);
        }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int xspeed = 8;

            for (int i = 0; i < SquareList.Count; i++)
            {
                int x = SquareList[i].X + xspeed;
                SquareList[i] = new Rectangle(x, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);

            // if (SquareList[i].X >= 167)
            //{
            //  x = 0;
            //}

            }
            Refresh();
        }


        private void MenuScreen_Paint(object sender, PaintEventArgs e)
        {
            int randColour = randGen.Next(1,5);

            for (int i = 0; i < SquareList.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.Green, SquareList[i].X, SquareList[i].Y, SquareList[i].Width, SquareList[i].Height);
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
    }
}
