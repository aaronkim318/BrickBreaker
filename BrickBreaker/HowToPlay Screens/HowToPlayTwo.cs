using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class HowToPlayTwo : UserControl
    {
        public HowToPlayTwo()
        {
            InitializeComponent();
        }

        private void backButtonHowTo_Click(object sender, EventArgs e)
        {
            MenuScreen.soundList[2].Play(); //Plays a camera select sound
            HowToPlay htp = new HowToPlay();
            Form form = this.FindForm();

            form.Controls.Add(htp);
            form.Controls.Remove(this);
            MenuScreen.soundList[11].Play(); //Plays the extras theme

            htp.Location = new Point((form.Width - htp.Width) / 2, (form.Height - htp.Height) / 2);
        }

        private void nextButtonOne_Click(object sender, EventArgs e)
        {
            MenuScreen.soundList[2].Play(); //Plays a camera select sound
            HowToPlayThree htp3 = new HowToPlayThree();
            Form form = this.FindForm();

            form.Controls.Add(htp3);
            form.Controls.Remove(this);
            MenuScreen.soundList[11].Play(); //Plays the extras theme

            htp3.Location = new Point((form.Width - htp3.Width) / 2, (form.Height - htp3.Height) / 2);
        }
    }
}
