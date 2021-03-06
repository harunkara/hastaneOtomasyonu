﻿using System;
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
    public partial class admin_maliyeGoruntuleGuncelle : Form
    {
        public admin_maliyeGoruntuleGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void button5_Click(object sender, EventArgs e)
        {
        
        }
   

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                string güncelle = "update maliye_kayıt  set tc='" + textBox4.Text.Trim() + "' , ad='" + textBox1.Text.Trim() + "' , soyad = '" + textBox2.Text.Trim() + "',cinsiyet ='" + comboBox1.GetItemText(comboBox1.SelectedItem).Trim() + "',dogumtarihi ='" + dateTimePicker1.Text.ToString() + "'   , sifre='" + textBox6.Text.Trim() + "' where tc = '" + textBox4.Text.Trim() + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(güncelle, baglantı);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    SqlCommand komut = new SqlCommand(güncelle, baglantı);
                    komut.Parameters.AddWithValue("@tc", textBox4.Text.Trim());
                    komut.Parameters.AddWithValue("@ad", textBox1.Text.Trim());
                    komut.Parameters.AddWithValue("@soyad", textBox2.Text.Trim());
                    komut.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text.Trim());
                    komut.Parameters.AddWithValue("@sifre", textBox6.Text.Trim());

                    komut.ExecuteNonQuery();
                }


                baglantı.Close();
                MessageBox.Show("Güncelleme Başarılı");
                listView2.Items.Clear();
            }
            catch (Exception)
            {

                baglantı.Close();

            }
            listView2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminSayfa admin = new adminSayfa();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            string sql = "Select *From maliye_kayıt";
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tc"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["dogumtarihi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());

                listView2.Items.Add(ekle);


            }



            baglantı.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
