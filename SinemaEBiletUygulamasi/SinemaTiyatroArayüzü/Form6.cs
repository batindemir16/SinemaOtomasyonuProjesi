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
using System.Windows.Forms.VisualStyles;

namespace SinemaTiyatroArayüzü
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();            
        }

        LogKayit logKayit = new LogKayit();

        sqlBaglantisi baglantisi = new sqlBaglantisi();
      //SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=gorselproje;Integrated Security=True;TrustServerCertificate=True");
        void secilenKoltuklar()
        {
            txtSecilenKoltuklar.Text = "";
            foreach (string item in listBoxSecilenKoltuklar.Items)
            {
                txtSecilenKoltuklar.Text += "," + item;
            }
            if (txtSecilenKoltuklar.Text.Length > 1)
            {
                txtSecilenKoltuklar.Text = txtSecilenKoltuklar.Text.Substring(1);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
  
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void yenile()
        {
            txtSecilenKoltuklar.Text = "";
            listBoxSecilenKoltuklar.Items.Clear();
            listBoxDoluKoltuklar.Items.Clear();
        }
      
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Bu koltuk doludur.");
            }
            else
            {
                if (btn.BackColor == Color.Yellow)
                {
                    btn.BackColor = Color.Blue;
                    listBoxSecilenKoltuklar.Items.Remove(btn.Text);
                    koltukadet--;
                    secilenKoltuklar();
                    
                }
                else
                {
                    btn.BackColor= Color.Yellow;
                    listBoxSecilenKoltuklar.Items.Add(btn.Text);
                    koltukadet++;
                    secilenKoltuklar();
                    
                }
            }
            int biletfiyat = koltukadet * biletadetfiyat;
            txtfiyat.Text = biletfiyat.ToString();
        }

        private int koltukadet = 0;
        private int biletadetfiyat = 200;

        public string filmadi;
        public string salon;
        private void Form6_Load_1(object sender, EventArgs e)
        {
            lblBiletci.Text = Form1.calisangonder;
            txtfilmadi.Text = filmadi;
            txtsalon.Text = salon;
            DateTime bugun = DateTime.Now;
            dateTimePicker1.MinDate = bugun;
            dateTimePicker1.MaxDate = bugun.AddDays(7);

        }

        void koltuklariOlustur()
        {
            lblkoltuksayisi.Text = "25";
            KoltıkPaneli.Controls.Clear();
            int sayı = Convert.ToInt16(lblkoltuksayisi.Text);
            for (int i = 1; i <= sayı; i++)
            {
                Button btn = new Button();

                if (i <= 5 * 1)
                {
                    btn.Text = "A" + i.ToString();
                }
                else if (i <= 5 * 2)
                {
                    btn.Text = "B" + (i - 5 * 1).ToString();
                }
                else if (i <= 5 * 3)
                {
                    btn.Text = "C" + (i - 5 * 2).ToString();
                }
                else if (i <= 5 * 4)
                {
                    btn.Text = "D" + (i - 5 * 3).ToString();
                }
                else if (i <= 5 * 5)
                {
                    btn.Text = "E" + (i - 5 * 4).ToString();
                }
                btn.Width = 50;
                btn.Height = 50;
                btn.BackColor = Color.Blue;
                btn.Click += Btn_Click;
                if (listBoxDoluKoltuklar.Items.Contains(btn.Text))
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor= Color.Blue;
                }
                KoltıkPaneli.Controls.Add(btn);
            }
        }

        void tarihdegercevirme()
        {
            string tarih = dateTimePicker1.Value.ToShortDateString();
            txtseanstarihi.Text = tarih;
        }

        private void btntarihonay_Click(object sender, EventArgs e)
        {
            tarihdegercevirme();
        }

        private void btnkoltukgoster_Click(object sender, EventArgs e)
        {
            yenile();
            dolukoltuklar();
            koltukayirma();
            koltuklariOlustur();

        }

        private void txtseanstarihi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SeansSaatiPaneli.Controls.Clear();
                string seanssaati;
                string sorgu = "Select DISTINCT SeansSaat FROM SeansKontrol WHERE SalonAdi = @salonadi AND SeansTarih = @seanstarih AND FilmAdi = @filmadi";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                komut.Parameters.AddWithValue("@salonadi", txtsalon.Text);
                komut.Parameters.AddWithValue("@seanstarih", txtseanstarihi.Text);
                komut.Parameters.AddWithValue("@filmadi", txtfilmadi.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    seanssaati = oku["SeansSaat"].ToString();
                    RadioButton radiobtn = new RadioButton();
                    radiobtn.Text = seanssaati;
                    radiobtn.CheckedChanged += new EventHandler(Seanssaatler);
                    SeansSaatiPaneli.Controls.Add(radiobtn);
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
        void Seanssaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in SeansSaatiPaneli.Controls)
            {
                if (item.Checked)
                {
                    lblseanssaati.Text = item.Text;
                }
            }
        }

        void dolukoltuklar()
        {
            try
            {

                lblDoluKoltuklar.Text = "";
                string sorgu = "Select * From SeansKontrol WHERE FilmAdi = @filmadi AND SeansTarih = @seanstarih AND SeansSaat = @seanssaat AND SalonAdi = @salonadi";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                komut.Parameters.AddWithValue("@filmadi", txtfilmadi.Text);
                komut.Parameters.AddWithValue("@seanstarih", txtseanstarihi.Text);
                komut.Parameters.AddWithValue("@seanssaat", lblseanssaati.Text);
                komut.Parameters.AddWithValue("@salonadi", txtsalon.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    lblDoluKoltuklar.Text += "," +  oku["DoluKoltuklar"].ToString();
                    if (lblDoluKoltuklar.Text.Length > 1)
                    {
                        lblDoluKoltuklar.Text = lblDoluKoltuklar.Text.Substring(1);
                    }
                    else
                    {
                        lblDoluKoltuklar.Text = "";
                    }
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

        void koltukayirma()
        {
            listBoxDoluKoltuklar.Items.Clear();
            string no = "";
            string[] sec;
            no = lblDoluKoltuklar.Text;
            sec = no.Split(',');
            foreach (string s in sec)
            {
                listBoxDoluKoltuklar.Items.Add(s);
            }
        }

        void dolukoltukarikaydet() 
        {
            string sorgu = "UPDATE SeansKontrol SET DoluKoltuklar = @koltuklar WHERE FilmAdi = @filmadi AND SeansTarih = @seanstarih AND SeansSaat = @seanssaat AND SalonAdi =@salonadi ";
            SqlCommand guncelle = new SqlCommand(sorgu, baglantisi.baglanti());
            if (lblDoluKoltuklar.Text=="")
            {
                guncelle.Parameters.AddWithValue("@koltuklar", txtSecilenKoltuklar.Text);
            }
            else
            {
                guncelle.Parameters.AddWithValue("@koltuklar", lblDoluKoltuklar.Text + "," + txtSecilenKoltuklar.Text);
            }
            guncelle.Parameters.AddWithValue("@filmadi",txtfilmadi.Text);
            guncelle.Parameters.AddWithValue("@seanstarih",txtseanstarihi.Text);
            guncelle.Parameters.AddWithValue("@seanssaat",lblseanssaati.Text);
            guncelle.Parameters.AddWithValue("@salonadi",txtsalon.Text);
            guncelle .ExecuteNonQuery();
        }

        private void btnal_Click(object sender, EventArgs e)
        {
            biletkaydet();
            dolukoltukarikaydet();
        }

        void biletkaydet()
        {
            try
            {
                lblbiletid.Text = "";
                string sorgu = "Insert Into Biletler(CalisanAdSoyad, KoltukNo, FilmAdi, SeansTarihi, SeansSaati, IslemTarihi, SalonAdi, Fiyat) OUTPUT INSERTED.BiletId VALUES (@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8)";
                SqlCommand komut = new SqlCommand(sorgu,baglantisi.baglanti());
                komut.Parameters.AddWithValue("@k1", lblBiletci.Text);
                komut.Parameters.AddWithValue("@k2", txtSecilenKoltuklar.Text);
                komut.Parameters.AddWithValue("@k3", txtfilmadi.Text);
                komut.Parameters.AddWithValue("@k4", txtseanstarihi.Text);
                komut.Parameters.AddWithValue("@k5", lblseanssaati.Text);
                komut.Parameters.AddWithValue("@k6", DateTime.Now.ToString());
                komut.Parameters.AddWithValue("@k7",txtsalon.Text);
                komut.Parameters.AddWithValue("@k8", txtfiyat.Text);
                komut .ExecuteNonQuery();
                lblbiletid.Text = komut.ExecuteScalar().ToString();
                string biletid = lblbiletid.Text.ToString();
                MessageBox.Show($"Bilet Satış işlemi başarılı oldu. \n Bilet Id niz: {biletid}");
                logKayit.AddLog("Info", "Bilet Satışı Yapılmıştır", "BiletSatış");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logKayit.AddLog("Error", ex.Message,"BiletSatış");
            }
            finally
            {
                baglantisi.baglanti().Close();
            }
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            biletsorguyenile();
        }
        void biletsorguyenile()
        {
            txtbiletid.Text = "";
            txtsorgulacalisan.Text = "";
            txtsorgulafilmadi.Text = "";
            txtsorgulasalonadi.Text = "";
            txtsorgulaseasntarihi.Text = "";
            txtsorgulaseanssaati.Text = "";
            txtsorgulakoltuklar.Text = "";
            txtsorgulasatistarihi.Text = "";
            txtsorgulabiletfiyati.Text = "";
        }

        private void btnbiletsorgula_Click(object sender, EventArgs e)
        {
            biletsorgula();
        }

        void biletsorgula()
        {
            try
            {
                string sorgu = "Select * From Biletler WHERE BiletId = @t1";
                SqlCommand komut = new SqlCommand(sorgu, baglantisi.baglanti());
                komut.Parameters.AddWithValue("@t1", txtbiletid.Text);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string calisan = oku["CalisanAdSoyad"].ToString();
                    txtsorgulacalisan.Text = calisan;
                    string filmadi = oku["FilmAdi"].ToString();
                    txtsorgulafilmadi.Text = filmadi;
                    string salon = oku["SalonAdi"].ToString();
                    txtsorgulasalonadi.Text = salon;
                    string seanstarih = oku["SeansTarihi"].ToString();
                    txtsorgulaseasntarihi.Text = seanstarih;
                    string seanssaat = oku["SeansSaati"].ToString();
                    txtsorgulaseanssaati.Text = seanssaat;
                    string koltuklar = oku["KoltukNo"].ToString();
                    txtsorgulakoltuklar.Text = koltuklar;
                    string satistarihi = oku["IslemTarihi"].ToString();
                    txtsorgulasatistarihi.Text = satistarihi;
                    string fiyat = oku["Fiyat"].ToString();
                    txtsorgulabiletfiyati.Text = fiyat;

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
    }
}
