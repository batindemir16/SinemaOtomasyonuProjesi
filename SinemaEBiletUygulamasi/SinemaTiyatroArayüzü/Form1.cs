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

namespace SinemaTiyatroArayüzü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        LogKayit logKayit = new LogKayit();

        public static string calisangonder;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "False";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "True";
        }

        sqlBaglantisi baglantisi = new sqlBaglantisi();
       // SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=gorselproje;Integrated Security=True;TrustServerCertificate=True");

        int hataligirissayisi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //  baglanti.Open();
                string sorgu = "Select * From Calisanlar where CalisanGirisId=@p1 and CalisanSifre=@p2 and CalisanKonum=@p3";
                SqlCommand cmd = new SqlCommand(sorgu, baglantisi.baglanti());
                cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                cmd.Parameters.AddWithValue("@p3", label4.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (label4.Text == "True")
                    {
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                        logKayit.AddLog("Info","Yönetici Giriş Yaptı.","YöneticiGiriş");
                    }
                    if (label4.Text == "False")
                    {
                        string ad = reader["CalisanAd"].ToString();
                        string soyad = reader["CalisanSoyad"].ToString();
                        label5.Text = ad + " " + soyad;
                        calisangonder = label5.Text;

                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        logKayit.AddLog("Info","Çalışan Giriş Yaptı.","ÇalışanGiriş");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Çalışan giriş id veya şifre veya çalışan tipi!");
                    hataligirissayisi++;
                    logKayit.AddLog("Uyarı", "Giriş Hatası Yapıldı","GirişHatası");
                    if (hataligirissayisi == 3)
                    {
                        MessageBox.Show("Çok fazla hatalı giriş yapıldı. Program kapatılıyor.");
                        logKayit.AddLog("Uyarı", "Çoklu Giriş Hatası Yapıldı.Program Kapatıldı","ÇokluGirişHaatsı");
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message,"GirişHatası");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }


        }
            
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {           
            
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if(checkBox1.CheckState==CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }


    }
}

