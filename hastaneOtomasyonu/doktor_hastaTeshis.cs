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
    public partial class doktor_hastaTeshis : Form
    {
        public doktor_hastaTeshis()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> doktorrapordavarolanhasta = new List<String>();
            doktorrapordavarolanhasta.Clear();

            try
            {
                baglantı.Open();

                string sql1 = "Select tc from doktor_randevu";
                SqlCommand komut1 = new SqlCommand(sql1, baglantı);
                SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                SqlDataReader oku1 = komut1.ExecuteReader();
                while (oku1.Read())
                {
                    doktorrapordavarolanhasta.Add(oku1["tc"].ToString().Trim());
                }



                baglantı.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
            int y = doktorrapordavarolanhasta.Count;
           
                
                
                    try
                    {
                baglantı.Open();
                for (int r = 0; r < y; r++)
                {

                    if (doktorrapordavarolanhasta[r].ToString() == listView1.SelectedItems[0].ToString().Trim())
                    {
                        MessageBox.Show("hastanın zaten teshisi vardır");
                    }
                    else
                    {
                        if ((textBox2.Text != "" && comboBox1.Text == "") || (textBox2.Text == "" && comboBox1.Text != "")) {
                            SqlCommand kmt = new SqlCommand("insert into doktor_rapor(tc,ad,soyad,teshis,lab) values('" + listView1.SelectedItems[0].Text.ToString().Trim() + "','" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "','" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "','" + comboBox1.GetItemText(comboBox1.SelectedItem).Trim() + "')", baglantı);
                            kmt.ExecuteNonQuery();
                            baglantı.Close();
                            MessageBox.Show("Teşhis Koyuldu!");
                            listView1.Items.Clear();
                        }
                        else
                            MessageBox.Show("Nottaki olaya dikkat edin");
                    }

                }
                    }
                    catch (Exception ex)
                    {
                       
                        baglantı.Close();
                    }
            finally
            {

            }
                
                  
            
    
        }

                

        

        private void button3_Click(object sender, EventArgs e)
        {
           
            listView1.Items.Clear();
            string ad = "", soyad = "";
            try
            {
                baglantı.Open();
                string sql3 = "Select ad,soyad From doktor_randevu where tc='" + fonksiyonlar.doktortc + "'";
                SqlCommand komut3 = new SqlCommand(sql3, baglantı);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                SqlDataReader reader3 = komut3.ExecuteReader();
                while (reader3.Read())
                {
                    ad = reader3["ad"].ToString().Trim();
                    soyad = reader3["soyad"].ToString().Trim();
                }

                baglantı.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
            
            List<string> hastaListesi = new List<String>();
            hastaListesi.Clear();
            try
            {
                baglantı.Open();
                string sql2 = "Select tc From hasta_randevu where ad='" + ad + "'and soyad='" + soyad + "'";
                SqlCommand komut2 = new SqlCommand(sql2, baglantı);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                SqlDataReader oku5 = komut2.ExecuteReader();
                while (oku5.Read())
                {
                    hastaListesi.Add(oku5["tc"].ToString().Trim());

                }


                baglantı.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
            int t = hastaListesi.Count;         
            for (int y = 0; y < t; y++)
            {
                try
                {
                    baglantı.Open();

                    string sql1 = "Select ad,soyad From hasta_kayıt where tc='" + hastaListesi[y] + "'"; 
                    SqlCommand komut1 = new SqlCommand(sql1, baglantı);
                    SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                    SqlDataReader oku1 = komut1.ExecuteReader();

                    while (oku1.Read())
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = (hastaListesi[y].ToString().Trim());
                        ekle.SubItems.Add(oku1["ad"].ToString().Trim());
                        ekle.SubItems.Add(oku1["soyad"].ToString().Trim());
                        listView1.Items.Add(ekle);
                    }

                    baglantı.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglantı.Close();
                }
            }
            
        }


        private void hastaTeshis_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listView2.Items.Clear();
            string ad = "", soyad = "";
            try
            {
                baglantı.Open();
                string sql3 = "Select ad,soyad From doktor_randevu where tc='" + fonksiyonlar.doktortc + "'";
                SqlCommand komut3 = new SqlCommand(sql3, baglantı);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                SqlDataReader reader3 = komut3.ExecuteReader();
                while (reader3.Read())
                {
                    ad = reader3["ad"].ToString().Trim();
                    soyad = reader3["soyad"].ToString().Trim();
                }

                baglantı.Close();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }

            List<string> hastaListesi = new List<String>();
            hastaListesi.Clear();
            try
            {
                baglantı.Open();
                string sql2 = "Select tc From hasta_randevu where ad='" + ad + "'and soyad='" + soyad + "'";
                SqlCommand komut2 = new SqlCommand(sql2, baglantı);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                SqlDataReader oku5 = komut2.ExecuteReader();
                while (oku5.Read())
                {
                    hastaListesi.Add(oku5["tc"].ToString().Trim());

                }


                baglantı.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();
            }
            int t = hastaListesi.Count;
            for (int y = 0; y < t; y++)
            {
                try
                {
                    baglantı.Open();

                    string sql1 = "Select lab From doktor_rapor where tc='" + hastaListesi[y] + "'";
                    SqlCommand komut1 = new SqlCommand(sql1, baglantı);
                    SqlDataAdapter da1 = new SqlDataAdapter(komut1);
                    SqlDataReader oku1 = komut1.ExecuteReader();

                    while (oku1.Read())
                    {
                        ListViewItem ekle = new ListViewItem();
                        if (oku1["lab"].ToString().Trim() != "")
                        {
                                 ekle.Text = (hastaListesi[y].ToString().Trim());
                                ekle.SubItems.Add(oku1["lab"].ToString().Trim());
                                listView2.Items.Add(ekle);
                        }
                    }

                    baglantı.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglantı.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            try
            {
                baglantı.Open();
                if (textBox1.Text != "")
                {
                    string güncelle = "update doktor_rapor set teshis='" + textBox1.Text.ToString().Trim() + "'where tc='" + listView2.SelectedItems[0].Text.ToString().Trim() + "'";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(güncelle, baglantı);
                    da.Fill(dt);
                    SqlCommand komut = new SqlCommand(güncelle, baglantı);
                    komut.Parameters.AddWithValue("@teshis", textBox1.Text.ToString());
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Teşhis Konuldu");
                    listView2.Items.Clear();
                    baglantı.Close();
                }
                else
                {
                    MessageBox.Show("Teşhis bölümünü doldurunuz");
                    baglantı.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz");
                baglantı.Close();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktorSayfa das = new doktorSayfa();
            das.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa assa =new anaSayfa();
            assa.Show();
        }
    }
}
