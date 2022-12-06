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
    public partial class frmOgretmenGiris : Form
    {
        public frmOgretmenGiris()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Ogretmenler where OgretmenTC=@p1 and OgretmenSifre=@p2", bgl.baglanti1());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmOgretmenIslemler frm = new frmOgretmenIslemler();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Şifra hatalı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
