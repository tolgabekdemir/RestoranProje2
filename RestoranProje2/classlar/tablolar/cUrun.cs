using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProje2.classlar.tablolar
{
    internal class cUrun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set;}
        public int KategoriID { get; set; }
        public int UrunFiyati { get; set; }
        public int Stok { get; set; }
        public string SevkiyatTarihi { get; set; }
    }
}
