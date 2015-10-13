/*
* C00174844
* Tom Anderson
* Lab 1
* Question 4
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

namespace WindowsFormsApplication5
{  
    public partial class Form1 : Form
    {

        private enum convType {SIMPLE , CELTOFAHR, FAHRTOCEL}
        private double conversionRate = 0;
        private bool simpleConversion, celToFahr, fahrToCell;
        public Form1()
        {
            InitializeComponent();
            setConverter("Inches", "Feet", .083333333333, convType.SIMPLE);  //setup a default rate/labels to begin
        }
        //set labels to appropriate values and set flags for conversion type to be checked in calculation function 
        private void setConverter(string inputLabel, string outputLabel, double conversionRate, convType type)
        {
            grpInput.Text = inputLabel;
            grpOutput.Text = outputLabel;
            this.conversionRate = conversionRate;
            if (type == convType.SIMPLE)
            {
                simpleConversion = true;
                celToFahr = false;
                fahrToCell = false;
            }
            else if (type == convType.CELTOFAHR)
            {
                simpleConversion = false;
                celToFahr = true;
                fahrToCell = false;
            }
            else
            {
                simpleConversion = false;
                celToFahr = false;
                fahrToCell = true;
            }

        }
        private void doConversion()
        {
            double input;
            if(simpleConversion && Double.TryParse(tbxInput.Text, out input))
            {
                lblOutput.Text = (input * conversionRate).ToString("0.##");
            }
            else if (celToFahr && Double.TryParse(tbxInput.Text, out input))
            {
                lblOutput.Text = (input * 1.8 + 32).ToString("0.##");
            }
            else if (fahrToCell &&  Double.TryParse(tbxInput.Text, out input))
            {
                lblOutput.Text = ((input - 32) / 1.8).ToString("0.##");
            }
            else
            {
                lblOutput.Text = "0";
            }
        }
    
        private void inchesToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConverter("Inches", "Feet", .083333333333,convType.SIMPLE);
            doConversion();
        }


        private void feetToInchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConverter( "Feet", "Inches", 12.0 , convType.SIMPLE);
            doConversion();
        }

        private void poundsToEuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConverter("Pounds", "Euro", 0.79, convType.SIMPLE);
            doConversion();
        }

        private void euroToPoundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConverter("Euro", "Pounds" ,1.2658227, convType.SIMPLE);
            doConversion();
        }

        private void celsiusToFahernheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConverter("Celsius", "Fahrenheit", 0, convType.CELTOFAHR);
            doConversion();
        }

        private void faherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConverter("Fahrenheit", "Celsius", 0, convType.FAHRTOCEL);
            doConversion();
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            doConversion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
