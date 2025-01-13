namespace SinemaTiyatroArayüzü
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFilmAdi = new System.Windows.Forms.ComboBox();
            this.lblyerlimi = new System.Windows.Forms.Label();
            this.txtafisyolu = new System.Windows.Forms.TextBox();
            this.txtsalon = new System.Windows.Forms.TextBox();
            this.txtvizyontarihi = new System.Windows.Forms.TextBox();
            this.txtfilmturu = new System.Windows.Forms.TextBox();
            this.txtyonetmen = new System.Windows.Forms.TextBox();
            this.txtdetay = new System.Windows.Forms.TextBox();
            this.txtfilmsuresi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnfilmisec = new System.Windows.Forms.Button();
            this.txtyerlimi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Film Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vizyon Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Film Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Yerli mi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Detay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yönetmen:";
            // 
            // cmbFilmAdi
            // 
            this.cmbFilmAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmAdi.FormattingEnabled = true;
            this.cmbFilmAdi.Location = new System.Drawing.Point(256, 44);
            this.cmbFilmAdi.Name = "cmbFilmAdi";
            this.cmbFilmAdi.Size = new System.Drawing.Size(186, 29);
            this.cmbFilmAdi.TabIndex = 12;
            this.cmbFilmAdi.SelectedIndexChanged += new System.EventHandler(this.cmbFilmAdi_SelectedIndexChanged);
            // 
            // lblyerlimi
            // 
            this.lblyerlimi.AutoSize = true;
            this.lblyerlimi.Location = new System.Drawing.Point(361, 221);
            this.lblyerlimi.Name = "lblyerlimi";
            this.lblyerlimi.Size = new System.Drawing.Size(71, 21);
            this.lblyerlimi.TabIndex = 15;
            this.lblyerlimi.Text = "Kontrolu";
            this.lblyerlimi.Visible = false;
            // 
            // txtafisyolu
            // 
            this.txtafisyolu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtafisyolu.Enabled = false;
            this.txtafisyolu.Location = new System.Drawing.Point(12, 338);
            this.txtafisyolu.Name = "txtafisyolu";
            this.txtafisyolu.ReadOnly = true;
            this.txtafisyolu.Size = new System.Drawing.Size(151, 28);
            this.txtafisyolu.TabIndex = 16;
            this.txtafisyolu.Visible = false;
            this.txtafisyolu.TextChanged += new System.EventHandler(this.txtafisyolu_TextChanged);
            // 
            // txtsalon
            // 
            this.txtsalon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalon.Location = new System.Drawing.Point(237, 81);
            this.txtsalon.Name = "txtsalon";
            this.txtsalon.ReadOnly = true;
            this.txtsalon.Size = new System.Drawing.Size(151, 28);
            this.txtsalon.TabIndex = 17;
            // 
            // txtvizyontarihi
            // 
            this.txtvizyontarihi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvizyontarihi.Location = new System.Drawing.Point(288, 115);
            this.txtvizyontarihi.Name = "txtvizyontarihi";
            this.txtvizyontarihi.ReadOnly = true;
            this.txtvizyontarihi.Size = new System.Drawing.Size(100, 28);
            this.txtvizyontarihi.TabIndex = 18;
            // 
            // txtfilmturu
            // 
            this.txtfilmturu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfilmturu.Location = new System.Drawing.Point(266, 186);
            this.txtfilmturu.Name = "txtfilmturu";
            this.txtfilmturu.ReadOnly = true;
            this.txtfilmturu.Size = new System.Drawing.Size(151, 28);
            this.txtfilmturu.TabIndex = 19;
            // 
            // txtyonetmen
            // 
            this.txtyonetmen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyonetmen.Location = new System.Drawing.Point(269, 252);
            this.txtyonetmen.Name = "txtyonetmen";
            this.txtyonetmen.ReadOnly = true;
            this.txtyonetmen.Size = new System.Drawing.Size(151, 28);
            this.txtyonetmen.TabIndex = 20;
            // 
            // txtdetay
            // 
            this.txtdetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdetay.Location = new System.Drawing.Point(237, 292);
            this.txtdetay.Name = "txtdetay";
            this.txtdetay.ReadOnly = true;
            this.txtdetay.Size = new System.Drawing.Size(151, 28);
            this.txtdetay.TabIndex = 21;
            // 
            // txtfilmsuresi
            // 
            this.txtfilmsuresi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfilmsuresi.Location = new System.Drawing.Point(269, 149);
            this.txtfilmsuresi.Name = "txtfilmsuresi";
            this.txtfilmsuresi.ReadOnly = true;
            this.txtfilmsuresi.Size = new System.Drawing.Size(130, 28);
            this.txtfilmsuresi.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Film Süresi:";
            // 
            // btnfilmisec
            // 
            this.btnfilmisec.Location = new System.Drawing.Point(264, 357);
            this.btnfilmisec.Name = "btnfilmisec";
            this.btnfilmisec.Size = new System.Drawing.Size(178, 86);
            this.btnfilmisec.TabIndex = 24;
            this.btnfilmisec.Text = "Filmi Seç";
            this.btnfilmisec.UseVisualStyleBackColor = true;
            this.btnfilmisec.Click += new System.EventHandler(this.btnfilmisec_Click);
            // 
            // txtyerlimi
            // 
            this.txtyerlimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyerlimi.Location = new System.Drawing.Point(249, 219);
            this.txtyerlimi.Name = "txtyerlimi";
            this.txtyerlimi.ReadOnly = true;
            this.txtyerlimi.Size = new System.Drawing.Size(82, 28);
            this.txtyerlimi.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtyerlimi);
            this.Controls.Add(this.btnfilmisec);
            this.Controls.Add(this.txtfilmsuresi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdetay);
            this.Controls.Add(this.txtyonetmen);
            this.Controls.Add(this.txtfilmturu);
            this.Controls.Add(this.txtvizyontarihi);
            this.Controls.Add(this.txtsalon);
            this.Controls.Add(this.txtafisyolu);
            this.Controls.Add(this.lblyerlimi);
            this.Controls.Add(this.cmbFilmAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Film Seç";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFilmAdi;
        private System.Windows.Forms.Label lblyerlimi;
        private System.Windows.Forms.TextBox txtafisyolu;
        private System.Windows.Forms.TextBox txtsalon;
        private System.Windows.Forms.TextBox txtvizyontarihi;
        private System.Windows.Forms.TextBox txtfilmturu;
        private System.Windows.Forms.TextBox txtyonetmen;
        private System.Windows.Forms.TextBox txtdetay;
        private System.Windows.Forms.TextBox txtfilmsuresi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnfilmisec;
        private System.Windows.Forms.TextBox txtyerlimi;
    }
}