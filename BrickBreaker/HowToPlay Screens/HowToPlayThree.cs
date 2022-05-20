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
    public partial class HowToPlayThree : UserControl
    {
        public HowToPlayThree()
        {
            MenuScreen.soundList[11].Play();
            InitializeComponent();
        }

        private void backButtonHowTo_Click(object sender, EventArgs e)
        {
            MenuScreen.soundList[2].Play(); //Plays a camera select sound
            HowToPlayTwo htp2 = new HowToPlayTwo();
            Form form = this.FindForm();

            form.Controls.Add(htp2);
            form.Controls.Remove(this);

            htp2.Location = new Point((form.Width - htp2.Width) / 2, (form.Height - htp2.Height) / 2);
        }
    }
}
