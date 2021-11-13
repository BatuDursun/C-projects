using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Hesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "        KARE için;";
            label1.Visible = true;
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dikdörtgen için;";
            label1.Visible = true;
            panel2.Visible = true;







        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "       DAİRE için;";
            label1.Visible = true;
            panel3.Visible = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kenar;
            int alan;
            int cevre;


            kenar = Convert.ToInt32(textBox1.Text);
            alan = kenar * kenar;
            cevre = kenar * 4;

            label5.Text = alan.ToString();
            label6.Text = cevre.ToString();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kisaKenar;
            int uzunKenar;
            int aland;
            int cevred;

            kisaKenar = Convert.ToInt32(textBox2.Text);
            uzunKenar = Convert.ToInt32(textBox3.Text);
            aland = kisaKenar * uzunKenar;
            cevred = (2 * kisaKenar) + (2 * uzunKenar);

            label5.Text = aland.ToString();
            label6.Text = cevred.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double r;
            double alan;
            double cevre;

            r = Convert.ToDouble(textBox4.Text);

            alan = (Math.PI) * (r*r);
            cevre = 2 * (Math.PI) * r;

            label5.Text = alan.ToString();
            label6.Text = cevre.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
