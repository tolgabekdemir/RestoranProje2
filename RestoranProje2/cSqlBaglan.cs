using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProje2
{
    internal class cMain
    {
        private static string SQLConnectionString = @"Data Source=.;Initial Catalog = RestoranTakip; Integrated Security = True";
        private static SqlConnection con = new SqlConnection();
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand com = new SqlCommand();

        public static void Baglanti()
        {
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static object Command(string query)
        {
            object obj;
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            obj = com.ExecuteScalar();
            return obj;
        }

        public static DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            com.Connection = con; // SqlCommand
            com.CommandText = query; // SqlCommand
            da.SelectCommand = com; // // SqlCommand'ın bir select sorgusu olduğunu belirtiyoruz.
            da.Fill(dt);
            return dt;
        }

    }
}
