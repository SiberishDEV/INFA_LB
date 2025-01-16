using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LB_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double q = Convert.ToDouble(textBox2.Text);
            double fx = 0;
            textBox3.Text = "Результаты " + Environment.NewLine;
            textBox3.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox3.Text += "При q = " + textBox2.Text + Environment.NewLine;
            if (radioButton1.Checked)
                fx = Math.Sinh(x);
            else if (radioButton2.Checked)
                fx = Math.Pow(x, 2);
            else if (radioButton3.Checked)
                fx = Math.Exp(x);

            double k;
            if (Math.Abs(x * q) > 10)
                k = Math.Log10(Math.Abs(fx) + Math.Abs(q));
            else if (Math.Abs(x * q) < 10)
                k = Math.Pow(Math.E, (fx + q));
            else
                k = fx + q;
            textBox3.Text += "K = " + k.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;
        }
    }
}
