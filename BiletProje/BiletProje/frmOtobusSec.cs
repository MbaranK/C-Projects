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
    public partial class frmOtobusSec : Form
    {
        public frmOtobusSec()
        {
            InitializeComponent();
        }

        sql bgl = new sql();
        public string tarih, nereden, nereye;

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                // Otobüs Tablosundan bilet alındığı zaman Otobus durumu true hale getirme.
                SqlCommand komut = new SqlCommand("update tbl_Otobus set OtobusDurum=@p1 where OtobusID=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblOtobüsDurum.Text);
                komut.Parameters.AddWithValue("@p2", lblSecilenOtobusID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                //
                //Bileti Tabloya Aktarma
                SqlCommand komut2 = new SqlCommand("insert into tbl_BiletBilgileri (BiletNereden, BiletNereye, BiletTarih, BiletSaat, BiletFiyat) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", cmbNereden.Text);
                komut2.Parameters.AddWithValue("@p2", cmbNereye.Text);
                komut2.Parameters.AddWithValue("@p3", mskTarih.Text);
                komut2.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut2.Parameters.AddWithValue("@p5", txtFiyat.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bilet Alma işlemi gerçekleştirildi.");
            }
            else
            {
                MessageBox.Show("Bileti satın alımını gerçekleştirmek için kullanım koşullarını kabul etmeniz gerekmektedir.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            lblBiletId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cmbBiletNereden.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            cmbBiletNereye.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            mskBiletTarih.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            mskBiletSaat.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            

            // Bilet iptal edildiği zaman önce alınan biletin, otobüs tablosundaki durumunu 0 'a çeviriyorum.
            SqlCommand komut = new SqlCommand("update tbl_Otobus set OtobusDurum = 0  where OtobusSaat = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskBiletSaat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            //

            // İkinci Olarak biletlerim kısmından siliyorum.
            SqlCommand komut2 = new SqlCommand("delete from tbl_BiletBilgileri where Biletid=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", lblBiletId.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilet iptali gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblOtobüsDurum.Text = "True";
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            lblSecilenOtobusID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbNereden.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbNereye.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskSaat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtYolculukSüre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            lblOtobüsDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void frmOtobusSec_Load(object sender, EventArgs e)
        {
            //Seçilen Tarihdeki seferleri data gride çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Otobus where OtobusNereden='" + nereden + "' and OtobusNereye='" + nereye + "' and OtobusTarih='" + tarih + "'and OtobusDurum=0 order by OtobusSaat asc",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //

            //Biletlerimi Görüntüleme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_BiletBilgileri", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
    }
}
