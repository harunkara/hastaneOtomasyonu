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
    public partial class doktorHastalarımınTeshisleri : Form
    {
        public doktorHastalarımınTeshisleri()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");

        private void doktorHastalarımınTeshisleri_Load(object sender, EventArgs e)
        {

            baglantı.Open();
            string sql = "Select tc,teshis From doktor_rapor";
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tc"].ToString();
                ekle.SubItems.Add(oku["teshis"].ToString());
                listView1.Items.Add(ekle);
            }



            baglantı.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktorSayfa ftt = new doktorSayfa();
            ftt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa hha = new anaSayfa();
            hha.Show();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
