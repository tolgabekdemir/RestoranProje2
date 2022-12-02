using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProje2
{
    internal class DbYonetimi
    {
        public static SqlConnection BaglantiTestEt()
        {
            string dataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            string InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();

            SqlConnection baglanti = new SqlConnection();
            {
                baglanti.ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;Integrated Security=SSPI;", dataSource, InitialCatalog);

                if (baglanti != null)
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    SqlConnection.ClearPool(baglanti);
                    SqlConnection.ClearAllPools();
                }

                return baglanti;
            }
        }
    }
}
