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
    public partial class CreditScreen : UserControl
    {
        public CreditScreen()
        {
            MenuScreen.soundList[10].Play();
            InitializeComponent();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            MenuScreen.soundList[2].Play(); //Plays a camera select sound
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ms);
            form.Controls.Remove(this);

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
        }
    }
}
