using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_20190140080;

namespace ServerConfigForm_P5_080
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            labelOnOrOff.Text = "Server OFF";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelOnOrOff_Click(object sender, EventArgs e)
        {

        }
    }
}
