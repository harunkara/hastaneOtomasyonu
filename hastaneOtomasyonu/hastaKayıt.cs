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
    public partial class hastaKayıt : Form
    {
        public hastaKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaGiris hastagirisi = new hastaGiris();
            hastagirisi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();

                string sql = "Select  * From hasta_kayıt where tc= '" + textBox1.Text.Trim() + "'";

                SqlParameter prm1 = new SqlParameter("tc", textBox1.Text.Trim());




                SqlCommand komut = new SqlCommand(sql, baglantı);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, baglantı);

                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    MessageBox.Show("Bu TC ile bir kayıt zaten vardır");
                    baglantı.Close();
                    baglantı.Open();



                }



                else
                {
                    if (textBox1.Text.Length == 11 && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                    {
                        SqlCommand kmt = new SqlCommand("insert into hasta_kayıt (tc,ad,soyad,dogumtarihi,cinsiyet,sifre) values('" + textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "','" + textBox3.Text.ToString().Trim() + "','" + dateTimePicker1.Text.Trim() + "','" + comboBox1.GetItemText(comboBox1.SelectedItem).Trim() + "','" + textBox4.Text.ToString().Trim() + "')", baglantı);


                        kmt.ExecuteNonQuery();
                        baglantı.Close();
                        MessageBox.Show("Kayıt Başarılı");
                    }
                    else
                        MessageBox.Show("Eksik bilgi vardır veya TC hatalı!");
                    baglantı.Close();
                }
            }


            catch (Exception)
            {
                MessageBox.Show("Bu TC ile Daha Önce Kayıt Yapılmış");
                baglantı.Close();

            }

           
        }

        private void hastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            hastaGiris hasta = new hastaGiris();
            hasta.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
