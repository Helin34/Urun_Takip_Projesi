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
    public partial class frm : Form
    {
        SqlConnection baglanti = null;
        public frm()
        {
            InitializeComponent();
            baglanti = new SqlConnection(@"
                Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;
                Initial Catalog=dburun;
                Integrated Security=True");
        }
        private void txtkategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select urunId, urunAd,stok,Alisfiyat,satisFiyat,Ad,Katogori from tblurunler inner join tblkatogori on tblurunler.Katogori = tblkatogori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Katogori"].Visible = false;

            button1_Click(sender, e);
        }

        private void frm_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from tblkatogori", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt2;
            baglanti.Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into tblurunler(urunAd,stok,Alisfiyat,satisFiyat,Katogori) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut3.Parameters.AddWithValue("@p1", txtad.Text);
            komut3.Parameters.AddWithValue("@p2", numericUpDown1.Text);
            komut3.Parameters.AddWithValue("@p3", txtalis.Text);
            komut3.Parameters.AddWithValue("@p4", txtsatis.Text);
            komut3.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut3.ExecuteNonQuery();
             baglanti.Close();
            MessageBox.Show("Ürün Kaydı Başarılı Bir Şekilde Gerçekleşti.");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("delete from tblurunler where UrunId=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtııd.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İstediğiniz Ürünün silme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("update tblurunler set urunAd=@p1,stok=@p2,Alisfiyat=@p3,satisFiyat=@p4,Katogori=@p5 where UrunId=@p6", baglanti);
            komut5.Parameters.AddWithValue("@p1", txtad.Text);
            komut5.Parameters.AddWithValue("@p2", numericUpDown1.Value);
            komut5.Parameters.AddWithValue("@p3", decimal.Parse(txtalis.Text));
            komut5.Parameters.AddWithValue("@p4", decimal.Parse(txtsatis.Text));
            komut5.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut5.Parameters.AddWithValue("@p6", txtııd.Text);
            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Bilgileri Başarıyla Güncellendi", "Güncelleme", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            
            txtııd.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown1.Value = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            txtalis.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtsatis.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            txtııd.Text = "";
            txtad.Text = "";
            numericUpDown1.Value = 0;
            txtalis.Text = "";
            txtsatis.Text = "";
            comboBox1.SelectedValue = comboBox1.ValueMember.First();
        }
    }
}
