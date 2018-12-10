using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            double payRate;
            double hoursWorked;
            double grossPay;
            double federalTax;
            double stateTax;
            double netPay;
         
            string moneyGross;
            string moneyFederal;
            string moneyState;
            string moneyNet;
            
            payRate = Convert.ToDouble(txtRate.Text);
            hoursWorked = Convert.ToDouble(txtHours.Text);
            grossPay = payRate * hoursWorked;
            federalTax = grossPay * .15;
            stateTax = grossPay * .05;
            netPay = grossPay - (federalTax + stateTax);
           
            moneyGross = grossPay.ToString("C");
            moneyFederal = federalTax.ToString("C");
            moneyState = stateTax.ToString("C");
            moneyNet = netPay.ToString("C");

            lblgrossTotal.Text = ("The total gross pay = ") + moneyGross;
            lblfederalTotal.Text = ("The total federal tax = ") + moneyFederal;
            lblstateTotal.Text = ("The total state tax = ") + moneyState;
            lblnetTotal.Text = ("The total net pay = ") + moneyNet;










        }
    }
}
