using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHCalculator
{
    public partial class FormCommonCraft : Form
    {
        public FormCommonCraft()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int count = 0;
            double sum = 0;
            if (Double.TryParse(textBox1.Text, out double value1))
            {
                count++;
                sum += value1;
            }
            else textBox1.Text = "";
            if (Double.TryParse(textBox2.Text, out double value2))
            {
                count++;
                sum += value2;
            }
            else textBox2.Text = "";
            if (Double.TryParse(textBox3.Text, out double value3))
            {
                count++;
                sum += value3;
            }
            else textBox3.Text = "";
            if (Double.TryParse(textBox4.Text, out double value4))
            {
                count++;
                sum += value4;
            }
            else textBox4.Text = "";
            if (Double.TryParse(textBox5.Text, out double value5))
            {
                count++;
                sum += value5;
            }
            else textBox5.Text = "";
            if (Double.TryParse(textBox6.Text, out double value6))
            {
                count++;
                sum += value6;
            }
            else textBox6.Text = "";
            if (sum > 0 && count > 0)
            {
                sum = sum / count;
                label3.Text = "Результат: " + sum.ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            label3.Text = "Результат: ";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
