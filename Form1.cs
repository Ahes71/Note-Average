using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ort : Form
    {
        public Ort()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double vize) && double.TryParse(textBox2.Text, out double final))
            {
                if (vize >= 0 && vize <= 100 && final >= 0 && final <= 100)
                {
                    double ortalama = sonuc(vize, final);
                    textBox3.Text = ortalama.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Notlar 0 ile 100 arasında olmalıdır!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir not girin!");
            }
        }

        private double sonuc(double vize, double final)
        {
            return vize * 0.4 + final * 0.6;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}