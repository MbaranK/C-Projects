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
    public partial class frmUyeOl : Form
    {
        public frmUyeOl()
        {
            InitializeComponent();
        }

        sql bgl = new sql();
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_YolcuBilgileri (YolcuAd, YolcuSoyad, YolcuTC, YolcuYas, YolcuEmail, YolcuTel, YolcuCinsiyet, YolcuSifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
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
            MessageBox.Show("Üyelik kaydı oluşturuldu.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
