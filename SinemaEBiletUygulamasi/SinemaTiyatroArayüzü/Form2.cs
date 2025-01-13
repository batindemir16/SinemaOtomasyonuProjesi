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
using System.Data.SqlClient;

namespace SinemaTiyatroArayüzü
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        LogKayit logKayit = new LogKayit();

        sqlBaglantisi baglantisi = new sqlBaglantisi();
        void filmgetir()
        {
            try
            {
                string sorgu = "Select * From SinemaFilm ORDER BY FilmAdi ASC";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbFilmAdi.Items.Add(oku["FilmAdi"].ToString());
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

        private void Form2_Load(object sender, EventArgs e)
        {
            filmgetir();
        }

        private void btnfilmisec_Click(object sender, EventArgs e)
        {
            if (cmbFilmAdi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen filmi seçiniz!");
            }
            else
            {
                Form6 form6 = new Form6();
                form6.filmadi = cmbFilmAdi.Text;
                form6.salon = txtsalon.Text;
                form6.ShowDialog();
            }
        }

        private void cmbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "Select * From SinemaFilm WHERE FilmAdi = @t1";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                komut.Parameters.AddWithValue("@t1", cmbFilmAdi.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string salon = oku["YayinlanacakSalon"].ToString();
                    txtsalon.Text = salon;
                    string vizyontarihi = oku["VizyonTarihi"].ToString();
                    txtvizyontarihi.Text = vizyontarihi; 
                    string filmsuresi = oku["FilmSuresi"].ToString();
                    txtfilmsuresi.Text = filmsuresi; 
                    string filmturu = oku["FilmTuru"].ToString();
                    txtfilmturu.Text = filmturu; 
                    string yerlimi = oku["FilmYerli"].ToString();
                    lblyerlimi.Text = yerlimi;
                    if (lblyerlimi.Text == "True")
                    {
                        txtyerlimi.Text = "Yerli";
                    }
                    if (lblyerlimi.Text == "False")
                    {
                        txtyerlimi.Text = "Yabancı";
                    }
                    string yonetmen = oku["Yonetmen"].ToString();
                    txtyonetmen.Text = yonetmen;
                    string detay = oku["FilmDetayi"].ToString();
                    txtdetay.Text = detay;
                    string afisyolu = oku["FilmAfisi"].ToString();
                    txtafisyolu.Text = afisyolu;
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

        private void txtafisyolu_TextChanged(object sender, EventArgs e)
        {
            string filmafis = txtafisyolu.Text;
            pictureBox1.ImageLocation = filmafis;
        }
    }
}
