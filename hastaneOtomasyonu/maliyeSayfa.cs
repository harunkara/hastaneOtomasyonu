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
namespace hastaneOtomasyonu
{
    public partial class maliyeSayfa : Form
    {
        public maliyeSayfa()
        {
            InitializeComponent();
        }
        int i = 0;
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void verigoruntule()
        {

            baglantı.Open();
            string sql = "select t2.tc,t2.ad,t2.soyad from hasta_randevu t1, hasta_kayıt t2 where t2.tc=t1.tc";
            
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
            
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tc"].ToString().Trim();
                ekle.SubItems.Add(oku["ad"].ToString().Trim());
                ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                //ekle.SubItems.Add(oku["tarih"].ToString().Trim());
                ekle.SubItems.Add("10".ToString().Trim());
              

                listView1.Items.Add(ekle);

           
           i++;
         
        }
             baglantı.Close();
        }
          
        private void maliyeSayfa_Load(object sender, EventArgs e)
        {
            verigoruntule();
            textBox1.Text = Convert.ToString(i * 10);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaSayfa a = new anaSayfa();
            a.Show();
            this.Visible = false;
        }
    }
}
