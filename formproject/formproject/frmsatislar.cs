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
    public partial class frmsatislar : Form
    {
        public frmsatislar()
        {
            InitializeComponent();
        }
       SqlConnection baglanti = new SqlConnection(@"
                Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;
                Initial Catalog=dburun;
                Integrated Security=True");
        DataSet1TableAdapters.tblsatislarTableAdapter ds = new
                DataSet1TableAdapters.tblsatislarTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("execute satıslistesi", baglanti);
            SqlDataAdapter da= new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmsatislar_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from tblurunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            comboBox1.ValueMember = "UrunId";
            comboBox1.DisplayMember = "UrunAd";
            comboBox1.DataSource = dt2;


            
            dataGridView1.DataSource = ds.satislistesi();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ds.satiseklee(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtmusteri.Text), byte.Parse(txtadet.Text), decimal.Parse(txtfiyat.Text), decimal.Parse(txttoplam.Text), DateTime.Parse(msktarih.Text));
            MessageBox.Show("satış başarıyla yapıldı");
               

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double adet, fiyat, toplam;
            adet = Convert.ToDouble(txtadet.Text);
            fiyat = Convert.ToDouble(txtfiyat.Text);
            toplam = adet * fiyat;
            txttoplam.Text = toplam.ToString();


        }
    }
}
