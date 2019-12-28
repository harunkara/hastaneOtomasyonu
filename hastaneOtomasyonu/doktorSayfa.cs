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
    public partial class doktorSayfa : Form
    {
        public doktorSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa ana = new anaSayfa();
            ana.Show();
        }

        private void btnRandevuSaat_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktor_randevuVerSayfa ran = new doktor_randevuVerSayfa();
            ran.Show();
        }

        private void doktorSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktor_hastaTeshis hs = new doktor_hastaTeshis();
            hs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktorHastalarımınTeshisleri dht = new doktorHastalarımınTeshisleri();
            dht.Show();
        }

        private void btnRandevuGorun_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktor_randevudüzenle form = new doktor_randevudüzenle();
            form.Show();
        }

        private void btnLabSonucları_Click(object sender, EventArgs e)
        {

        }
    }
}
