using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreensvilleRevenusGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int lastYear;
            int thisYear;
            int total;
            string moneyRevenue;

            lastYear = Convert.ToInt32(txtlastYear.Text);
            thisYear = Convert.ToInt32(txtthisYear.Text);
            total = thisYear + 25;
            moneyRevenue = total.ToString("C");
            lblrevTotal.Text = "is " + moneyRevenue;
            if (lastYear > thisYear)
            {
                lblmoreOrLess.Text = "less than";
            }
           
            else 
                lblmoreOrLess.Text = "greater than";
            }

              
        
        
           
                }
    }

