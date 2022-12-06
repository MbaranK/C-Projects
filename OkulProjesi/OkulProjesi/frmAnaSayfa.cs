using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProjesi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        private void picExit_MouseHover_1(object sender, EventArgs e)
        {
            picExit.Size = new Size(picExit.Width + 10, picExit.Height + 5);
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            if(picExit.Size.Height > 40 && picExit.Size.Width > 30)
            {
                picExit.Size = new Size(picExit.Width - 10, picExit.Height - 5);
            }

        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            frmOgretmenGiris frm = new frmOgretmenGiris();
            frm.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenciGiris frm = new frmOgrenciGiris();
            frm.Show();
            this.Hide();
        }
    }
}
