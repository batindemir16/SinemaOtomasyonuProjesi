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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        LogKayit logKayit = new LogKayit();

        sqlBaglantisi baglantisi = new sqlBaglantisi();
       // SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=gorselproje;Integrated Security=True;TrustServerCertificate=True");
       
        void yenile()
        {
            textBoxid.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            txtvizyontarihi.Text = "";
            textBox3.Text = "";
            txtfilmdetayı.Text = "";
            label8.Text = "";
            txtyonetmen.Text = "";
            txtfilmafis.Text = "";
            cmbsalonsec.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            pictureBox1.Image = null;
            textBox1.Focus();
        }

        void verilerigoster(string veriler)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(veriler, baglantisi.baglanti());
            DataSet ds2 = new DataSet();
            sqlda.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
        }

        void salonverilerigoster(string salonveriler)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(salonveriler, baglantisi.baglanti());
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView2.DataSource= ds.Tables[0];
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselprojeDataSet1.Salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonTableAdapter.Fill(this.gorselprojeDataSet1.Salon);
            // TODO: Bu kod satırı 'gorselprojeDataSet.Salon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonTableAdapter.Fill(this.gorselprojeDataSet.Salon);
            // TODO: Bu kod satırı 'gorselprojeDataSet.SinemaFilm' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sinemaFilmTableAdapter.Fill(this.gorselprojeDataSet.SinemaFilm);
           
            salongetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmekle();
        }
        void filmekle()
        {
            try
            {
                //  baglanti.Open();
                SqlCommand filmekle = new SqlCommand("Insert into SinemaFilm (FilmAdi,FilmTuru,VizyonTarihi,FilmSuresi,FilmDetayi,FilmYerli,Yonetmen,FilmAfisi,YayinlanacakSalon) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9)", baglantisi.baglanti());
                filmekle.Parameters.AddWithValue("@a1", textBox1.Text);
                filmekle.Parameters.AddWithValue("@a2", textBox2.Text);
                filmekle.Parameters.AddWithValue("@a3", dateTimePicker1.Value.Date);
                filmekle.Parameters.AddWithValue("@a4", textBox3.Text + " " + "Dakika");
                filmekle.Parameters.AddWithValue("@a5", txtfilmdetayı.Text);
                filmekle.Parameters.AddWithValue("@a6", label8.Text);
                filmekle.Parameters.AddWithValue("@a7", txtyonetmen.Text);
                filmekle.Parameters.AddWithValue("@a8", txtfilmafis.Text);
                filmekle.Parameters.AddWithValue("@a9", cmbsalonsec.Text);
                filmekle.ExecuteNonQuery();
                MessageBox.Show("Filminiz başarıyla eklenmiştir.");
                logKayit.AddLog("Info", "Sinema Filmi Eklendi.", "FilmEkleme");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error",ex.Message,"FilmEkleme");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

         
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked == true)
            {
                label8.Text = ("True");
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = ("False");
            }
        }

        
           private void btnfilmsil_Click(object sender, EventArgs e)
           {
              try
              {
               // baglanti.Open();
                SqlCommand filmsil = new SqlCommand("Delete from SinemaFilm Where FilmId=@s1", baglantisi.baglanti());
                filmsil.Parameters.AddWithValue("@s1", textBoxid.Text);
                filmsil.ExecuteNonQuery();
                MessageBox.Show("Film Başarı ile silinmiştir");
                logKayit.AddLog("Info","Sinema Filmi Silindi","FilmSilme");
               }
    
               catch (Exception ex)
               {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error",ex.Message,"FilmSilme");
               }
               finally
               {
                baglantisi.baglanti().Close();
               }
           }

        private void btnfilmafis_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            txtfilmafis.Text = openFileDialog1.FileName;
        }

        void vizyontarihcevirme()
        {
            string vizyontarihi = dateTimePicker1.Value.ToShortDateString();
            txtvizyontarihi.Text = vizyontarihi;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten buradasın.");
        }

        private void btnvizyontarihi_Click(object sender, EventArgs e)
        {
            vizyontarihcevirme();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            yenile();
            verilerigoster("Select * From SinemaFilm");
        }

        private void txtfilmafis_TextChanged(object sender, EventArgs e)
        {
           string resim = txtfilmafis.Text;
           pictureBox1.ImageLocation = resim;
        }

        private void btnseansagit_Click(object sender, EventArgs e)
        {
            FormSeansEkleme formSeansEkleme = new FormSeansEkleme();
            formSeansEkleme.Show();
            this.Hide();
        }

        private void btnsalonyenile_Click(object sender, EventArgs e)
        {
            salonyenile();
            salonverilerigoster("Select * From Salon");
            txtSalon.Focus();
        }

        void salonyenile()
        {
            txtSalonid.Text = "";
            txtSalon.Text = "";
            txtSalonKapasite.Text = "";
        }

        private void btnsaloncıkar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand salonsil = new SqlCommand("Delete from Salon Where SalonId = @f1", baglantisi.baglanti());
                salonsil.Parameters.AddWithValue("@f1", txtSalonid.Text);
                salonsil.ExecuteNonQuery();
                MessageBox.Show("Salon silme işlemi başarılı."); 
                logKayit.AddLog("Info", "Salon Silinmiştir", "SalonSilme");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message, "SalonSilme");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        private void btnsalonekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand salonekle = new SqlCommand("Insert into Salon (SalonAdi,SalonKapasite) values (@h1,@h2)", baglantisi.baglanti());
                salonekle.Parameters.AddWithValue("@h1", txtSalon.Text);
                salonekle.Parameters.AddWithValue("@h2", txtSalonKapasite.Text);
                salonekle.ExecuteNonQuery();
                MessageBox.Show("Salon ekleme başarı ile yapılmıştır");
                logKayit.AddLog("Info", "Salon Ekleme Yapıldı", "SalonEkleme");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message, "SalonEkleme");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        void salongetir()
        {
            try
            {
                string sorgu = "Select * From Salon ORDER BY SalonAdi ASC";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbsalonsec.Items.Add(oku["SalonAdi"].ToString());
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

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int salonsecilen = dataGridView2.SelectedCells[0].RowIndex;
            txtSalonid.Text = dataGridView2.Rows[salonsecilen].Cells[0].Value.ToString();
            txtSalon.Text = dataGridView2.Rows[salonsecilen].Cells[1].Value.ToString();
            txtSalonKapasite.Text = dataGridView2.Rows[salonsecilen].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtvizyontarihi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtfilmdetayı.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtyonetmen.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtfilmafis.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            cmbsalonsec.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }
    }    
}