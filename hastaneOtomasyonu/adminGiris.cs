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
    public partial class adminGiris : Form
    {
        public adminGiris()
        {
            InitializeComponent();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {

            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            if (tc.Text == "1907" && sifre.Text == "admin")
            {
                this.Hide();
                adminSayfa admin = new adminSayfa();
                admin.Show();


            }
            else
                MessageBox.Show("Tc veya sifre yanlış!!!");
        }

        private void adminGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaGiris_Click_1(object sender, EventArgs e)
        {
            if (tc.Text == "admin" && sifre.Text == "ttnet")
            {
                this.Hide();
                adminSayfa admin = new adminSayfa();
                admin.Show();


            }
            else
                MessageBox.Show("Tc veya sifre yanlış!!!");
        }

        private void btnAnaSayfa_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa form = new anaSayfa();
            form.Show();
        }
    }
}
