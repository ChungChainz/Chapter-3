using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double oldSalary;
            double newSalary;
            string moneyProduct;

            oldSalary = Convert.ToDouble(txtSalary.Text);
            newSalary = oldSalary * 1.04;
            moneyProduct = newSalary.ToString("C");
            lblTotalSalary.Text = "Employee's next year salary is " + moneyProduct;
        }
    }
}
