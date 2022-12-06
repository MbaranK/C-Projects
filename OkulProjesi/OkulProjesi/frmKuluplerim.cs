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
using System.Security.Cryptography;

namespace OkulProjesi
{
    public partial class frmKuluplerim : Form
    {
        public frmKuluplerim()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        DataSet1TableAdapters.tbl_Kulupler1TableAdapter ds = new DataSet1TableAdapters.tbl_Kulupler1TableAdapter();
        public string tcnoders;
        public string ogrid;
        private void frmKuluplerim_Load(object sender, EventArgs e)
        {
            //Forma ogrenci isim soyisim getirme
            SqlCommand komut = new SqlCommand("select OgrenciAd + ' ' + OgrenciSoyad from tbl_Ogrenciler where OgrenciTC=@p1", bgl.baglanti1());
            komut.Parameters.AddWithValue("@p1", tcnoders);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString();
            }
            bgl.baglanti1().Close();
            //
            // ogrenci ıd getirme
            SqlCommand komut1 = new SqlCommand("select OgrenciId from tbl_Ogrenciler where OgrenciTC=@p1", bgl.baglanti1());
            komut1.Parameters.AddWithValue("@p1", tcnoders);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                ogrid = dr1[0].ToString();
            }
            //Datagride verileri çekme
            dataGridView1.DataSource = ds.kuluplerim(int.Parse(ogrid));
        }
    }
}
