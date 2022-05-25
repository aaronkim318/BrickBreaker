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
    public partial class VictoryScreen : UserControl
    {
        public VictoryScreen()
        {
            MenuScreen.soundList[13].Play();
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuScreen.soundList[2].Play(); //Plays button sound
            Form form = this.FindForm();
            MenuScreen ps = new MenuScreen();

            ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);

            form.Controls.Add(ps);
            form.Controls.Remove(this);

        }
    }
}
