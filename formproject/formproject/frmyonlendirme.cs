using System;
using System.Windows.Forms;

namespace formproject
{
    public partial class frmyonlendirme : Form
    {
        public frmyonlendirme()
        {
            InitializeComponent();
        }

        private void frmyonlendirme_Load(object sender, EventArgs e)
        {

        }

        private void pnlkategori_Click(object sender, EventArgs e)
        {
            btnform frm = new btnform();
            frm.Show();
        }

        private void pnlistatistik_Click(object sender, EventArgs e)
        {
            frm_istatistik frm = new frm_istatistik();
            frm.Show();
        }

        private void pnlgrafikk_Click(object sender, EventArgs e)
        {
            Frmgrafik fr = new Frmgrafik();
            fr.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmadmin fr = new frmadmin();
            fr.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frm fr = new frm();
            fr.Show();
        }
    }
}
