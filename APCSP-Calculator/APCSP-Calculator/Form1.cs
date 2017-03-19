using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace APCSP_Calculator
{
    public partial class CalculatorForm : Form
    {
        CalculationHandler ch = new CalculationHandler();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void decimalButton_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue(".");
            ch.updateDisplay(resultBox);
        }
        void button0_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("0");
            ch.updateDisplay(resultBox);
        }
        void button1_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("1");
            ch.updateDisplay(resultBox);
        }
        void button2_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("2");
            ch.updateDisplay(resultBox);
        }
        void button3_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("3");
            ch.updateDisplay(resultBox);
        }
        void button4_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("4");
            ch.updateDisplay(resultBox);
        }
        void button5_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("5");
            ch.updateDisplay(resultBox);
        }
        void button6_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("6");
            ch.updateDisplay(resultBox);
        }
        void button7_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("7");
            ch.updateDisplay(resultBox);
        }
        void button8_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("8");
            ch.updateDisplay(resultBox);
        }
        void button9_Click(object sender, EventArgs e)
        {
            ch.appendCurrentValue("9");
            ch.updateDisplay(resultBox);
        }
        void enterButton_Click(object sender, EventArgs e)
        {
            ch.enterHandler();
            ch.updateDisplay(resultBox);
        }
        void addButton_Click(object sender, EventArgs e)
        {
            ch.handleOperation("+");
            ch.updateDisplay(resultBox);
        }
        void subtractButton_Click(object sender, EventArgs e)
        {
            ch.handleOperation("-");
            ch.updateDisplay(resultBox);
        }
        void multButton_Click(object sender, EventArgs e)
        {
            ch.handleOperation("*");
            ch.updateDisplay(resultBox);
        }
        void divideButton_Click(object sender, EventArgs e)
        {
            ch.handleOperation("/");
            ch.updateDisplay(resultBox);
        }
        void moduloButton_Click(object sender, EventArgs e)
        {
            ch.handleOperation("%");
            ch.updateDisplay(resultBox);
        }
        void piButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Pi";
            ch.updateDisplay(resultBox);
        }
        void clearButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "clear";
            ch.updateDisplay(resultBox);
        }
        void graphingButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Graph";
            ch.updateDisplay(resultBox);
        }


    }
    public class CalculationHandler
    {
        protected float previousResult = 0;
        protected float currentValue = 0;
        protected StringBuilder sb = new StringBuilder();
        protected string currentExpression = "";
        protected string operation = null;
        public CalculationHandler()
        {
        }
        public void updateDisplay(TextBox tb)
        {
            if (operation != null)
            {
                tb.Text = previousResult + " " + operation + " " + sb.ToString();
            }
            else
            {
                tb.Text = sb.ToString();
            }
        }
        public void appendCurrentValue(string inValue)
        {
            sb.Append(inValue);
        }
        public void handleOperation(string operation)
        {
            if (this.operation == null)
            {
                this.operation = operation;
                previousResult = float.Parse(sb.ToString(), CultureInfo.InvariantCulture);
                sb.Clear();
            }
            else
            {
                if (sb.ToString() != "") { 
                    previousResult = evaluate(previousResult, sb.ToString(), this.operation);
                    this.operation = operation;
                    sb.Clear();
                }
            
            }
        }
        public void enterHandler()
        {
            if (sb.ToString() != "")
            {
                previousResult = evaluate(previousResult, sb.ToString(), operation);
                operation = null;
                sb.Clear();
            }
            
        }
        public float evaluate(float oldValue, string newValue, string expression)
        {
            currentValue = float.Parse(newValue, CultureInfo.InvariantCulture);
            float result = 0;
            if(expression == "+")
            {
                result = oldValue + currentValue;
            }
            else if(expression == "-")
            {
                result = oldValue - currentValue;
            }
            else if (expression == "*")
            {
                result = oldValue * currentValue;
            }
            else if (expression == "/")
            {
                result = oldValue / currentValue;
            }
            else if (expression == "%")
            {
                result = oldValue % currentValue;
            }
            return result;
        }

        
    }
    
}
