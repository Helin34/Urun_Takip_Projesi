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
    public partial class btnform : Form
    {
        SqlConnection baglanti = null;


        public btnform()
        {
            InitializeComponent();
            baglanti = new SqlConnection(@"
                Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;
                Initial Catalog=dburun;
                Integrated Security=True");
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblkatogori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblkatogori (Ad) Values (@p1) ", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtkategori.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategoriniz Başarılı Bir şekilde eklendi");


        }

        private void btnform_Load(object sender, EventArgs e)
        {
            btnlist_Click(sender, e);
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tblkatogori where Ad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtkategori.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("delete from tblkatogori where Id=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", txtid.Text);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleştirildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Silinemedi.");
             
            }



        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("update tblkatogori set Ad=@p1 where Id=@p2", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtkategori.Text);
            komut4.Parameters.AddWithValue("@p2", txtid.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori güncelleme işlemi başarılı bir şekilde gerçekleştirildi");



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;Initial Catalog=dburun;Integrated Security=True
//CRUD --> Create Read Update Delete Search 
