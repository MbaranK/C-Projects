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
    public partial class frmNotlarım : Form
    {
        public frmNotlarım()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        DataSet1TableAdapters.DataTable3TableAdapter ds = new DataSet1TableAdapters.DataTable3TableAdapter();
        public string tcno;
        public string ogrid;

        private void frmNotlarım_Load(object sender, EventArgs e)
        {
            //Öğrenci ismi getirme.(Form Text)

            SqlCommand komut = new SqlCommand("select OgrenciAd + ' ' + OgrenciSoyad from tbl_Ogrenciler where OgrenciTC=@p1", bgl.baglanti1());
            komut.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString();
            }
            bgl.baglanti1().Close();
            //
            // ogrenci ıd getirme
            SqlCommand komut1 = new SqlCommand("select OgrenciId from tbl_Ogrenciler where OgrenciTC=@p1", bgl.baglanti1());
            komut1.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                ogrid = dr1[0].ToString();
            }
            //
            //Datagride verileri çekme
            dataGridView1.DataSource = ds.notgetir2(int.Parse(ogrid));
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDurum.Visible = true;
            txtDers.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if(bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) == true)
            {               
                lblDurum.Text = "Geçtiniz.";
            }
            if(bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) == false)
            {
                lblDurum.Text = "Kaldınız.";
            }
        }
    }
}
