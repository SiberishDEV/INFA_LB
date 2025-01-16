using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,981e-2";
            textBox2.Text = "-1,625e3";
            textBox3.Text = "0,512";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double b = Math.Sqrt(x + Math.Pow(Math.Abs(y), 0.25));
            double c = Math.Pow(Math.Pow(Math.E, (x - (1 / Math.Sin(z)))), 1.0 / 3.0);
            double a = Math.Pow(2, -x) * b * c;
            textBox4.Text += Environment.NewLine + "Результат a = " + a.ToString();
        }
    }
}
