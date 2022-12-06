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

namespace OkulProjesi
{
    public partial class frmOgrenciGiris : Form
    {
        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Ogrenciler where OgrenciTC=@p1 and OgrenciSifre=@p2", bgl.baglanti1());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmOgrenciIslemler frm = new frmOgrenciIslemler();
                frm.tc = mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifre hatalı, tekrar deneyiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
