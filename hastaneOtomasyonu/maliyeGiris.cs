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
    public partial class maliyeGiris : Form
    {
        public maliyeGiris()
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

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();

                string sql = "Select  * From maliye_kayıt where tc= '" + tc.Text.Trim() + "' and sifre= '" + sifre.Text.Trim() + "'";

                SqlParameter prm1 = new SqlParameter("tc", tc.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre.Text.Trim());



                SqlCommand komut = new SqlCommand(sql, baglantı);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, baglantı);

                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    this.Hide();
                    baglantı.Close();
                    maliyeSayfa maliye = new maliyeSayfa();
                    maliye.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
                    baglantı.Close();
                }
            }
            catch (Exception)
            {

                baglantı.Close();

            }
        }
    }
}
