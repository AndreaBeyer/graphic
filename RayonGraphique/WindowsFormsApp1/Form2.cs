using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class DavidGoodEnough : Form
    {
        public DavidGoodEnough()
        {
            InitializeComponent();
        }
        private SoundPlayer Player = new SoundPlayer();
        private void Form2_Load(object sender, EventArgs e)
        {
             
            Player.SoundLocation = @"C:\Users\CRM\Documents\Github\graphic\RayonGraphique\WindowsFormsApp1\david-goodenough-jdg.wav";
            Player.Play();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
