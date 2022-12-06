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
using OkulProjesi.DataSet1TableAdapters;

namespace OkulProjesi
{
    public partial class frmOgrenciEkleCıkarma : Form
    {
        public frmOgrenciEkleCıkarma()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataTable1TableAdapter();
        private void frmOgrenciEkleCıkarma_Load(object sender, EventArgs e)
        {
            //Data gride öğrenci verilerini çekme
            dataGridView1.DataSource = ds.OgrenciListesi();

            //Dersleri Comboboxa aktarma
            //SqlCommand komut = new SqlCommand("select * from tbl_Dersler", bgl.baglanti1());
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Dersler", bgl.baglanti1());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "DersId";
            cmbDers.DataSource = dt;
            bgl.baglanti1().Close();
            //

            //Kulüpleri Comboboxa aktarma
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_Kulupler", bgl.baglanti1());
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbKulup.DisplayMember = "KulupAd";
            cmbKulup.ValueMember = "KulupId";
            cmbKulup.DataSource = dt1;
            //
        }
        public string cinsiyet;
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            if(radioButton2.Checked == true)
            {
                cinsiyet = "Kadın";
            }
            if(txtAd.Text != null && txtSoyad.Text != null && cmbDers.Text != null && cmbKulup.Text != null && cinsiyet != null && txtTC.Text != null && txtSifre.Text !=null)
            {
                ds.OgrenciEkle(txtAd.Text, txtSoyad.Text, byte.Parse(cmbDers.SelectedValue.ToString()), byte.Parse(cmbKulup.SelectedValue.ToString()), cinsiyet, txtTC.Text, txtSifre.Text);
                MessageBox.Show("Öğrenci sisteme kayıt edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDers.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbKulup.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTC.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();



            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Erkek")
            {
                radioButton1.Checked = true;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Kadın")
            {
                radioButton2.Checked = true;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtId.Text));
            MessageBox.Show("Öğrenci sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            if (radioButton2.Checked == true)
            {
                cinsiyet = "Kadın";
            }

            if (txtAd.Text != null && txtSoyad.Text != null && cmbDers.Text != null && cmbKulup.Text != null  && cinsiyet != null && txtTC.Text != null && txtSifre.Text != null)
            {
                ds.OgrenciGüncelle(txtAd.Text, txtSoyad.Text, byte.Parse(cmbDers.SelectedValue.ToString()), byte.Parse(cmbKulup.SelectedValue.ToString()), cinsiyet, txtTC.Text, txtSifre.Text, int.Parse(txtId.Text));
                MessageBox.Show("Öğrenci sistemde başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
