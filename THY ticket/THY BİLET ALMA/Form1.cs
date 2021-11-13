using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THY_BİLET_ALMA
{
    public partial class thy : Form
    {
        public thy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uçuş Bilgileri;");

            listBox1.Items.Add("Rota:"+comboBox1.Text+"-"+comboBox2.Text);
            listBox1.Items.Add("Tarih:"+dateTimePicker1.Text+" Saat: "+maskedTextBox1.Text);

            listBox1.Items.Add("Yolcu Bilgileri;");

            listBox1.Items.Add("Ad-Soyad:"+textBox1.Text);
            listBox1.Items.Add("TCKN:"+maskedTextBox2.Text);
            listBox1.Items.Add("TEL NO:"+maskedTextBox3.Text);
            
            listBox1.Items.Add("--------------------------------------------------------");
            
            MessageBox.Show("Yolcu kayıdı oluşturuldu.");



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
