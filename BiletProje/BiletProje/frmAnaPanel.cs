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
    public partial class frmAnaPanel : Form
    {
        public frmAnaPanel()
        {
            InitializeComponent();
        }

        sql bgl = new sql();
        public string tcno;
        private void frmAnaPanel_Load(object sender, EventArgs e)
        {
            //Yolcu Bilgilerini Çekme
            SqlCommand komut = new SqlCommand("select * from tbl_YolcuBilgileri where YolcuTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTC.Text = dr[3].ToString();
                mskTel.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
            //

            //Otobüs Seferlerini getirme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Otobus where OtobusDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Duyuruları Çekme
            SqlCommand komut2 = new SqlCommand("select Duyuru from tbl_Duyuru", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                rchDuyuru.Text = dr2[0].ToString();
            }
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            frmBilgileriDüzenle frm = new frmBilgileriDüzenle();
            frm.tc = tcno;
            frm.Show();
        }

        private void btnOtobusBilet_Click(object sender, EventArgs e)
        {
            frmOtobusSec frm = new frmOtobusSec();
            frm.tarih = mskTarih.Text;
            frm.nereden = cmbNereden.Text;
            frm.nereye = cmbNereye.Text;
            frm.Show();
        }
    }
}
