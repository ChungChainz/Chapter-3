using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometers;

            miles = Convert.ToDouble(txtMiles.Text);
            kilometers = miles * 1.6;
            lblKilometers.Text = "The kilometers equal " + kilometers;
        }
    }
}
