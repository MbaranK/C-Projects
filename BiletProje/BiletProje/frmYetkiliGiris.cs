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
    public partial class frmYetkiliGiris : Form
    {
        public frmYetkiliGiris()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Yetkili", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmYetkiliPanel frm = new frmYetkiliPanel();
                frm.tc = mskTC.Text;
                frm.Show();   
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifre Yanlış, tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
