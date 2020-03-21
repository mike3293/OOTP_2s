﻿using System;
using System.Windows.Forms;

namespace OOP_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n&\r\n";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Calculator.Parse(textBox1.Lines);
                
                int intBase = 0;
                if (radioBatnHex.Checked)
                {
                    intBase = 16;
                }
                else if (radioBtnBinary.Checked)
                {
                    intBase = 2;
                }
                else if (radioBtnDecemical.Checked)
                {
                    intBase = 10;
                }
                else if (radioBtnOctal.Checked)
                {
                    intBase = 8;
                }

                textBox1.Clear();
                textBox1.AppendText("\r\n=" + Convert.ToString(result, intBase));
                textBox1.AppendText("\r\n");
            }
            catch (Exception)
            {
                textBox1.AppendText("\r\nERROR\r\n");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n|\r\n";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n^\r\n";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n~";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void radioBtnOctal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBatnHex_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioBtnDecemical_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
