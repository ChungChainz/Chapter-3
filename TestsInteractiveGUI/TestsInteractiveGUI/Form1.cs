using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score1;
            double score2;
            double score3;
            double score4;
            double score5;
            double average;

            score1 = Convert.ToDouble(txtScore1.Text);
            score2 = Convert.ToDouble(txtScore2.Text);
            score3 = Convert.ToDouble(txtScore3.Text);
            score4 = Convert.ToDouble(txtScore4.Text);
            score5 = Convert.ToDouble(txtScore5.Text);
            average = (score1 + score2 + score3 + score4 + score5) / 5;

            lblTotal.Text = "Average test score is " + average;





        }
    }
}
