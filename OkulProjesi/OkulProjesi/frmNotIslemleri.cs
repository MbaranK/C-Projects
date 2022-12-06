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
    public partial class frmNotIslemleri : Form
    {
        public frmNotIslemleri()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        DataSet1TableAdapters.DataTable2TableAdapter ds = new DataSet1TableAdapters.DataTable2TableAdapter();

        private void frmNotIslemleri_Load(object sender, EventArgs e)
        {
            //Datagride verileri çekme
            dataGridView1.DataSource = ds.notListele();
            //

            //Comboboxa dersleri aktarma
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Dersler", bgl.baglanti1());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "DersId";
            cmbDers.DataSource = dt;
            //

                     
        }

        int notid;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDers.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtVize.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFinal.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            
        }

        public int vize, final;
        double ortalama;

        private void btnNotGiris_Click(object sender, EventArgs e)
        {
            // ds.notEkle(int.Parse(txtOgrenciId.Text), int.Parse(txtVize.Text), int.Parse(txtFinal.Text));
            ds.notEkle2(byte.Parse(cmbDers.SelectedValue.ToString()), int.Parse(txtOgrenciId.Text), int.Parse(txtVize.Text), int.Parse(txtFinal.Text));
       
            MessageBox.Show("Not eklemesi gerçekleştirildi");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.notListele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            ds.notGüncelle(int.Parse(txtOgrenciId.Text), int.Parse(txtVize.Text), int.Parse(txtFinal.Text), decimal.Parse(txtOrtalama.Text), bool.Parse(txtDurum.Text), notid);
            MessageBox.Show("Not bilgileri sistemde güncelleştirildi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.NotSil(notid);
            MessageBox.Show("Kayıt sistemden silindi.");
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
             dataGridView1.DataSource = ds.notarama(int.Parse(txtOgrenciId.Text));
            
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize = Convert.ToInt16(txtVize.Text);
            final = Convert.ToInt16(txtFinal.Text);
            ortalama = (vize + final) / 2.00;
            txtOrtalama.Text = ortalama.ToString();

            if(ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }
        }
    }
}
