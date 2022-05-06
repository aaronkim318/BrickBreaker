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

        List<Rectangle> SquareList = new List<Rectangle>(); //Made List for squares (JUAN)
        Random randGen = new Random();
        Size screenSize;

        public MenuScreen()
        {
            InitializeComponent();
            Juanmethod_FlyingSquare();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Juanmethod_FlyingSquare() //Method meant to create flying squares (JUAN)
        {

            for (int i = 0; i < 5; i++) //for loop to create the limit of square
            {
                JuanMethod_NewFlyingSquares();
            }

            Juanmethod_MovingSquares(); //Declares the move method
        }

        public void JuanMethod_NewFlyingSquares()  //method meant for creating and putting the squares into a list (JUAN)
        {



            screenSize = new Size(this.Width, this.Height);

         int x = randGen.Next(40, screenSize.Width - 40);
         int y = randGen.Next(40, screenSize.Height - 40);

         Rectangle AmongOne = new Rectangle(x, y, 8, 8);
            SquareList.Add(AmongOne);

        }

        public void Juanmethod_MovingSquares() //Method meant for moving the squares (JUAN)
        {
            int xspeed = 4;
            for (int i = 1; i < 0; i++)
            {
                square.x = square.x + xspeed;
            }

            if (SquareList[i] <= 1067)
            {
                int x = randGen.Next(40, screenSize.Width - 40);
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

    }
}
