using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BiletProje
{
    public partial class frmYolcuGiris : Form
    {
        public frmYolcuGiris()
        {
            InitializeComponent();
        }

        sql bgl = new sql();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_YolcuBilgileri", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmAnaPanel frm = new frmAnaPanel();
                frm.tcno = mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifre Hatalı, tekrar deneyiniz.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUyeOl frm = new frmUyeOl();
            frm.Show();        
        }
    }
}
