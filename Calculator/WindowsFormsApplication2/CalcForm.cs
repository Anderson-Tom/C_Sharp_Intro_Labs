    /*
 * C00174844
 * Tom Anderson
 * Lab 1
 * Question 1 
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

namespace WindowsFormsApplication2
{
    public partial class CalcForm : Form
    {
        String inputText = "";
        String calculationText = "";
        bool allowOperators = false;
        bool allowPoint = true;
       // bool allowEquals = false;
        bool isTotal = false;
        public CalcForm()
        {

            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        #region digits
        private void addInputText(char digit)
        {

            if (!allowOperators || isTotal)
            {
                inputText = "";
                allowOperators = true;
                isTotal = false;
            //    allowEquals = true;
         
            }
          //  allowEquals = true;
            inputText = inputText + digit;
            lblInput.Text = inputText;
        }
        private void lblInput_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            addInputText('1');
          
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            addInputText('2');
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            addInputText('3');
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            addInputText('4');
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            addInputText('5');
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            addInputText('6');
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            addInputText('7');
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            addInputText('8');
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            addInputText('9');
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            addInputText('0');
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (allowPoint)
            {
                addInputText('.');
                allowPoint = false;
            }
        }
        #endregion


        #region clear and backspace
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (inputText.Length > 0 && allowOperators)
            {
                if (inputText.EndsWith("."))                        //check if we are erasing a . 
                {
                    allowPoint = true;
                }
                inputText = inputText.Substring(0, inputText.Length - 1);
                lblInput.Text = inputText;
                if (inputText.Length == 0)
                {
                    allowOperators = false;
                }
            }
        }

        private void btnCAll_Click(object sender, EventArgs e)
        {
          
            calculationText = calcEngine.clearCalculation();
            lblCalculation.Text = calculationText;
            inputText = "";
            lblInput.Text = inputText;
            allowOperators = false;
            allowPoint = true;
        }

        private void btnCError_Click(object sender, EventArgs e)
        {
            inputText = "";
            lblInput.Text = inputText;
            allowPoint = true;
        }

        #endregion 

        #region mathematical operators
        private void addOperator(String numPlusOp)
        {
            allowOperators = false;
            allowPoint = true;
         //   allowEquals = false;
            lblCalculation.Text = calcEngine.buildCalculation(numPlusOp);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (allowOperators)
            {
                addOperator(inputText + " + ");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (allowOperators)
            {
                addOperator(inputText + " - ");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (allowOperators)
            {
                addOperator(inputText + " x ");
            }
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (allowOperators)
            {
                addOperator(inputText + " ÷ ");
            }
        }
        #endregion

        #region equals
        private void btnEquals_Click(object sender, EventArgs e)
        {                  
                if (allowOperators)
                {
                    addOperator(inputText);
                    lblCalculation.Text = calculationText;
                    inputText = calcEngine.doCalculation();
                    lblInput.Text = inputText;
                    calculationText = "";
                    isTotal = true;
                    allowOperators = true;
                }
                else
                {
                    inputText = "";
                    lblInput.Text = inputText;
                    allowPoint = true;
                }
      
         
        }
        #endregion
    }
}
