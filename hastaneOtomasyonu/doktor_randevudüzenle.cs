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
    public partial class doktor_randevudüzenle : Form
    {
        public doktor_randevudüzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {


                baglantı.Open();
                string sql = "Select *From doktor_randevu where tc= '" + fonksiyonlar.doktortc.Trim() + "'and durum='" + "BOŞ" + "'";
                SqlCommand komut = new SqlCommand(sql, baglantı);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {

                    if (fonksiyonlar.doktortc.ToString() == oku["tc"].ToString())
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = (oku["tarih"].ToString().Trim());
                        ekle.SubItems.Add(oku["saat"].ToString().Trim());

                        listView1.Items.Add(ekle);
                        
                    }
                    

                    
                }
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Görüntülenecek randevu yoktur veya hepsi doludur");
                }


                    baglantı.Close();
            }
            catch (Exception)
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

                string arama = "Select * from doktor_randevu where tc='" + fonksiyonlar.doktortc + "' and durum = '"+"BOŞ".ToString().Trim()+"'";
                SqlCommand aramakomut = new SqlCommand(arama, baglantı);
                SqlDataAdapter daarama = new SqlDataAdapter(aramakomut);
                DataTable dt = new DataTable();
                daarama.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) < Convert.ToInt32(listView1.SelectedItems[0].Text.Substring(3, 2).ToString().Trim()))
                    {
                        DialogResult durum = MessageBox.Show(" Randevuyu iptal etmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == durum)
                        {
                            string sql = "DELETE from doktor_randevu where tc='" + fonksiyonlar.doktortc + "' and tarih ='" + listView1.SelectedItems[0].Text.ToString().Trim() + "'  and saat = '" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "'";
                            SqlCommand silKomutu = new SqlCommand(sql, baglantı);
                            SqlDataReader oku = silKomutu.ExecuteReader();

                            MessageBox.Show("Kayıt Silindi...");
                            while (oku.Read())
                            {
                                silKomutu.ExecuteNonQuery();
                            }
                            oku.Close();

                            listView1.Items.Clear();


                        }
                    }
                    else if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(listView1.SelectedItems[0].Text.Substring(3, 2).ToString().Trim()) && Convert.ToInt32(System.DateTime.Now.Day.ToString()) < Convert.ToInt32(listView1.SelectedItems[0].Text.Substring(0, 2).ToString().Trim()))
                    {
                        DialogResult durum = MessageBox.Show(" Randevuyu iptal etmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == durum)
                        {
                            string sql = "DELETE from doktor_randevu where tc='" + fonksiyonlar.doktortc + "' and tarih ='" + listView1.SelectedItems[0].Text.ToString().Trim() + "'  and saat = '" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "'";


                            SqlCommand silKomutu = new SqlCommand(sql, baglantı);
                            SqlDataReader oku = silKomutu.ExecuteReader();

                            MessageBox.Show("Kayıt Silindi...");
                            while (oku.Read())
                            {
                                silKomutu.ExecuteNonQuery();
                            }
                            oku.Close();

                            
                            listView1.Items.Clear();
                        }
                    }
                    else if (Convert.ToInt32(System.DateTime.Now.Month.ToString()) == Convert.ToInt32(listView1.SelectedItems[0].Text.Substring(3, 2).ToString().Trim()) && Convert.ToInt32(System.DateTime.Now.Day.ToString()) == Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text.Substring(0, 2).ToString().Trim()) && Convert.ToInt32(System.DateTime.Now.Hour.ToString()) <= Convert.ToInt32(listView1.SelectedItems[0].SubItems[5].Text.Substring(0, 2).ToString().Trim()))
                    {
                        DialogResult durum = MessageBox.Show(" Randevuyu iptal etmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == durum)
                        {
                            string sql = "DELETE from doktor_randevu where tc='" + fonksiyonlar.doktortc + "' and tarih ='" + listView1.SelectedItems[0].Text.ToString().Trim() + "'  and saat = '" + listView1.SelectedItems[0].SubItems[1].Text.ToString().Trim() + "'";

                            SqlCommand silKomutu = new SqlCommand(sql, baglantı);
                            SqlDataReader oku = silKomutu.ExecuteReader();

                            MessageBox.Show("Kayıt Silindi...");
                            while (oku.Read())
                            {
                                silKomutu.ExecuteNonQuery();
                            }
                            oku.Close();


                            listView1.Items.Clear();
                        }
                    }
                    else
                        MessageBox.Show("Geçmiş Bir Tarihin Randevusu İptal Edilemez!");
                    baglantı.Close();
                }



            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                baglantı.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            doktorSayfa form = new doktorSayfa();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaSayfa form = new anaSayfa();
            form.Show();
        }

        private void doktor_randevudüzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
