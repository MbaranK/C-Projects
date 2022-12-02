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
    public partial class frmYetkiliPanel : Form
    {
        public frmYetkiliPanel()
        {
            InitializeComponent();
        }
        sql bgl = new sql();
        public string tc;
        private void frmYetkiliPanel_Load(object sender, EventArgs e)
        {

            //Yetkili bilgilerini çekme işlemi
            SqlCommand komut = new SqlCommand("select * from tbl_Yetkili where YetkiliTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTC.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
            //

            //Seferleri Çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Otobus", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //
        }

        private void btnYetkiliAtama_Click(object sender, EventArgs e)
        {
            frmYetkiliİslemleri frm = new frmYetkiliİslemleri();
            frm.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtYolculukSüre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnSeferDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Otobus (OtobusNereden, OtobusNereye, OtobusTarih, OtobusSaat, OtobusSure, OtobusFiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbNereden.Text);
            komut.Parameters.AddWithValue("@p2", cmbNereye.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", txtYolculukSüre.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sefer düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSeferGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Otobus set OtobusNereden=@p1, OtobusNereye=@p2, OtobusTarih=@p3, OtobusSaat=@p4, OtobusSure=@p5, OtobusFiyat=@p6 where OtobusID=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbNereden.Text);
            komut.Parameters.AddWithValue("@p2", cmbNereye.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", txtYolculukSüre.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.Parameters.AddWithValue("@p7", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeferSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_Otobus where OtobusID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sefer silme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Duyuru (Duyuru) values(@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }
    }
}
