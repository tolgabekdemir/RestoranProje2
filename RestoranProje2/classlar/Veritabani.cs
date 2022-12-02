using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProje2
{
    internal class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=asus;Initial Catalog=RestoranTakip;Integrated Security=True");

    }
}
