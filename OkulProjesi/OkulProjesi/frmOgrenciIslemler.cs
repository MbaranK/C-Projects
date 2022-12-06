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
    public partial class frmOgrenciIslemler : Form
    {
        public frmOgrenciIslemler()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        public string tc;

        private void button1_Click(object sender, EventArgs e)
        {
            frmNotlarım frm = new frmNotlarım();
            frm.tcno = tc;
            frm.Show();
        }

        private void frmOgrenciIslemler_Load(object sender, EventArgs e)
        {
            //Öğrenci ismi getirme.(Form Text)
            SqlCommand komut = new SqlCommand("select OgrenciAd + ' ' + OgrenciSoyad from tbl_Ogrenciler where OgrenciTC=@p1",bgl.baglanti1());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString();
            }
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDersIslemleri frm = new frmDersIslemleri();
            frm.tcnoders = tc;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKuluplerim frm = new frmKuluplerim();
            frm.tcnoders = tc;
            frm.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnaSayfa frm = new frmAnaSayfa();
            frm.Show();
        }
    }
}
