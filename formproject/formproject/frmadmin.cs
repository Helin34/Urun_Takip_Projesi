using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formproject
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }
           SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;Initial Catalog=dburun;Integrated Security=True");
        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbladmin where Kullanici=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkullanici.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
               frmyonlendirme fr = new frmyonlendirme();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifrenizde hata var yeniden deneyin");

            }
            baglanti.Close();

        }
    }
}
