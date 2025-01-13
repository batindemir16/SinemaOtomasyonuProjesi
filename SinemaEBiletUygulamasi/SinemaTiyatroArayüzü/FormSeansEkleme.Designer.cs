namespace SinemaTiyatroArayüzü
{
    partial class FormSeansEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnseansagit = new System.Windows.Forms.Button();
            this.btnformcalisanagit = new System.Windows.Forms.Button();
            this.btnfilmegit = new System.Windows.Forms.Button();
            this.cmbsalonlar = new System.Windows.Forms.ComboBox();
            this.txtfilmler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdolusaatler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SeansSaatPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnyenile = new System.Windows.Forms.Button();
            this.btnseanssec = new System.Windows.Forms.Button();
            this.btnseansekle = new System.Windows.Forms.Button();
            this.lblsecilensaat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnseansagit
            // 
            this.btnseansagit.Location = new System.Drawing.Point(311, 12);
            this.btnseansagit.Name = "btnseansagit";
            this.btnseansagit.Size = new System.Drawing.Size(140, 52);
            this.btnseansagit.TabIndex = 59;
            this.btnseansagit.Text = "Seans Yönetimi";
            this.btnseansagit.UseVisualStyleBackColor = true;
            this.btnseansagit.Click += new System.EventHandler(this.btnseansagit_Click);
            // 
            // btnformcalisanagit
            // 
            this.btnformcalisanagit.Location = new System.Drawing.Point(157, 12);
            this.btnformcalisanagit.Name = "btnformcalisanagit";
            this.btnformcalisanagit.Size = new System.Drawing.Size(140, 52);
            this.btnformcalisanagit.TabIndex = 58;
            this.btnformcalisanagit.Text = "Çalışan Yönetimi";
            this.btnformcalisanagit.UseVisualStyleBackColor = true;
            this.btnformcalisanagit.Click += new System.EventHandler(this.btnformcalisanagit_Click);
            // 
            // btnfilmegit
            // 
            this.btnfilmegit.Location = new System.Drawing.Point(7, 12);
            this.btnfilmegit.Name = "btnfilmegit";
            this.btnfilmegit.Size = new System.Drawing.Size(140, 52);
            this.btnfilmegit.TabIndex = 57;
            this.btnfilmegit.Text = "Film Yönetimi";
            this.btnfilmegit.UseVisualStyleBackColor = true;
            this.btnfilmegit.Click += new System.EventHandler(this.btnfilmegit_Click);
            // 
            // cmbsalonlar
            // 
            this.cmbsalonlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsalonlar.FormattingEnabled = true;
            this.cmbsalonlar.Location = new System.Drawing.Point(87, 120);
            this.cmbsalonlar.Name = "cmbsalonlar";
            this.cmbsalonlar.Size = new System.Drawing.Size(121, 24);
            this.cmbsalonlar.TabIndex = 60;
            this.cmbsalonlar.SelectedIndexChanged += new System.EventHandler(this.cmbsalonlar_SelectedIndexChanged);
            // 
            // txtfilmler
            // 
            this.txtfilmler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfilmler.Location = new System.Drawing.Point(87, 151);
            this.txtfilmler.Name = "txtfilmler";
            this.txtfilmler.ReadOnly = true;
            this.txtfilmler.Size = new System.Drawing.Size(176, 22);
            this.txtfilmler.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Salon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Film:";
            // 
            // cmbdolusaatler
            // 
            this.cmbdolusaatler.FormattingEnabled = true;
            this.cmbdolusaatler.Location = new System.Drawing.Point(102, 387);
            this.cmbdolusaatler.Name = "cmbdolusaatler";
            this.cmbdolusaatler.Size = new System.Drawing.Size(121, 24);
            this.cmbdolusaatler.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Dolu Saatler:";
            // 
            // SeansSaatPaneli
            // 
            this.SeansSaatPaneli.Location = new System.Drawing.Point(340, 120);
            this.SeansSaatPaneli.Name = "SeansSaatPaneli";
            this.SeansSaatPaneli.Size = new System.Drawing.Size(368, 260);
            this.SeansSaatPaneli.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Seans Saatleri";
            // 
            // btnyenile
            // 
            this.btnyenile.Location = new System.Drawing.Point(87, 328);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(95, 32);
            this.btnyenile.TabIndex = 68;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = true;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // btnseanssec
            // 
            this.btnseanssec.Location = new System.Drawing.Point(87, 252);
            this.btnseanssec.Name = "btnseanssec";
            this.btnseanssec.Size = new System.Drawing.Size(95, 32);
            this.btnseanssec.TabIndex = 69;
            this.btnseanssec.Text = "Seans Seç";
            this.btnseanssec.UseVisualStyleBackColor = true;
            this.btnseanssec.Click += new System.EventHandler(this.btnseanssec_Click);
            // 
            // btnseansekle
            // 
            this.btnseansekle.Location = new System.Drawing.Point(87, 290);
            this.btnseansekle.Name = "btnseansekle";
            this.btnseansekle.Size = new System.Drawing.Size(95, 32);
            this.btnseansekle.TabIndex = 70;
            this.btnseansekle.Text = "Seans Ekle";
            this.btnseansekle.UseVisualStyleBackColor = true;
            this.btnseansekle.Click += new System.EventHandler(this.btnseansekle_Click);
            // 
            // lblsecilensaat
            // 
            this.lblsecilensaat.AutoSize = true;
            this.lblsecilensaat.Location = new System.Drawing.Point(367, 409);
            this.lblsecilensaat.Name = "lblsecilensaat";
            this.lblsecilensaat.Size = new System.Drawing.Size(83, 16);
            this.lblsecilensaat.TabIndex = 71;
            this.lblsecilensaat.Text = "Seçilen Saat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // txttarih
            // 
            this.txttarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttarih.Location = new System.Drawing.Point(87, 215);
            this.txttarih.Name = "txttarih";
            this.txttarih.ReadOnly = true;
            this.txttarih.Size = new System.Drawing.Size(121, 22);
            this.txttarih.TabIndex = 74;
            // 
            // FormSeansEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsecilensaat);
            this.Controls.Add(this.btnseansekle);
            this.Controls.Add(this.btnseanssec);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SeansSaatPaneli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbdolusaatler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfilmler);
            this.Controls.Add(this.cmbsalonlar);
            this.Controls.Add(this.btnseansagit);
            this.Controls.Add(this.btnformcalisanagit);
            this.Controls.Add(this.btnfilmegit);
            this.Name = "FormSeansEkleme";
            this.Text = "FormSeansEkleme";
            this.Load += new System.EventHandler(this.FormSeansEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnseansagit;
        private System.Windows.Forms.Button btnformcalisanagit;
        private System.Windows.Forms.Button btnfilmegit;
        private System.Windows.Forms.ComboBox cmbsalonlar;
        private System.Windows.Forms.TextBox txtfilmler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdolusaatler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel SeansSaatPaneli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.Button btnseanssec;
        private System.Windows.Forms.Button btnseansekle;
        private System.Windows.Forms.Label lblsecilensaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txttarih;
    }
}