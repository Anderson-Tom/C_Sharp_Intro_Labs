/*
* C00174844
* Tom Anderson
* Lab 1
* Question 3
* 30/09/2015 
* */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiConvert
{
    public partial class Form1 : Form
    {
        private double conversionRate = 0;
        public Form1()
        {
            InitializeComponent();
        }


        //text change check it and perform conversion / else set label to zero
        private void doConversion()
        {
            double input = 0;
            //check we have a valid value and  a straightforward * coversion
            if (Double.TryParse(txtInput.Text, out input) && !rdbCelToFahr.Checked && !rdbFahrToCel.Checked)
            {           
                    lblOutput.Text = (conversionRate * input).ToString("0.##");           
            }
            // else check if we have a valid value and more complicated cel to fahr conversion
            else if (Double.TryParse(txtInput.Text, out input) && rdbCelToFahr.Checked)
            {
                lblOutput.Text = (input * 1.8 +32).ToString("0.##");
            }
            else if (Double.TryParse(txtInput.Text, out input) && rdbFahrToCel.Checked)
            {
                lblOutput.Text = ((input - 32) / 1.8).ToString("0.##");
               
            }
            else
            {
                lblOutput.Text = "0";
            }
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            doConversion();
        }

        private void rdbInchesToFeet_CheckedChanged(object sender, EventArgs e)
        {
            conversionRate = 0.083333333333333;
            doConversion();
        }

        private void rdbFeetToInches_CheckedChanged(object sender, EventArgs e)
        {
            conversionRate = 12;
            doConversion();
        }

        private void rdbPoundsToEuro_CheckedChanged(object sender, EventArgs e)
        {
            conversionRate = 1.265822;
            doConversion();
        }

        private void rdbEuroToPounds_CheckedChanged(object sender, EventArgs e)
        {
            conversionRate = 0.79;
            doConversion();
        }

        private void rdbCelToFahr_CheckedChanged(object sender, EventArgs e)
        {
            
            doConversion();
        }

        private void rdbFahrToCel_CheckedChanged(object sender, EventArgs e)
        {
            
            doConversion();
        }
    }
}
