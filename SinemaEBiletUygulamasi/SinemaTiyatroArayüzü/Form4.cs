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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           
        }

        LogKayit logKayit = new LogKayit();

        sqlBaglantisi baglantisi = new sqlBaglantisi();
        //SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=gorselproje;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselprojeDataSet1.Calisanlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanlarTableAdapter1.Fill(this.gorselprojeDataSet1.Calisanlar);

        }

        void temizle()
        {
            txtid.Text = "";
            txtgirisid.Text = "";
            txtsifre.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtgirisid.Focus();
        }
        private void btnyenile_Click(object sender, EventArgs e)
        {
            temizle();
            verilerigoster("Select * From Calisanlar");
        }

        void verilerigoster(string veriler)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(veriler ,baglantisi.baglanti());
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = ("False");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            { 
                label1.Text = ("True");
            }
        }


        private void btnguncelle_Click(object sender, EventArgs e)
        {
            calisanguncelle();
        }
        void calisanguncelle()
        {
            try
            {
                //baglanti.Open();
                SqlCommand guncelle = new SqlCommand("Update  Calisanlar Set calisanKonum=@g1, CalisanGirisId=@g2, CalisanSifre=@g3, CalisanAd=@g4, CalisanSoyad=@g5 where CalisanId=@g6", baglantisi.baglanti());
                guncelle.Parameters.AddWithValue("@g1", label1.Text);
                guncelle.Parameters.AddWithValue("@g2", txtgirisid.Text);
                guncelle.Parameters.AddWithValue("@g3", txtsifre.Text);
                guncelle.Parameters.AddWithValue("@g4", txtad.Text);
                guncelle.Parameters.AddWithValue("@g5", txtsoyad.Text);
                guncelle.Parameters.AddWithValue("@g6", txtid.Text);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Çalışan bilgileri güncellendi.");
                logKayit.AddLog("Info", "Çalışan Bilgileri Güncellendi,", "ÇalışanGüncelle");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message, "ÇalışanGüncelle");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }


        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
               // baglanti.Open();

                SqlCommand sil = new SqlCommand("Delete from Calisanlar Where CalisanId=@p1", baglantisi.baglanti());
                sil.Parameters.AddWithValue("@p1", txtid.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarılı olmuştur.");
                logKayit.AddLog("Info", "Çalışan Silinmiştir", "ÇalışanSilme");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message, "ÇalışanSilme");
            }
            finally
            {
                baglantisi.baglanti().Close();
            } 
        }

       
       

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text == "True")
            {
                radioButton2.Checked = true;
            }
            if (label1.Text == "False")
            {
                radioButton1.Checked = true;
            }
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            calisanekle();
        }
        void calisanekle()
        {
            try
            {
                //  baglanti.Open();
                SqlCommand ekle = new SqlCommand("Insert into Calisanlar (CalisanKonum,CalisanGirisId,CalisanSifre,CalisanAd,CalisanSoyad) values (@e1,@e2,@e3,@e4,@e5)", baglantisi.baglanti());
                ekle.Parameters.AddWithValue("@e1", label1.Text);
                ekle.Parameters.AddWithValue("@e2", txtgirisid.Text);
                ekle.Parameters.AddWithValue("@e3", txtsifre.Text);
                ekle.Parameters.AddWithValue("@e4", txtad.Text);
                ekle.Parameters.AddWithValue("@e5", txtsoyad.Text);
                ekle.ExecuteNonQuery();
                MessageBox.Show("Çalışan eklendi.");
                logKayit.AddLog("Info", "Çalışan Eklenmiştir", "ÇalışanEkleme");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message, "ÇalışanEkleme");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              int secilen = dataGridView2.SelectedCells[0].RowIndex;
              txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
              label1.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
              txtgirisid.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
              txtsifre.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
              txtad.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
              txtsoyad.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zaten buradasın");
        }

        private void btnseansagit_Click(object sender, EventArgs e)
        {
            FormSeansEkleme formSeansEkleme = new FormSeansEkleme();
            formSeansEkleme.Show();
            this.Hide();
        }

        private void btnlogform_Click(object sender, EventArgs e)
        {
            Loglar loglar = new Loglar();
            loglar.Show();
            this.Hide();
        }
    }
}
