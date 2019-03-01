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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void m_myTestButton_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<reponse1;i++)
            {
                MessageBox.Show(reponse);
            }
            
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
            reponse1 = int.Parse(reponse2);
        }
    }
}
