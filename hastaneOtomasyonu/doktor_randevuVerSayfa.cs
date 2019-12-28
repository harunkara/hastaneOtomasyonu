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
    public partial class doktor_randevuVerSayfa : Form
    {
        public doktor_randevuVerSayfa()
        {
            InitializeComponent();
        }
        
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void randevuVerSayfa_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            string sql = "Select *From doktor_kayıt where tc= '" + fonksiyonlar.doktortc.Trim() + "'";
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                textBox1.Text = fonksiyonlar.doktortc.ToString();
                textBox2.Text = oku["ad"].ToString().Trim();
                textBox3.Text = oku["soyad"].ToString().Trim();
                textBox4.Text = oku["uzmanlıkalanı"].ToString().Trim();

                

            }
           


            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktorSayfa hasta = new doktorSayfa();
            hasta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa ana = new anaSayfa();
            ana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            baglantı.Open();

            string sql = "Select  * From doktor_randevu where tc= '" + fonksiyonlar.doktortc + "' and saat = '"+ dateTimePicker3.Text.Trim() + "' and tarih= '"+ dateTimePicker4.Text.Trim() +"'";
            



            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(sql, baglantı);

            da.Fill(dt);
            try
            {
                if (dt.Rows.Count == 1)
                {


                    MessageBox.Show("Randevu zaten vardır");
                    baglantı.Close();
                }
                else
                {
                    if (Convert.ToInt32(System.DateTime.Now.Year.ToString()) == Convert.ToInt32(dateTimePicker4.Value.Year.ToString()))
                    {
                        if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) < Convert.ToInt32(dateTimePicker4.Value.Month.ToString()))
                        {
                            SqlCommand kmt = new SqlCommand("insert into doktor_randevu (tc,ad,soyad,uzmanlıkalanı,tarih,saat,durum) values('" + textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "','" + textBox3.Text.ToString().Trim() + "','" + textBox4.Text.Trim() + "','" + dateTimePicker4.Text.Trim() + "','" + dateTimePicker3.Text.Trim() + "','" + "BOŞ".Trim() + "')", baglantı);


                            kmt.ExecuteNonQuery();
                            baglantı.Close();
                            MessageBox.Show("Kayıt Başarılı");
                        }
                        else if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(dateTimePicker4.Value.Month.ToString()) && Convert.ToInt32(System.DateTime.Now.Day.ToString()) < Convert.ToInt32(dateTimePicker4.Value.Day.ToString()))
                        {
                            SqlCommand kmt = new SqlCommand("insert into doktor_randevu (tc,ad,soyad,uzmanlıkalanı,tarih,saat,durum) values('" + textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "','" + textBox3.Text.ToString().Trim() + "','" + textBox4.Text.Trim() + "','" + dateTimePicker4.Text.Trim() + "','" + dateTimePicker3.Text.Trim() + "','" + "BOŞ".Trim() + "')", baglantı);


                            kmt.ExecuteNonQuery();
                            baglantı.Close();
                            MessageBox.Show("Kayıt Başarılı");
                        }
                        else if(Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(dateTimePicker4.Value.Month.ToString()) && Convert.ToInt32(System.DateTime.Now.Day.ToString()) == Convert.ToInt32(dateTimePicker4.Value.Day.ToString()) && Convert.ToInt32(System.DateTime.Now.Hour.ToString()) < Convert.ToInt32(dateTimePicker3.Value.Hour.ToString()))
                        {
                            SqlCommand kmt = new SqlCommand("insert into doktor_randevu (tc,ad,soyad,uzmanlıkalanı,tarih,saat,durum) values('" + textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "','" + textBox3.Text.ToString().Trim() + "','" + textBox4.Text.Trim() + "','" + dateTimePicker4.Text.Trim() + "','" + dateTimePicker3.Text.Trim() + "','" + "BOŞ".Trim() + "')", baglantı);


                            kmt.ExecuteNonQuery();
                            baglantı.Close();
                            MessageBox.Show("Kayıt Başarılı");
                        }

                        else
                        {
                            MessageBox.Show("Geçmiş Bir Tarihe Randevu Verilemez!");
                        }
                    }
                    else
                        MessageBox.Show("En Fazla aynı yıl içerisinde randevu verilebilir!");
                }


                
            
               

            }
            catch (Exception)
            {
                MessageBox.Show("hata!");
                baglantı.Close();
            }



            baglantı.Close();
        }
    }
}
