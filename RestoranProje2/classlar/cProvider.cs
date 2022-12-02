using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestoranProje2.classlar.tablolar;

namespace RestoranProje2.classlar
{
    class cProvider
    {
        SqlConnection con;
        SqlCommand cmd;

        public cProvider() //Kurucu metot
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection("server=.; Initial Catalog=RestoranTakip;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public List<cUrun> Listele()
        {
            try
            {
                List<cUrun> UrunListesi = new List<cUrun>();
                cmd.CommandText = "Select *From TblUrunler";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cUrun k = new cUrun();
                    k.UrunID = Convert.ToInt32(reader[0].ToString());
                    k.UrunAdi = reader[1].ToString();
                    k.KategoriID = Convert.ToInt32(reader[2].ToString());
                    k.UrunFiyati = Convert.ToInt32(reader[3].ToString());
                    k.Stok= Convert.ToInt32(reader[4].ToString());
                    k.SevkiyatTarihi = reader[5].ToString();
                    UrunListesi.Add(k);
                }

                return UrunListesi;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        

    }
}
