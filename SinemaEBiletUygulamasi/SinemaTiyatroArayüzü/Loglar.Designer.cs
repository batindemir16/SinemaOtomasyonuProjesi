namespace SinemaTiyatroArayüzü
{
    partial class Loglar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gorselprojeDataSet = new SinemaTiyatroArayüzü.gorselprojeDataSet();
            this.logKayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logKayitlarTableAdapter = new SinemaTiyatroArayüzü.gorselprojeDataSetTableAdapters.LogKayitlarTableAdapter();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncalisanform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlogid = new System.Windows.Forms.TextBox();
            this.txtlogzamani = new System.Windows.Forms.TextBox();
            this.txtlogtipi = new System.Windows.Forms.TextBox();
            this.txtlogmesaj = new System.Windows.Forms.TextBox();
            this.txtlogdetay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselprojeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logKayitlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn,
            this.logTypeDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.detailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logKayitlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(898, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // gorselprojeDataSet
            // 
            this.gorselprojeDataSet.DataSetName = "gorselprojeDataSet";
            this.gorselprojeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logKayitlarBindingSource
            // 
            this.logKayitlarBindingSource.DataMember = "LogKayitlar";
            this.logKayitlarBindingSource.DataSource = this.gorselprojeDataSet;
            // 
            // logKayitlarTableAdapter
            // 
            this.logKayitlarTableAdapter.ClearBeforeFill = true;
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "LogID";
            this.logIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            this.logIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.logIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.Width = 125;
            // 
            // logTypeDataGridViewTextBoxColumn
            // 
            this.logTypeDataGridViewTextBoxColumn.DataPropertyName = "LogType";
            this.logTypeDataGridViewTextBoxColumn.HeaderText = "LogType";
            this.logTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.logTypeDataGridViewTextBoxColumn.Name = "logTypeDataGridViewTextBoxColumn";
            this.logTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailDataGridViewTextBoxColumn
            // 
            this.detailDataGridViewTextBoxColumn.DataPropertyName = "Detail";
            this.detailDataGridViewTextBoxColumn.HeaderText = "Detail";
            this.detailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailDataGridViewTextBoxColumn.Name = "detailDataGridViewTextBoxColumn";
            this.detailDataGridViewTextBoxColumn.Width = 125;
            // 
            // btncalisanform
            // 
            this.btncalisanform.Location = new System.Drawing.Point(13, 13);
            this.btncalisanform.Name = "btncalisanform";
            this.btncalisanform.Size = new System.Drawing.Size(114, 58);
            this.btncalisanform.TabIndex = 1;
            this.btncalisanform.Text = "Çalışan Yönetimi";
            this.btncalisanform.UseVisualStyleBackColor = true;
            this.btncalisanform.Click += new System.EventHandler(this.btncalisanform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "LogId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loglama zamanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Log tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Log Mesaj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Log Detay:";
            // 
            // txtlogid
            // 
            this.txtlogid.Location = new System.Drawing.Point(492, 22);
            this.txtlogid.Name = "txtlogid";
            this.txtlogid.ReadOnly = true;
            this.txtlogid.Size = new System.Drawing.Size(106, 22);
            this.txtlogid.TabIndex = 7;
            // 
            // txtlogzamani
            // 
            this.txtlogzamani.Location = new System.Drawing.Point(492, 52);
            this.txtlogzamani.Name = "txtlogzamani";
            this.txtlogzamani.ReadOnly = true;
            this.txtlogzamani.Size = new System.Drawing.Size(170, 22);
            this.txtlogzamani.TabIndex = 8;
            // 
            // txtlogtipi
            // 
            this.txtlogtipi.Location = new System.Drawing.Point(492, 84);
            this.txtlogtipi.Name = "txtlogtipi";
            this.txtlogtipi.ReadOnly = true;
            this.txtlogtipi.Size = new System.Drawing.Size(114, 22);
            this.txtlogtipi.TabIndex = 9;
            // 
            // txtlogmesaj
            // 
            this.txtlogmesaj.Location = new System.Drawing.Point(492, 126);
            this.txtlogmesaj.Name = "txtlogmesaj";
            this.txtlogmesaj.ReadOnly = true;
            this.txtlogmesaj.Size = new System.Drawing.Size(180, 22);
            this.txtlogmesaj.TabIndex = 10;
            // 
            // txtlogdetay
            // 
            this.txtlogdetay.Location = new System.Drawing.Point(492, 168);
            this.txtlogdetay.Name = "txtlogdetay";
            this.txtlogdetay.ReadOnly = true;
            this.txtlogdetay.Size = new System.Drawing.Size(180, 22);
            this.txtlogdetay.TabIndex = 11;
            // 
            // Loglar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.txtlogdetay);
            this.Controls.Add(this.txtlogmesaj);
            this.Controls.Add(this.txtlogtipi);
            this.Controls.Add(this.txtlogzamani);
            this.Controls.Add(this.txtlogid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalisanform);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Loglar";
            this.Text = "Loglar";
            this.Load += new System.EventHandler(this.Loglar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselprojeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logKayitlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gorselprojeDataSet gorselprojeDataSet;
        private System.Windows.Forms.BindingSource logKayitlarBindingSource;
        private gorselprojeDataSetTableAdapters.LogKayitlarTableAdapter logKayitlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btncalisanform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlogid;
        private System.Windows.Forms.TextBox txtlogzamani;
        private System.Windows.Forms.TextBox txtlogtipi;
        private System.Windows.Forms.TextBox txtlogmesaj;
        private System.Windows.Forms.TextBox txtlogdetay;
    }
}