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
    public partial class hasta_raporGor : Form
    {
        public hasta_raporGor()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hasta_raporGor_Load(object sender, EventArgs e)
        {

            baglantı.Open();
            string sql = "Select teshis From doktor_rapor where tc='"+fonksiyonlar.hastatc+"'";
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["teshis"].ToString();
               

                listView1.Items.Add(ekle);


            }



            baglantı.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaSayfa fha = new hastaSayfa();
            fha.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa fhawe = new anaSayfa();
            fhawe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaSayfa form = new hastaSayfa();
            form.Show();
        }
    }
}
