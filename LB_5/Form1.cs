using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if ((c >= 'а' && c <= 'я') || c == 'ё')
                {
                    count++;
                }
            }
            label1.Text = $"Количество строчных букв = {count}";
        }
    }
}
