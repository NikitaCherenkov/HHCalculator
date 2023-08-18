using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HHCalculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonCalc.Location = new Point(this.ClientSize.Width / 2 - buttonCalc.Width / 2, 100);
            this.Text = "Ковка";
        }

        private void FillForm()
        {
            if (ClassData.Qualities["anvil"] != 0) textBoxAnvil.Text = ClassData.Qualities["anvil"].ToString();
            if (ClassData.Qualities["hammer"] != 0) textBoxHammer.Text = ClassData.Qualities["hammer"].ToString();
            textBoxMat0.Text = string.Empty;
            textBoxMat1.Text = string.Empty;
            textBoxMat2.Text = string.Empty;
            textBoxMat3.Text = string.Empty;
            label5.Text = string.Empty;
        }

        private void Calculate()
        {
            double anvil;
            double hammer;
            if (!(double.TryParse(textBoxAnvil.Text, out anvil) & double.TryParse(textBoxHammer.Text, out hammer)))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
                return;
            }
            int count = 0;
            int max = 0;
            double ingridients = 0;
            double temp;
            if (textBoxMat0.Text != "")
            {
                max += 1;
                if (double.TryParse(textBoxMat0.Text, out temp))
                {
                    ingridients += temp;
                    count += 1;
                }
            }
            if (textBoxMat1.Text != "")
            {
                max += 1;
                if (double.TryParse(textBoxMat1.Text, out temp))
                {
                    ingridients += temp;
                    count += 1;
                }
            }
            if (textBoxMat2.Text != "")
            {
                max += 1;
                if (double.TryParse(textBoxMat2.Text, out temp))
                {
                    ingridients += temp;
                    count += 1;
                }
            }
            if (textBoxMat3.Text != "")
            {
                max += 1;
                if (double.TryParse(textBoxMat3.Text, out temp))
                {
                    ingridients += temp;
                    count += 1;
                }
            }
            if (count != 0 & count == max)
            {
                ingridients = ingridients / count;
                label5.Text = Math.Round(ClassFormulas.CraftSmith(anvil, hammer, ingridients), 2).ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка");
                return;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            FillForm();
            this.Hide();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            FillForm();
        }
    }
}
