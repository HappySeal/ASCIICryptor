using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptor
{
    public partial class Form1 : Form
    {
        int CoddingInt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach (char letter in textBox1.Text)
            {
                int unicode = letter + CoddingInt;
                char character = (char)unicode;
                textBox2.Text += Convert.ToString(character);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoddingInt += 1;
            label1.Text = Convert.ToString(CoddingInt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoddingInt -= 1;
            label1.Text = Convert.ToString(CoddingInt);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (char letter in textBox2.Text)
            {
                int unicode = letter - CoddingInt;
                char character = (char)unicode;
                textBox1.Text += Convert.ToString(character);
            }
        }
    }
}
