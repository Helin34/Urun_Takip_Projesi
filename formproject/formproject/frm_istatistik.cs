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


namespace formproject
{
    public partial class frm_istatistik : Form
    {
        
        
        public frm_istatistik()
        {
            InitializeComponent();
           

        }
    
       SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;Initial Catalog=dburun;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_istatistik_Load(object sender, EventArgs e)
        {
            //toplam kategori sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tblkatogori",baglanti);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                lbltoplamkategori.Text = dr[""].ToString();

            }

            baglanti.Close();
            //toplam ürün sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from tblurunler", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbltoplamurun.Text = dr2[0].ToString();

            }
            baglanti.Close();
            //en yüksek stoklu Ürün

            baglanti.Open();
            SqlCommand komut5= new SqlCommand("select * from tblurunler where stok =(select Max(stok) from tblurunler)", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label9.Text = dr5["UrunAd"].ToString();

           
            }

            baglanti.Close();
            // en düşük stoklu ürün
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from tblurunler where stok=(select min(stok) from tblurunler)", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label11.Text = dr6["UrunAd"].ToString();
            }
            baglanti.Close();

            //toplam beyaz eşya sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from tblurunler where Katogori = (select ID from tblkatogori where Ad = 'Beyaz Eşya')", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label5.Text = dr3[0].ToString();

            }
            baglanti.Close();
            //toplam beyaz eşya sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(*) from tblurunler where Katogori = (select ID from tblkatogori where Ad = 'Beyaz Eşya')", baglanti);
            SqlDataReader dr4 = komut3.ExecuteReader();
            while (dr4.Read())
            {
                label7.Text = dr4[0].ToString();

            }
            baglanti.Close();
            //laptop toplam kar oranı
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select stok*(satisFiyat -Alisfiyat) from tblurunler where urunAd='Laptop'", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                label11.Text = dr8[0].ToString();

            }
            baglanti.Close();
          




        }

    
    }
}
