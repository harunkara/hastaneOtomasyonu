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
    public partial class hastaBilgiGuncelleme : Form
    {
        public hastaBilgiGuncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source =.; Initial Catalog = doktor; Integrated Security = True");
        private void verigoruntule()
        {

            baglantı.Open();
            string sql = "Select *From hasta_kayıt where tc= '" + fonksiyonlar.hastatc.Trim() + "'";
            SqlCommand komut = new SqlCommand(sql, baglantı);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tc"].ToString().Trim();
                ekle.SubItems.Add(oku["ad"].ToString().Trim());
                ekle.SubItems.Add(oku["soyad"].ToString().Trim());
                ekle.SubItems.Add(oku["dogumtarihi"].ToString().Trim());
                ekle.SubItems.Add(oku["cinsiyet"].ToString().Trim());
                ekle.SubItems.Add(oku["sifre"].ToString().Trim());

                listView1.Items.Add(ekle);

            }
            


            baglantı.Close();
        }
        private void hastaBilgiGuncelleme_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            verigoruntule();
            textBox1.Text = listView1.Items[0].SubItems[1].Text.ToString();
            textBox2.Text = listView1.Items[0].SubItems[2].Text.ToString();
            comboBox1.Text = listView1.Items[0].SubItems[4].Text.ToString();
            textBox6.Text = listView1.Items[0].SubItems[5].Text.ToString();
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           


            listView1.Items.Clear();
            try
            {
                baglantı.Open();
                string güncelle = "update hasta_kayıt  set tc='" + fonksiyonlar.hastatc.Trim() + "' , ad='" + textBox1.Text.Trim() + "' , soyad = '" + textBox2.Text.Trim() + "',cinsiyet ='" + comboBox1.Text.Trim() + "',dogumtarihi ='" + dateTimePicker1.Text.ToString() + "'   , sifre='" + textBox6.Text.Trim() + "' where tc = '" + fonksiyonlar.hastatc + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(güncelle, baglantı);
                da.Fill(dt);
                if (dt.Rows.ToString() == fonksiyonlar.hastatc.Trim())
                {

                    SqlCommand komut = new SqlCommand(güncelle, baglantı);
                    komut.Parameters.AddWithValue("@tc", fonksiyonlar.hastatc.Trim());
                    komut.Parameters.AddWithValue("@ad", textBox1.Text.Trim());
                    komut.Parameters.AddWithValue("@soyad", textBox2.Text.Trim());
                    komut.Parameters.AddWithValue("@dogumtarihi", dateTimePicker1.Text.Trim());
                    komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text.Trim());
                    komut.Parameters.AddWithValue("@sifre", textBox6.Text.Trim());

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme Başarılı");

                }
                

                baglantı.Close();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglantı.Close();

            }
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            hastaSayfa hasta = new hastaSayfa();
            hasta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            anaSayfa anasayfa = new anaSayfa();
            anasayfa.Show();
        }
    }
}
