using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneOtomasyonu
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

       

        private void anaSayfa_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            adminGiris admin = new adminGiris();
            admin.Show();
        }

        private void btnDoktor_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            doktorGiris doktor = new doktorGiris();
            doktor.Show();
        }

        private void btnHasta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            hastaGiris hastagirisi = new hastaGiris();
            hastagirisi.Show();
        }

        private void btnLaboratuar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            laborantGiris lab = new laborantGiris();
            lab.Show();
        }

        private void btnMaliye_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            maliyeGiris maliye = new maliyeGiris();
            maliye.Show();
        }
    }
}
