using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Count_livestock;
            int Cost, months;
            double percent = 0, param = 1;
            double[] needs = {10, 3, 3, 0.05};
            double[] coef = {18, 30, 8, 50};
            double Sum, monthly_pay;
            bool status = true;

            Count_livestock = Convert.ToInt32(textBox1.Text);
            Cost = Convert.ToInt32(textBox2.Text);
            Sum = Convert.ToDouble(Count_livestock * Cost);
            
            if (checkBox1.Checked == true)
            {
                double Feed = 0;
                int size = needs.Length;
                int L = 210;
                for (int i = 0; i < size; i++)
                {
                    Feed += needs[i] * coef[i];
                }
                Feed *= (L * Count_livestock);    
                Sum += Feed;
                if (Sum * 0.2 < Feed)
                    status = false;
            }

            if (status == true)
            {
                textBox3.Text = Convert.ToString(Sum) + " тенге";
            }
            else
            {
                textBox3.Text = "Затраты на корм превышают общую сумму займа";
            }
            
            if (radioButton1.Checked == true)
            {
                percent = 4.0 / 100.0 / 12.0;
            }
            else if (radioButton2.Checked == true)
            {
                percent = 6.0 / 100.0 / 12.0;
            }
            else
            {
                textBox3.Text = "Вы не выбрали ставку по кредиту.";
                status = false;
            }

            if (status == true)
            {
                months = Convert.ToInt32(textBox4.Text);
                for (int i = 0; i < months; i++)
                {
                    param *= (1.0 + percent);
                }
                monthly_pay = Sum * (percent * param) / (param - 1);
                textBox5.Text = Convert.ToString(Convert.ToInt32(monthly_pay)) + " тенге";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;

            textBox4.Text = trackBar1.Value.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
