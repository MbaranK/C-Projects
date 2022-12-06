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
    public partial class frmOgretmenIslemler : Form
    {
        public frmOgretmenIslemler()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmOgrenciEkleCıkarma frm = new frmOgrenciEkleCıkarma();
            frm.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDersEklemeCikarma frm = new frmDersEklemeCikarma();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKulupEklemeCıkarma frm = new frmKulupEklemeCıkarma();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNotIslemleri frm = new frmNotIslemleri();
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaSayfa frm = new frmAnaSayfa();
            frm.Show();
        }
    }
}
