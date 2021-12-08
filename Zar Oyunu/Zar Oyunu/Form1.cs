using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GLOBAL VARİABLES
        Random rnd = new Random();
        int oyuncu1Puan;
        int oyuncu2Puan;
        int a, b;

        private void zarAt()
        {
            a = rnd.Next(1, 7);
            b = rnd.Next(1, 7);
            //oyuncu 1 için zar görselleri
            if (a==1)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\1.png");
            }
            if (a == 2)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\2.png");
            }
            if (a == 3)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\3.png");
            }
            if (a == 4)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\4.png");
            }
            if (a == 5)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\5.png");
            }
            if (a == 6)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\6.png");
            }
            //oyuncu 2 için zar görselleri
            if (b == 1)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\1.png");
            }
            if (b == 2)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\2.png");
            }
            if (b == 3)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\3.png");
            }
            if (b == 4)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\4.png");
            }
            if (b == 5)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\5.png");
            }
            if (b == 6)
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\monster\source\repos\Zar Oyunu\Zar Oyunu\bin\Debug\image\6.png");
            }
            
        }
        private void oyuncuSkor()
        {
            if (oyuncu1Puan >= Convert.ToInt32(textBox1.Text))
            {

                label6.Visible = true;
                button4.Visible = true;
                button2.Visible = false;
            }
            if (oyuncu2Puan >= Convert.ToInt32(textBox1.Text))
            {

                label6.Visible = true;
                label6.Text = "Oyuncu 2 kazandı.Tebrikler :)";
                button4.Visible = true;
                button1.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1.Enabled = false;
            button2.Enabled = true;
            zarAt();
            oyuncu1Puan = oyuncu1Puan + a+b;
            label3.Text = oyuncu1Puan.ToString();
            oyuncuSkor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button1.Enabled = true;
            button2.Enabled = false;
            zarAt();
            oyuncu2Puan = oyuncu2Puan + b+a;
            label5.Text = oyuncu2Puan.ToString();
            oyuncuSkor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100";
            textBox1.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            button1.Visible = true;
            button2.Visible = true;

            button1.Enabled = true;
            button2.Enabled = true;
            label3.Text = "0";
            label5.Text = "0";
            oyuncu1Puan = 0;
            oyuncu2Puan = 0;
            button4.Visible = false;
            label6.Visible = false;
        }
    }
}
