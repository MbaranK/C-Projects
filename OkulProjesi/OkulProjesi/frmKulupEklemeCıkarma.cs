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
    public partial class frmKulupEklemeCıkarma : Form
    {
        public frmKulupEklemeCıkarma()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        DataSet1TableAdapters.tbl_KuluplerTableAdapter ds = new DataSet1TableAdapters.tbl_KuluplerTableAdapter();
        private void frmKulupEklemeCıkarma_Load(object sender, EventArgs e)
        {
            //Comboboxa kulüp isimlerini yerleştirme
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Kulupler", bgl.baglanti1());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulupAd.DisplayMember = "KulupAd";
            cmbKulupAd.ValueMember = "KulupId";
            cmbKulupAd.DataSource = dt;
            //

            //Datagride kulüp datasını çekme
            dataGridView1.DataSource = ds.KulupListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbKulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.KulupListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.kulupEkle(cmbKulupAd.Text);
            MessageBox.Show("Kulüp sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.kulupGuncelle(cmbKulupAd.Text, byte.Parse(txtKulupId.Text));
            MessageBox.Show("Kulüp sistemde başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.kulupSil(byte.Parse(txtKulupId.Text));
            MessageBox.Show("Kulüp sistemden başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
