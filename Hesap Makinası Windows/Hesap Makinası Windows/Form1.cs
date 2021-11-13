using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinası_Windows
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1;
        string islem;
        double sonuc;
        
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {kskskdkskdmsmdmd
                textBox1.Text += "5";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            textBox1.Text += ",";
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                islem = "/";
                sayi1 = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi1.ToString();
                label1.Text += islem.ToString();
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "Lütfen bir değer giriniz!!!!!";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                islem = "+";
                sayi1 = Convert.ToDouble(textBox1.Text);

                label1.Text = sayi1.ToString()+ islem.ToString(); ;
                
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "Lütfen bir değer giriniz!!!!!";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                islem = "-";
                sayi1 = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi1.ToString();
                label1.Text += islem.ToString();
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "Lütfen bir değer giriniz!!!!!";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + Convert.ToDouble(textBox1.Text);

                    label1.Text =  label1.Text.ToString()+textBox1.Text.ToString()+"="+sonuc.ToString();

                    textBox1.Text = "";
                    break;
                case "-":
                    sonuc = sayi1 - Convert.ToDouble(textBox1.Text);
                    
                    label1.Text = label1.Text.ToString() + textBox1.Text.ToString() + "=" + sonuc.ToString();

                    textBox1.Text = "";
                    break;
                case "x":
                    sonuc = sayi1 * Convert.ToDouble(textBox1.Text);
                    
                    label1.Text = label1.Text.ToString() + textBox1.Text.ToString() + "=" + sonuc.ToString();

                    textBox1.Text = "";
                    break;
                case "/":
                    sonuc = sayi1 / Convert.ToDouble(textBox1.Text);
                    
                    label1.Text = label1.Text.ToString() + textBox1.Text.ToString() + "=" + sonuc.ToString();

                    textBox1.Text = "";
                    break;


                    
            }

            listBox1.Items.Add(label1.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                islem = "x";
                sayi1 = Convert.ToDouble(textBox1.Text);
                label1.Text = sayi1.ToString();
                label1.Text += islem.ToString();
                textBox1.Text = "";
            }
            else
            {
                label1.Text = "Lütfen bir değer giriniz!!!!!";
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double karekok;
            
            
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            karekok = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            label1.Text = "√("+textBox1.Text+")"+"="+karekok;
            listBox1.Items.Add(label1.Text);
            textBox1.Text = "";
            
          
            
             
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double elog;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            elog = Math.Log(Convert.ToDouble(textBox1.Text));
            label1.Text = "ln(" + textBox1.Text + ")" + "=" + elog;
            listBox1.Items.Add(label1.Text);
            textBox1.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double log;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            log = Math.Log10(Convert.ToDouble(textBox1.Text));
            label1.Text = "log(" + textBox1.Text + ")" + "=" + log;
            listBox1.Items.Add(label1.Text);
            textBox1.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            if (button22.Text=="Geçmişi göster")
            {
                groupBox1.Visible = true;
                this.Size = new Size(790, 413);
                button22.Text = "Geçmişi gizle";
            }
            else
            {
                groupBox1.Visible = false;
                this.Size = new Size(412, 413);
                button22.Text = "Geçmişi göster";
            }
            
                


 
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
