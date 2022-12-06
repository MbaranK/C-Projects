using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OkulProjesi
{
    internal class baglanti
    {
        public SqlConnection baglanti1()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OOJK8R6;Initial Catalog=NotSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
