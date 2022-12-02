using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletProje
{
    public partial class frmSecimEkranı : Form
    {
        public frmSecimEkranı()
        {
            InitializeComponent();
        }

        private void btnYetkili_Click(object sender, EventArgs e)
        {
            frmYetkiliGiris frm = new frmYetkiliGiris();
            frm.Show();
            this.Hide();
        }

        private void btnYolcu_Click(object sender, EventArgs e)
        {
            frmYolcuGiris frm = new frmYolcuGiris();
            frm.Show();
            this.Hide();
        }
    }
}
