using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_06
{
    public partial class Form1 : Form
    {
        Decimal value = 0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operationPressed))
            {
                result.Clear();
            }
            operationPressed = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (!result.Text.Contains(","))
                {
                    result.Text += b.Text;
                }                
            }
            else
            {
                result.Text += b.Text;
            }            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //CE clear everything
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Decimal.Parse(result.Text);
            operationPressed = true;
        }

        public void button16_Click(object sender, EventArgs e)
        {
            Calculator.CalculatorBase calculate;

            switch (operation)
            {
                case "+":                    
                    calculate = new Calculator.Addition();
                    result.Text = calculate.Operation(value, Decimal.Parse(result.Text));
                    break;
                case "-":
                    calculate = new Calculator.Subtraction();
                    result.Text = calculate.Operation(value, Decimal.Parse(result.Text));
                    break;
                case "*":
                    calculate = new Calculator.Multiplication();
                    result.Text = calculate.Operation(value, Decimal.Parse(result.Text));
                    break;
                case "/":
                    calculate = new Calculator.Division();
                    result.Text = calculate.Operation(value, Decimal.Parse(result.Text));
                    break;
                case "sqrt":
                    calculate = new Calculator.SquareRoot();
                    result.Text = calculate.Operation(value, Decimal.Parse(result.Text));
                    //result.Text = calculate.Operation(value); 
                    break;
                case "^":
                    calculate = new Calculator.Power();
                    result.Text = calculate.Operation(value, Decimal.Parse(result.Text));
                    break;
                
                default:
                    break;
            }                     
        }
    }
}
