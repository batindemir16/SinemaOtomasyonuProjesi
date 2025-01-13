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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SinemaTiyatroArayüzü
{
    public partial class FormSeansEkleme : Form
    {
        public FormSeansEkleme()
        {
            InitializeComponent();
        }

        LogKayit logKayit = new LogKayit();
        private void FormSeansEkleme_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            dateTimePicker1.MinDate = bugun;
            salongetir();
        }

        private void btnseansagit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten buradasın");
        }

        private void btnformcalisanagit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnfilmegit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        sqlBaglantisi baglantisi = new sqlBaglantisi();

        private void btnyenile_Click(object sender, EventArgs e)
        {
            yenile();
        }

        void yenile()
        {
            cmbsalonlar.SelectedItem = null;
            cmbdolusaatler.Items.Clear();
            txttarih.Text = "";
            txtfilmler.Text = "";
            lblsecilensaat.Text = "";
            SeansSaatPaneli.Controls.Clear();
        }

        void seanskontrol()
        {
            SeansSaatPaneli.Controls.Clear();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rdobtn = new RadioButton();
                    rdobtn.Width = 60;
                    rdobtn.CheckedChanged += new EventHandler(SeansSaatler);
                    if (j == 0)
                    {
                        rdobtn.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rdobtn.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cmbdolusaatler.Items.Contains(rdobtn.Text))
                    {
                        rdobtn.Visible = false;
                    }
                    SeansSaatPaneli.Controls.Add(rdobtn);
                }
            }
        }

        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton items in SeansSaatPaneli.Controls) 
            {
                if (items.Checked)
                {
                    lblsecilensaat.Text = items.Text.ToString();
                } 
            }
        }
        void salongetir()
        {
            try
            {
                string sorgu = "Select * From SinemaFilm ORDER BY YayinlanacakSalon ASC";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbsalonlar.Items.Add(oku["YayinlanacakSalon"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        private void cmbsalonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "Select * From SinemaFilm WHERE YayinlanacakSalon = @y1";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                komut.Parameters.AddWithValue("@y1", cmbsalonlar.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string film = oku["FilmAdi"].ToString();
                    txtfilmler.Text = film;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        void tarihdegercevirme()
        {
            string tarih = dateTimePicker1.Value.ToShortDateString();
            txttarih.Text = tarih;
        }

        private void btnseanssec_Click(object sender, EventArgs e)
        {
            tarihdegercevirme();
            try
            {
                string sorgu = "Select DISTINCT SeansSaat From SeansKontrol WHERE SeansTarih = @tarih AND SalonAdi = @salonadi";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                komut.Parameters.AddWithValue("@tarih", txttarih.Text);
                komut.Parameters.AddWithValue("@salonadi", cmbsalonlar.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbdolusaatler.Items.Add(oku["SeansSaat"].ToString());
                }

                seanskontrol();              

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
            
        }

        void seansekle()
        {
            try
            {
                string sorgu = "Insert INTO SeansKontrol(FilmAdi, SeansTarih, SeansSaat, SalonAdi) values (@filmadi, @seanstarihi, @seanssaati, @salonadi)";
                SqlCommand ekle = new SqlCommand(sorgu, baglantisi.baglanti());
                ekle.Parameters.AddWithValue("@filmadi", txtfilmler.Text);
                ekle.Parameters.AddWithValue("@seanstarihi", txttarih.Text);
                ekle.Parameters.AddWithValue("@seanssaati", lblsecilensaat.Text);
                ekle.Parameters.AddWithValue("@salonadi", cmbsalonlar.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Seans Ekleme İşlemi başarılı oldu");
                logKayit.AddLog("Info", "Seans Ekleme İşlemi Yapıldı", "SeansEkleme");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        private void btnseansekle_Click(object sender, EventArgs e)
        {
            seansekle();
        }
    }
}
