using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double E1 = Convert.ToDouble(textBox1.Text);
                double E2 = Convert.ToDouble(textBox2.Text);
                double N1 = Convert.ToDouble(textBox4.Text);
                double N2 = Convert.ToDouble(textBox3.Text);

                double rad = Math.Atan2((E2 - E1), (N2 - N1));
                double deg = rad * 180/ Math.PI;
                if (deg < 0)
                    deg += 360;
                MessageBox.Show("Azimuth Result = " + deg + " Degree");
            }
            catch(Exception)
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
