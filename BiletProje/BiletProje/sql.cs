using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletProje
{
    internal class sql
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OOJK8R6;Initial Catalog=BiletProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
