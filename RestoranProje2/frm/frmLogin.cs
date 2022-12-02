using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoranProje2
{
    public partial class frmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
                string bilgisayarAdi = Dns.GetHostName();
                lblPcAdi.Text = "Bilgisayar Adı: " + bilgisayarAdi;
                string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
                lblIPAdresi.Text = "IP Adresi :" + ipAdresi;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT * FROM TblPersoneller WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";

            //using (SqlCommand cmd = new SqlCommand(sql, DbYonetimi.BaglantiTestEt()))
            //{
            //    cmd.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
            //    cmd.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = txtSifre.Text;

            //    using (SqlDataReader dr = cmd.ExecuteReader())
            //    {
            //        if (dr.Read())
            //        {
            //            var persType = dr["RolID"].ToString();

            //            if (persType == "1")
            //            {
            //                frmAdmin adminForm = new frmAdmin();
            //                adminForm.Show();
            //                this.Hide();
            //            }
            //            else if (persType == "2")
            //            {
            //                frmMudur MudurForm = new frmMudur();
            //                MudurForm.Show();
            //                this.Hide();
            //            }
            //            else
            //            {
            //                frmGason GarsonForm = new frmAdmin();
            //                GarsonForm.Show();
            //                this.Hide();
            //            }
            //        }
            //        else
            //        {
            //            txtKullaniciAdi.Text = "";
            //            txtSifre.Text = "";
            //            MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}

        }
    }
}
