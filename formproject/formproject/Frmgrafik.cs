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
    public partial class Frmgrafik : Form
    {
        public Frmgrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-MFSA08GG\MYDATABASESERVER;Initial Catalog=dburun;Integrated Security=True");

        private void Frmgrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut= new SqlCommand("select Ad, count(*) from tblurunler inner join tblkatogori on tblurunler.Katogori = tblkatogori.ID Group by Ad",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Kategori"].Points.AddXY(dr[0],dr[1]);
            }
            baglanti.Close();

        }
    }
}
