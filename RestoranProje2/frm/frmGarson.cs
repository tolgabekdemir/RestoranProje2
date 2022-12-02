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
using RestoranProje2.classlar.tablolar;
using RestoranProje2.classlar;

namespace RestoranProje2.frm
{
    public partial class frmGarson : Form
    {
        cProvider kp = new cProvider();
        public frmGarson()
        {
            InitializeComponent();
        }
        void Listele() //Datagrid listeleme işlemi için metot. 
        {
            dgUrunler.DataSource = kp.Listele();
        }
        private void frmGarson_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
