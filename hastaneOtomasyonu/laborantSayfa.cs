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
    public partial class laborantSayfa : Form
    {
        public laborantSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        public void verigoruntule()
        {
           


            baglantı.Open();
            string sql = "select * from doktor_rapor where lab !='"+""+"'";

            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
              
                if (oku["lab"].ToString().Trim() != "")
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["tc"].ToString().Trim();
                    ekle.SubItems.Add(oku["lab"].ToString().Trim());
                    listView2.Items.Add(ekle);
                }
              
                //ekle.Text = oku["tc"].ToString().Trim();
               // ekle.SubItems.Add(oku["ad"].ToString().Trim());
               // ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                //ekle.SubItems.Add(oku["tarih"].ToString().Trim());
                //ekle.SubItems.Add("10".ToString().Trim());


              


                

            }
            baglantı.Close();
            
        }

    
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void laborantSayfa_Load(object sender, EventArgs e)
        {
           
        }
       
        
        
      

        private void laborantSayfa_Load_1(object sender, EventArgs e)
        {
            verigoruntule();
        }

        private void label3_Click(object sender, EventArgs e)
        {   

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();

                string sql = "update doktor_rapor set lab ='" + comboBox1.Text.ToString().Trim() + "' where tc ='" + listView2.SelectedItems[0].Text.ToString().Trim() + "'";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, baglantı);

                da.Fill(dt);


                if (dt.Rows.Count >0)
                {

                    SqlCommand komut = new SqlCommand(sql, baglantı);
                    komut.Parameters.AddWithValue("@lab",comboBox1.Text.ToString().Trim());
                    komut.ExecuteNonQuery();
                    MessageBox.Show("tahlil sonuçları gönderilmiştir");
                }
                MessageBox.Show("tahlil sonuçları gönderilmiştir");
               
                baglantı.Close();
                listView2.Items.Clear();
                this.Hide();
                laborantSayfa form = new laborantSayfa();
                form.Show();
                    


            }
            


            catch (Exception ex)
            {
                MessageBox.Show("Hasta Seçiniz!");
                baglantı.Close();

            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa form = new anaSayfa();
            form.Show();
        }
    }
}
          
      

