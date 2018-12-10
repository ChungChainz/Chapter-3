using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtAnotherNumber.Text);
            sum = num1 + num2;
            lblResultAdd.Text = "The sum is " + sum;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int diff;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtAnotherNumber.Text);
            diff = num1 - num2;
            lblResultSub.Text = "The diff is " + diff;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtAnotherNumber.Text);
            product = num1 * num2;
            lblResultMulti.Text = "The product is " + product;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int quotient;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtAnotherNumber.Text);
            quotient = num1 / num2;
            lblResultDiv.Text = "The quotient is " + quotient;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txtEnterNumber.Text);
            num2 = Convert.ToInt32(txtAnotherNumber.Text);
            mod = num1 % num2;
            lblResultMod.Text = "The modulus is " + mod;
        }
    }
}

    