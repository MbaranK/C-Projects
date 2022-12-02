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
    public partial class frmBilgileriDüzenle : Form
    {
        public frmBilgileriDüzenle()
        {
            InitializeComponent();
        }

        sql bgl = new sql();
        public string tc;
        private void btnBilgileriGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_YolcuBilgileri set YolcuAd=@p1, YolcuSoyad=@p2, YolcuYas=@p4, YolcuEmail=@p5, YolcuTel=@p6, YolcuCinsiyet=@p7, YolcuSifre=@p8 where YolcuTC=@p3 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", txtYas.Text);
            komut.Parameters.AddWithValue("@p5", txtEmail.Text);
            komut.Parameters.AddWithValue("@p6", mskTel.Text);
            komut.Parameters.AddWithValue("@p7", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p8", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme gerçekleştirildi.");
        }

        private void frmBilgileriDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tc;
        }
    }
}
