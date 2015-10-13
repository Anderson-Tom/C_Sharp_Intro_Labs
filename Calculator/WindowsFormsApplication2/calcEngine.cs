/*
* C00174844
* Tom Anderson
* Lab 1
* Question 1 
* 30/09/2015 
* */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication2
{
    static class calcEngine
    {
        static string calculation = "";
        

         internal static string buildCalculation(string input)
        {
        
             
            calculation = calculation + input;
        
            return calculation;
        }

        internal static string clearCalculation()
         {
            calculation = "";
            return calculation;
         }

        internal static string doCalculation()
        {

            List<String> components = new List<String>();
            String[] temp = calculation.Split(' ');
            int i;
            for (i = 0; i < temp.Length; i++)
            {
                components.Add(temp[i]);
            }

            calculation = "";
            //if we hit equals and no numbers entered output 0
            if (components.Count == 0)
            {
                return "0";
            }
                //if we have only one number just retrn it
            else if (components.Count == 1)
            {

                return components[0];
            }
            //go no further if the last item entered was an operator
            else if (!isOperator(components.ElementAt(components.Count() - 1)))
            {
                //calculate first 3 terms and replace them with the answer- repeat
                while (components.Count > 2)
                {
                    String result = calculate(components[1], components[0], components[2]);
                    components.RemoveRange(0, 3);
                    components.Insert(0, result);
                }

                //we will now be left with just the answwer so return it
                return components.ElementAt(0);

            }
            else
            {
                return "0";
            }
        }
        
        
        internal static Boolean isOperator (string component)
        {
            Boolean ret;
            switch (component)
            {
                case "+":
                case "-":
                case "x":
                case "÷":
                    ret = true;
                    break;
                default:
                    ret = false;
                    break; 
            }
            return ret;

        }

        private static string calculate(string operand, string firstParam, string lastParam )
        {
            string answer = "";
            double total;
            double firstNum = Double.Parse(firstParam);
            double lastNum = Double.Parse(lastParam);
            switch (operand)
            {
                case "+":
                total = firstNum + lastNum;
                    break;
                case "-":
                    total = firstNum - lastNum;
                    break;
                case "x":
                    total = firstNum * lastNum;
                    break;
                case "÷":
                    if (lastNum != 0)
                    {
                        total = firstNum / lastNum;
                    }
                    else
                    {
                        total = 0; //TO_DO -- proper divide by zero stuff 
                    }
                    break;
                default:
                    return "0";
            }

            
            return answer + total;

        }
    }
}
