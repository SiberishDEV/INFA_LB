using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] arr = new double[25];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.NextDouble() * 20 - 10;
                listBox1.Items.Add($"Элемент {i}: {arr[i]}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int negativeCount = 0;
            int inRangeCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeCount++;
                }

                if (arr[i] >= 1 && arr[i] <= 2)
                {
                    inRangeCount++;
                }
            }
            listBox2.Items.Add($"Количество отрицательных чисел: {negativeCount}");
            listBox2.Items.Add($"Количество чисел принадлежащих отрезку [1, 2]: {inRangeCount}");
        }
    }
}
