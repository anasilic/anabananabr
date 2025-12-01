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

namespace anabananabr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija;
            linija=textBox1+ˇ"|"+textBox3+ˇ"|"+textBox2;
            StreamWriter sw = new StreamWriter("anabanana.txt", true);
            sw.WriteLine(linija);
            sw.Close();
            MessageBox.Show("Podaci su snimljeni u datoteku anabanana.txt");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linija;
            StreamReader sr = new StreamReader("anabanana.txt");
            linija=sr.ReadToEnd();
            List<string> lstStud = new List<string>();
            while (linija != null)
            {
                linija=linija.Replace("|", "");
                lstStud.Add(linija);
                linija=sr.ReadLine();

            }
            lstStudenti.DataSource=lstStud;
            sr.Close();
        }
}
