/*
* C00174844
* Tom Anderson
* Lab 1
* Question 2
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

namespace WindowsFormsApplication3
    
{
 
    public partial class CurConverter : Form
    {

        public enum Currencys { AMER_DOLLAR = 1, BITCOIN, POUND, CAN_DOLLAR, EURO }; 

        public CurConverter()
        {
            InitializeComponent();
        }

        private void doConversion()
        {
            double input;

            //chec if rate selcted and valid input
            if (combFrom.SelectedIndex != 0 && combTo.SelectedIndex != 0 && Double.TryParse(txtInput.Text, out input)) 
            {         
                double euroValue = 0;
                double output = 0;
              //convert input to euros
                switch (combFrom.SelectedIndex)
                {
                    case (int)Currencys.AMER_DOLLAR:
                        euroValue = input / 1.11301;
                        break;
                    case (int)Currencys.POUND:
                        euroValue = input / 0.7282341798;
                        break;
                    case (int)Currencys.BITCOIN:
                        euroValue = input / 0.004814846904;
                        break;
                    case (int)Currencys.CAN_DOLLAR:
                        euroValue = input / 1.47590664;
                        break;
                    case (int)Currencys.EURO:
                        euroValue = input ;
                        break;
                }

                //convert value in euro to desired value
                switch (combTo.SelectedIndex)
                {
                    case (int)Currencys.AMER_DOLLAR:
                        output =euroValue * 1.11301;
                        break;
                    case (int)Currencys.POUND:
                        output = euroValue * 0.7282351793;
                        break;
                    case (int)Currencys.BITCOIN:
                        output = euroValue  * 0.004814846904;
                        break;
                    case (int)Currencys.CAN_DOLLAR:
                        output =euroValue * 1.47590664;
                        break;
                    case (int)Currencys.EURO:
                        output = euroValue;
                        break;
                }
                //allow more decimal places for bitcoin
                if (combTo.SelectedIndex == (int)Currencys.BITCOIN)
                {
                    output = Math.Truncate(output * 100000) / 100000;
                    lblResult.Text = string.Format("{0:N5}", output);
                }
                else
                {
                    output = Math.Truncate(output * 100) / 100;
                    lblResult.Text = string.Format("{0:N2}", output);
                }
            }
            else
            {
                lblResult.Text = "0";   //Output a default value of zero if
            }                           //we haven't got valid input or conversion selected
            
        }

        private void combFrom_SelectedIndexChanged(object sender, EventArgs e)
        {            
                doConversion();
        }

        private void comboTo_SelectedIndexChanged(object sender, EventArgs e)
        {

                doConversion();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            doConversion();
        }

        private void btnReuse_Click(object sender, EventArgs e)
        {
            txtInput.Text = lblResult.Text;
        }
    }
}
