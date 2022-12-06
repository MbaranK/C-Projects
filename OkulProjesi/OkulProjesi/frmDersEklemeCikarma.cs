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
    public partial class frmDersEklemeCikarma : Form
    {
        public frmDersEklemeCikarma()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        DataSet1TableAdapters.tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.tbl_DerslerTableAdapter();
        private void frmDersEklemeCikarma_Load(object sender, EventArgs e)
        {
            //Comboxa Dersleri çekme
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Dersler",bgl.baglanti1());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDersAd.DisplayMember = "DersAd";
            cmbDersAd.ValueMember = "DersId";
            cmbDersAd.DataSource = dt;
            //

            //Data gride verileri çekme 
            dataGridView1.DataSource = ds.DersListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(cmbDersAd.Text);
            MessageBox.Show("Ders sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtDersID.Text));
            MessageBox.Show("Ders sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(cmbDersAd.Text, byte.Parse(txtDersID.Text));
            MessageBox.Show("Ders sistem üzerinde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
