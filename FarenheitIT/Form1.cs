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
        public double celcius, farenheit, temperatureEntree;
        public double celciusDecimal, farenheitDecimal;
        public bool ok;
        bool celciusVersFarenheit;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           string celcius1 = textBox1.Text;
            try
            {
                temperatureEntree = double.Parse(celcius1);
                ok = true;
            }
            catch
            {
                ok = false;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                celciusVersFarenheit = true;
            }
            
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                celciusVersFarenheit = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check1 = checkBox1.Checked && checkBox2.Checked;
            bool check2 = !(checkBox1.Checked || checkBox2.Checked);


            if (check1)
            {
                MessageBox.Show("Veuillez decochez une des 2 cases");
            }
            else if (check2)
            {
                MessageBox.Show("Veuillez cochez une des 2 cases");
            }

            if (celciusVersFarenheit && !check1 && !check2 )
            {
                
                farenheit = temperatureEntree * 9 / 5 + 32;
                farenheitDecimal = Math.Round(farenheit, 2);

                if (ok)
                {
                    MessageBox.Show("Conversion réussie ! " + Environment.NewLine + "Temperature en Celcius : " + temperatureEntree + " °C" + Environment.NewLine + "Temperature en Farenheit : " + farenheitDecimal + " °F");
                }
                else
                {
                    MessageBox.Show("La valeur est invalide !");
                }
            }
            else if (!check1 && !check2)
            {
                celcius = (temperatureEntree - 32) / 1.8;
                celciusDecimal = Math.Round(celcius, 2);

                if (ok)
                {
                    MessageBox.Show("Conversion réussie ! " + Environment.NewLine + "Temperature en farenheit : " + temperatureEntree + " °F" + Environment.NewLine + "Temperature en celcius : " + celciusDecimal + " °C");
                }
                else
                {
                    MessageBox.Show("La valeur est invalide !");
                }
            }
            
            
        }
    }
}
