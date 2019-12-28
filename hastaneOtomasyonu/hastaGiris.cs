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

namespace hastaneOtomasyonu
{
    public partial class hastaGiris : Form
    {
        public hastaGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        public static void anasayfa()
        {
            
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            fonksiyonlar.hastatc = tc.Text.Trim();
            try
            {
                baglantı.Open();

                string sql = "Select  * From hasta_kayıt where tc= '" + tc.Text.Trim() + "' and sifre= '" + sifre.Text.Trim() + "'";

                SqlParameter prm1 = new SqlParameter("tc", tc.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre.Text.Trim());



                SqlCommand komut = new SqlCommand(sql, baglantı);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, baglantı);

                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    this.Hide();
                    baglantı.Close();
                    hastaSayfa hasta_form = new hastaSayfa();
                    hasta_form.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
                    baglantı.Close();
                }
            }
            catch (Exception)
            {

                baglantı.Close();

            }


        }

        private void hastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaKayıt hastakaydı = new hastaKayıt();
            hastakaydı.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
