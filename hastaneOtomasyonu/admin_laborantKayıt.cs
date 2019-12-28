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
    public partial class admin_laborantKayıt : Form
    {
        public admin_laborantKayıt()
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
            adminSayfa admin = new adminSayfa();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();

                string sql = "Select  * From laborant_kayıt where tc= '" + textBox1.Text.Trim() + "'";

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
                        SqlCommand kmt = new SqlCommand("insert into laborant_kayıt (tc,ad,soyad,dogumtarihi,cinsiyet,sifre) values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + dateTimePicker1.Text + "','" + comboBox1.GetItemText(comboBox1.SelectedItem) + "','" + textBox4.Text.ToString() + "')", baglantı);


                        kmt.ExecuteNonQuery();
                        baglantı.Close();
                        MessageBox.Show("Kayıt Başarılı");
                    }
                    else
                        MessageBox.Show("Eksik bilgi vardır ve ya TC hatalı!");
                    baglantı.Close();
                }
            }


            catch (Exception)
            {
                MessageBox.Show("Bu TC ile Daha Önce Kayıt Yapılmış");
                baglantı.Close();

            }
            
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
