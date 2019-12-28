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
    public partial class adminSayfa : Form
    {
        public adminSayfa()
        {
            InitializeComponent();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_doktorKayıt doktorkaydı = new admin_doktorKayıt();
            doktorkaydı.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_maliyeKayıt maliye = new admin_maliyeKayıt();
            maliye.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_laborantKayıt lab = new admin_laborantKayıt();
            lab.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_doktorGoruntuleGuncelle doktor = new admin_doktorGoruntuleGuncelle();
            doktor.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_hastaBilgiSayfa hasta = new admin_hastaBilgiSayfa();
            hasta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_maliyeGoruntuleGuncelle maliye = new admin_maliyeGoruntuleGuncelle();
            maliye.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_laborantGoruntuleGuncelle lab = new admin_laborantGoruntuleGuncelle();
            lab.Show(); 
        }

        private void adminSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_maliyeKayıt maliye = new admin_maliyeKayıt();
            maliye.Show();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_laborantKayıt lab = new admin_laborantKayıt();
            lab.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_doktorKayıt doktorkaydı = new admin_doktorKayıt();
            doktorkaydı.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_hastaBilgiSayfa hasta = new admin_hastaBilgiSayfa();
            hasta.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_maliyeGoruntuleGuncelle maliye = new admin_maliyeGoruntuleGuncelle();
            maliye.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_laborantGoruntuleGuncelle lab = new admin_laborantGoruntuleGuncelle();
            lab.Show(); 
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_doktorGoruntuleGuncelle doktor = new admin_doktorGoruntuleGuncelle();
            doktor.Show();
        }

        private void btnAnaSayfa_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }
    }
}
