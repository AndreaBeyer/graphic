using System;
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
    public partial class Form1 : Form
    {
        public double rayon, circonference, surface;
        bool ok;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rayonString = textBox1.Text;
            try
            {
                rayon = double.Parse(rayonString);
                ok = true;
            }
            catch
            {
                ok = false;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ok)
            {
                
                DavidGoodEnough Form3 = new DavidGoodEnough();

            Form3.Show();


            }
            else
            {
                circonference = Math.PI * rayon * 2;

                surface = Math.PI * Math.Pow(rayon, 2);
                textBox2.Text = Math.Round(circonference,2).ToString();
                textBox3.Text = Math.Round(surface,2).ToString();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
