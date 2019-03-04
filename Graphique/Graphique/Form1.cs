using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphique
{
    public partial class Form1 : Form
    {

        public string reponse;
        public int reponse1;
        public int nbreDeFois;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void m_myTestButton_Click(object sender, EventArgs e)
        {
            string reponse2 = null;

            for (int i = 0; i < nbreDeFois; i++)
            {
                reponse2 = reponse2 + Environment.NewLine + reponse;
            }
            MessageBox.Show("RecopY IT !" + Environment.NewLine + reponse2);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            reponse = textBox1.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string reponse2 = textBox2.Text;
            try
            {
                nbreDeFois = int.Parse(reponse2);
            }
            catch
            {
                nbreDeFois = 1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World !");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
