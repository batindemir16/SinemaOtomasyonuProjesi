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
    public partial class Datetimepickerdeneme : Form
    {
        public Datetimepickerdeneme()
        {
            InitializeComponent();
        }

        void tarihdegercevirme()
        {
            string tarih = dateTimePicker1.Value.ToShortDateString();
            textBox1.Text = tarih;
        }

        void saatçevirme()
        {
            string saat = dateTimePicker2.Value.ToShortTimeString();
            textBox2.Text = saat;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tarihdegercevirme();
            saatçevirme();
        }
    }
}
