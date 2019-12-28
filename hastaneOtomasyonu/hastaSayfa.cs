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
    public partial class hastaSayfa : Form
    {
        public hastaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaBilgiGuncelleme bilgi = new hastaBilgiGuncelleme();
            bilgi.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            hasta_randevuAl ran = new hasta_randevuAl();
            ran.Show();
         
        }

        private void btnRandevuGunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            hasta_randevu_görüntüle form = new hasta_randevu_görüntüle();
            form.Show();
        }

        private void kryptonHeader2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLabSonuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            hasta_raporGor form = new hasta_raporGor();
            form.Show();
        }
    }
}
