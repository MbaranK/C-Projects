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

namespace kisiKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OOJK8R6;Initial Catalog=KisiListesi;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

           //Temizleme
           private void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMeslek.Text = "";
            txtId.Text = "";
            txtYas.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtAd.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_KisiListesiTableAdapter2.Fill(this.kisiListesiDataSet2.tbl_KisiListesi);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_KisiListesi(kisiAd, kisiSoyad, kisiMeslek, kisiMaas, kisiMedeni, kisiSehir, kisiYas) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", label9.Text);
            komut.Parameters.AddWithValue("@p6", cmbSehir.Text);
            komut.Parameters.AddWithValue("p7", txtYas.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Eklendi.");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            MessageBox.Show("Temizleme işlemi gerçekleştirildi.");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_KisiListesi set kisiAd=@p1, kisiSoyad=@p2, kisiMeslek=@p3, kisiMaas=@p4, kisiMedeni=@p5, kisiSehir=@p6, kisiYas=@p7 where kisiid=@p8", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", label9.Text);
            komut.Parameters.AddWithValue("@p6", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p7", txtYas.Text);
            komut.Parameters.AddWithValue("@p8", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Gerçekleştirildi.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "false";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtYas.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if(label9.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label9.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_KisiListesi where kisiid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleştirildi.");
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            frmistatistik frm1 = new frmistatistik();

            frm1.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            frmGrafik frm2 = new frmGrafik();
            frm2.Show();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SeaGreen;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.SlateGray;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
