using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formproject
{
    public partial class frmmusteri : Form
    {
        public frmmusteri()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        DataSet1TableAdapters.tblmusteriTableAdapter tb = new DataSet1TableAdapters.tblmusteriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = tb.MusteriListesi();

            //data 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb.musteriekle(txtad.Text, txtsoyad.Text, txtsehir.Text, decimal.Parse(txtbakiye.Text));
            MessageBox.Show("Müşteri sisteme kaydedildi");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb.Musterisil(int.Parse(txtid.Text));
            MessageBox.Show("Müşteri sistemden silindi");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsoyad.Text =dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtbakiye.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb.musteriguncelle(txtad.Text, txtsoyad.Text, txtsehir.Text, decimal.Parse(txtbakiye.Text), int.Parse(txtid.Text));
            MessageBox.Show("müşteri bilgileri güncellendi");
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (rdbad.Checked == true)
            {
                dataGridView1.DataSource = tb.adagorelistele(txtaranacak.Text);

            }
            if(rdbsoyad.Checked==true)
            {
                dataGridView1.DataSource = tb.soyadagorelistele(txtaranacak.Text);
            }
            if (rdbsehir.Checked == true)
            {
                dataGridView1.DataSource = tb.sehiregorelistele(txtaranacak.Text);
            }
        }
    }
}
