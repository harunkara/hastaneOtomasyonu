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
    public partial class hasta_randevu_görüntüle : Form
    {
        public hasta_randevu_görüntüle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            hastaSayfa hasta_sayfa_form = new hastaSayfa();
            hasta_sayfa_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa anaSayfafrm = new anaSayfa();
            anaSayfafrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                
                
                baglantı.Open();
                string sql = "Select *From hasta_randevu where tc= '" + fonksiyonlar.hastatc.Trim() + "'";
                SqlCommand komut = new SqlCommand(sql, baglantı);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {

                    if (fonksiyonlar.hastatc.ToString()== oku["tc"].ToString())
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = oku["tc"].ToString().Trim();
                        ekle.SubItems.Add(oku["ad"].ToString().Trim());
                        ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                        ekle.SubItems.Add(oku["uzmanlıkalanı"].ToString().Trim());
                        ekle.SubItems.Add(oku["tarih"].ToString().Trim());
                        ekle.SubItems.Add(oku["saat"].ToString().Trim());

                        listView1.Items.Add(ekle);
                    }  
                    
                  
                   
                }
                


                baglantı.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Randevunuz bulunmamaktadır!");
                baglantı.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                
                string arama = "Select * from hasta_randevu where tc='" + fonksiyonlar.hastatc + "'";
                SqlCommand aramakomut = new SqlCommand(arama, baglantı);
                SqlDataAdapter daarama = new SqlDataAdapter(aramakomut);
                DataTable dt = new DataTable();
                daarama.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                   
                    if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) < Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text.Substring(3, 2).ToString().Trim()))
                    {
                        DialogResult durum = MessageBox.Show(" Randevuyu iptal etmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == durum)
                        {
                            string sql = "DELETE from hasta_randevu where tc='" + fonksiyonlar.hastatc + "' and tarih ='" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "'  and saat = '" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "'";
                            SqlCommand silKomutu = new SqlCommand(sql, baglantı);
                            SqlDataReader oku = silKomutu.ExecuteReader();

                          
                            while (oku.Read())
                            {
                                silKomutu.ExecuteNonQuery();
                            }
                            oku.Close();
                            MessageBox.Show("Kayıt Silindi...");
                            


                            string sql1 = "update  doktor_randevu set durum ='" + "BOŞ".ToString().Trim() + "', ad ='" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "', soyad='" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "' ,uzmanlıkalanı= '" + listView1.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "' ,tarih = '" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' ,saat='" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "'  where saat = '" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "' and tarih='" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' and  ad ='" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "' and soyad='" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "' ";
                            SqlDataAdapter da = new SqlDataAdapter(sql1, baglantı);
                            DataTable dt1 = new DataTable();
                            da.Fill(dt1);
                            if (dt1.Rows.Count > 0)
                            {
                                SqlCommand komut = new SqlCommand(sql1, baglantı);

                                komut.Parameters.AddWithValue("@durum", "BOŞ".ToString().Trim());
                                komut.ExecuteNonQuery();
                                baglantı.Close();
                            }
                            listView1.Items.Clear();
                        }
                    }
                   else if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text.Substring(3, 2).ToString().Trim()) && Convert.ToInt32(System.DateTime.Now.Day.ToString()) < Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text.Substring(0, 2).ToString().Trim()))
                    {
                        DialogResult durum = MessageBox.Show(" Randevuyu iptal etmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == durum)
                        {
                            string sql = "DELETE from hasta_randevu where tc='" + fonksiyonlar.hastatc + "' and tarih ='" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "'  and saat = '" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "'";


                            SqlCommand silKomutu = new SqlCommand(sql, baglantı);
                            SqlDataReader oku = silKomutu.ExecuteReader();

                            
                            while(oku.Read())
                            {
                                silKomutu.ExecuteNonQuery();
                            }
                            oku.Close();
                            MessageBox.Show("Kayıt Silindi...");
                            
                            string sql1 = "update  doktor_randevu set durum ='" + "BOŞ".ToString().Trim() + "', ad ='" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "', soyad='" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "' ,uzmanlıkalanı= '" + listView1.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "' ,tarih = '" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' ,saat='" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "'  where saat = '" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "' and tarih='" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' and  ad ='" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "' and soyad='" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "' ";
                            SqlDataAdapter da = new SqlDataAdapter(sql1, baglantı);
                            DataTable dt1 = new DataTable();
                            da.Fill(dt1);
                            if (dt1.Rows.Count > 0)
                            {
                                SqlCommand komut = new SqlCommand(sql1, baglantı);

                                komut.Parameters.AddWithValue("@durum", "BOŞ".ToString().Trim());
                                komut.ExecuteNonQuery();
                                baglantı.Close();
                            }
                            listView1.Items.Clear();
                        }
                    }
                    else if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text.Substring(3, 2).ToString().Trim()) && Convert.ToInt32(System.DateTime.Now.Day.ToString())  == Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text.Substring(0, 2).ToString().Trim()) && Convert.ToInt32(System.DateTime.Now.Hour.ToString()) <= Convert.ToInt32(listView1.SelectedItems[0].SubItems[5].Text.Substring(0, 2).ToString().Trim()))
                    {
                        DialogResult durum = MessageBox.Show(" Randevuyu iptal etmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == durum)
                        {
                            string sql = "DELETE from hasta_randevu where tc='"+fonksiyonlar.hastatc+"' and tarih ='" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "'  and saat = '" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "'";

                            SqlCommand silKomutu = new SqlCommand(sql, baglantı);
                            SqlDataReader oku = silKomutu.ExecuteReader();

                            
                            while (oku.Read())
                            {
                                silKomutu.ExecuteNonQuery();
                            }
                            oku.Close();
                            MessageBox.Show("Kayıt Silindi...");
                            

                            string sql1 = "update  doktor_randevu set durum ='" + "BOŞ".ToString().Trim() + "', ad ='" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "', soyad='" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "' ,uzmanlıkalanı= '" + listView1.SelectedItems[0].SubItems[3].Text.ToString().Trim() + "' ,tarih = '" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' ,saat='" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "'  where saat = '" + listView1.SelectedItems[0].SubItems[5].Text.ToString().Trim() + "' and tarih='" + listView1.SelectedItems[0].SubItems[4].Text.ToString().Trim() + "' and ad ='" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "' and soyad='" + listView1.SelectedItems[0].SubItems[2].Text.ToString().Trim() + "' ";
                            SqlDataAdapter da = new SqlDataAdapter(sql1, baglantı);
                            DataTable dt1 = new DataTable();
                            da.Fill(dt1);
                            if (dt1.Rows.Count > 0)
                            {
                                SqlCommand komut = new SqlCommand(sql1, baglantı);

                                komut.Parameters.AddWithValue("@durum", "BOŞ".ToString().Trim());
                                komut.ExecuteNonQuery();
                                baglantı.Close();
                            }
                            listView1.Items.Clear();
                        }
                    }
                    else
                        MessageBox.Show("Geçmiş Bir Tarihin Randevusu İptal Edilemez!");
                    baglantı.Close();
                }
                
               
                
            }
            catch(Exception)
            {
                
                baglantı.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void hasta_randevu_görüntüle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
