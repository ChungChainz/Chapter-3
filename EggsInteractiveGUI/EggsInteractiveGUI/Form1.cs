using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int chicken1;
            int chicken2;
            int chicken3;
            int chicken4;
            int chicken5;
            int eggSum;
            int dozen;
            int eggRemainder;

            chicken1 = Convert.ToInt32(txtChicken1.Text);
            chicken2 = Convert.ToInt32(txtChicken2.Text);
            chicken3 = Convert.ToInt32(txtChicken3.Text);
            chicken4 = Convert.ToInt32(txtChicken4.Text);
            chicken5 = Convert.ToInt32(txtChicken5.Text);
            eggSum = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            dozen = eggSum / 12;
            eggRemainder = eggSum % 12;
            lblTotal.Text = eggSum + " eggs is " + dozen + " dozen with " + eggRemainder + " left over";

        }
    }
}
