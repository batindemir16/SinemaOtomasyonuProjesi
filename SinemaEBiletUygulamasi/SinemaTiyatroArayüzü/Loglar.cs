using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaTiyatroArayüzü
{
    public partial class Loglar : Form
    {
        public Loglar()
        {
            InitializeComponent();
        }

        private void Loglar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselprojeDataSet.LogKayitlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.logKayitlarTableAdapter.Fill(this.gorselprojeDataSet.LogKayitlar);

        }

        private void btncalisanform_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtlogid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtlogzamani.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtlogtipi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtlogmesaj.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtlogdetay.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }
    }
}
