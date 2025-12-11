using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anabanananana
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            line = textBox1 + "|" + textBox2 + "|" + textBox3 + "|" + textBox4;
            StreamWriter sw = new StreamWriter("imena.txt");
            sw.WriteLine(line);
            sw.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            MessageBox.Show("Podatci su spremljeni!");


        }
    }
}
