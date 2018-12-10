using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string color;
            string name;
            string animal;
            string place;
            string adjective;
            string body;
            string superpower;
            string verb;

            color = Convert.ToString(txtColor.Text);
            name = Convert.ToString(txtName.Text);
            animal = Convert.ToString(txtAnimal.Text);
            place = Convert.ToString(txtPlace.Text);
            adjective = Convert.ToString(txtAdjective.Text);
            body = Convert.ToString(txtBody.Text);
            superpower = Convert.ToString(txtSuper.Text);
            verb = Convert.ToString(txtVerb.Text);

            lblStory.Text = "The " + color + " lion named " + name + " was the King of the jungle. One day he saw a[n] " +
                animal + "They were the King of the " + place + ". It looked like a " + adjective + " " + body + ". The use of " + superpower +
                ", " + name + " destroyed the " + animal + ". This is why " + name + " is the " + verb + " animal alive.";






        }

        
    }
}
