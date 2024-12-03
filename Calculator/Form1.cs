using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstnum;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "0" && button3.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "0" && button4.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "0" && button8.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "0" && button1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "0" && button2.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "0" && button5.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "0" && button6.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "0" && button7.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "0" && button9.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "1" && button15.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox3.Text = firstnum.ToString();
            textBox1.Text = "";
            operation = "+";
          
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            firstnum = Convert.ToDouble(textBox1.Text);
            textBox3.Text = firstnum.ToString();
            textBox1.Text = "";
            operation = "-";
          

        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox3.Text = firstnum.ToString();
            textBox1.Text = "";
            operation = "*";
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double secondNum;
            double result;

          
            secondNum = Convert.ToDouble(textBox1.Text);

            if(operation == "+")
            {
                result = (firstnum + secondNum);
                textBox2.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (operation == "-")
            {
                result = (firstnum - secondNum);
                textBox2.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (operation == "*")
            {
                result = (firstnum * secondNum);
                textBox2.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (operation == "/")
            {
                result = (firstnum / secondNum);
                textBox2.Text = Convert.ToString(result);
                firstnum = result;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text);
            textBox3.Text = firstnum.ToString();
            textBox1.Text = "";
            operation = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == "0" && button17.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
    }
}
