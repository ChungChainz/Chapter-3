using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class lblDays : Form
    {
        public lblDays()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double days;
            double miles;
            double totaldays;
            double totalmiles;
            double sum;
            string moneySum;

            days = Convert.ToDouble(txtdaysRented.Text);
            miles = Convert.ToDouble(txtmilesUsed.Text);

            totaldays = days + 20;
            totalmiles = miles + .25;

            sum = totaldays + totalmiles;
            moneySum = sum.ToString("C");

            lblTotalCost.Text = "The total amount due is " + moneySum;
        


        }
    }
}
