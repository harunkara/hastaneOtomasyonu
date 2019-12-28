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
    public partial class hasta_randevuAl : Form
    {
        public hasta_randevuAl()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void button3_Click(object sender, EventArgs e)
        {
             
            if(comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen Önce Klinik Ve doktor Seçiniz!");
            }
           
            else
                try
                {
                    listView2.Items.Clear();
                    baglantı.Open();
                    string sql = "Select *From doktor_randevu where uzmanlıkalanı ='" + comboBox1.Text.Trim() + "' and tarih = '" + dateTimePicker1.Text + "' and durum='" + "BOŞ" + "'";
                    SqlCommand komut = new SqlCommand(sql, baglantı);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    SqlDataReader oku = komut.ExecuteReader();
                    if (Convert.ToInt32(System.DateTime.Now.Year.ToString()) == Convert.ToInt32(dateTimePicker1.Value.Year.ToString()))
                    {
                        if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(dateTimePicker1.Value.Month.ToString()))
                        {
                            while (oku.Read())
                            {



                                if (comboBox2.SelectedItem.ToString() == (oku["ad"].ToString().Trim() + " " + oku["soyad"].ToString().Trim()) && oku["durum"].ToString().Trim() == "BOŞ")
                                {

                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = oku["ad"].ToString().Trim(); ;
                                    ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                                    ekle.SubItems.Add(oku["uzmanlıkalanı"].ToString().Trim());
                                    ekle.SubItems.Add(oku["tarih"].ToString().Trim());
                                    ekle.SubItems.Add(oku["saat"].ToString().Trim());
                                    ekle.SubItems.Add(oku["durum"].ToString().Trim());

                                    listView2.Items.Add(ekle);

                                }


                            }

                            if (listView2.Items.Count == 0)
                                MessageBox.Show("Bu Tarihte Randevu Yoktur!");

                        }
                        else if (Convert.ToInt32(System.DateTime.Now.Day.ToString()) < Convert.ToInt32(dateTimePicker1.Value.Day.ToString()) && Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(dateTimePicker1.Value.Month.ToString()))
                        {
                            while (oku.Read())
                            {



                                if (comboBox2.SelectedItem.ToString() == (oku["ad"].ToString().Trim() + " " + oku["soyad"].ToString().Trim()) && oku["durum"].ToString().Trim() == "BOŞ")
                                {

                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = oku["ad"].ToString().Trim(); ;
                                    ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                                    ekle.SubItems.Add(oku["uzmanlıkalanı"].ToString().Trim());
                                    ekle.SubItems.Add(oku["tarih"].ToString().Trim());
                                    ekle.SubItems.Add(oku["saat"].ToString().Trim());
                                    ekle.SubItems.Add(oku["durum"].ToString().Trim());

                                    listView2.Items.Add(ekle);

                                }


                            }

                            if (listView2.Items.Count == 0)
                                MessageBox.Show("Bu Tarihte Randevu Yoktur!");

                        }
                        else if (Convert.ToInt32(System.DateTime.Now.Day.ToString()) == Convert.ToInt32(dateTimePicker1.Value.Day.ToString()) && Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(dateTimePicker1.Value.Month.ToString()))
                        {
                            while (oku.Read())
                            {

                                if (Convert.ToInt32(System.DateTime.Now.Hour.ToString()) <= Convert.ToInt32(oku["saat"].ToString().Substring(0, 2)))
                                {
                                    if (comboBox2.SelectedItem.ToString() == (oku["ad"].ToString().Trim() + " " + oku["soyad"].ToString().Trim()) && oku["durum"].ToString().Trim() == "BOŞ")
                                    {

                                        ListViewItem ekle = new ListViewItem();
                                        ekle.Text = oku["ad"].ToString().Trim(); ;
                                        ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                                        ekle.SubItems.Add(oku["uzmanlıkalanı"].ToString().Trim());
                                        ekle.SubItems.Add(oku["tarih"].ToString().Trim());
                                        ekle.SubItems.Add(oku["saat"].ToString().Trim());
                                        ekle.SubItems.Add(oku["durum"].ToString().Trim());

                                        listView2.Items.Add(ekle);

                                    }
                                }

                            }

                            if (listView2.Items.Count == 0)
                                MessageBox.Show("Bu Tarihte Randevu Yoktur!");
                        }
                        else
                            MessageBox.Show("Geçmiş Tarihe Randevu Alınamaz!");
                    }
                    else
                    {
                        MessageBox.Show("Aynı Yıl İçerisinde Randevu Alabilirsiniz!");
                    }






                    baglantı.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Boş Alan Bırakılamaz!");

                    baglantı.Close();
                }
            }






        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            try
            {
                string hasta = "Select *From hasta_randevu where tc ='" + fonksiyonlar.hastatc.Trim() + "' and saat='" + listView2.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' and tarih='" + listView2.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "'";
                SqlCommand hastakomut = new SqlCommand(hasta, baglantı);
                SqlDataAdapter hastada = new SqlDataAdapter(hastakomut);
                DataTable dt2 = new DataTable();
                hastada.Fill(dt2);
                
                    string sql2 = "select *from doktor_randevu where soyad = '" + listView2.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "' AND tarih = '" + listView2.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "' and saat='" + listView2.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "'";
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(sql2, baglantı);
                    da1.Fill(dt1);
                    if (dt2.Rows.Count > 0)
                    {
                        MessageBox.Show("Bu tarih ve Saatte Başka Bir Randevunuz Vardır!");
                    baglantı.Close();
                    }
                    else if (dt1.Rows.Count > 0 && listView2.SelectedItems.Count != 0)
                    {
                               string sql1 = "update  doktor_randevu set durum ='" + "DOLU".ToString().Trim() + "' where soyad='"+ listView2.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "' AND tarih = '" + listView2.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "' and saat='" + listView2.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "'";
                                SqlCommand kmt = new SqlCommand("insert into hasta_randevu (tc,ad,soyad,uzmanlıkalanı,tarih,saat) values('" + fonksiyonlar.hastatc.ToString().Trim() + "','" + listView2.SelectedItems[0].Text.ToString().Trim() + "','" + listView2.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "','" + listView2.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "','" + listView2.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "','" + listView2.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "')", baglantı);
                                kmt.ExecuteNonQuery();

                                SqlCommand komut = new SqlCommand(sql1, baglantı);

                                komut.Parameters.AddWithValue("@durum", "DOLU".ToString().Trim());
                                komut.ExecuteNonQuery();
                                baglantı.Close();
                        MessageBox.Show("Randevunuz Alınmıştır!");
                    listView2.Items.Clear();

                }

                    
            }

            catch (Exception)
            {
                MessageBox.Show("Bir seçim yapmalısınız!");
            }
            
            baglantı.Close();
        }
                    





                

        
    
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randevuAl_Load(object sender, EventArgs e)
        {
            listView2.Select();        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            baglantı.Open();
            string sql = " Select ad,soyad from  doktor_randevu where uzmanlıkalanı = '" + comboBox1.SelectedItem.ToString() + "' group by ad,soyad";
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();




            while (oku.Read())
            {
                if (comboBox2.Items.ToString().Trim() != (oku["ad"].ToString().Trim() + " " + oku["soyad"].ToString().Trim()))
                {
                    comboBox2.Items.Add(oku["ad"].ToString().Trim() + " " + oku["soyad"].ToString().Trim());
                }
            }
            baglantı.Close();

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
                comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaSayfa form = new hastaSayfa();
            form.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa form = new anaSayfa();
            form.Show();
        }
    }
}

