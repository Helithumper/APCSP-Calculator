using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APCSP_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void button0_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }
        void button1_Click(object sender, EventArgs e)
        {
            resultBox.Text = "1";
        }
        void button2_Click(object sender, EventArgs e)
        {
            resultBox.Text = "2";
        }
        void button3_Click(object sender, EventArgs e)
        {
            resultBox.Text = "3";
        }
        void button4_Click(object sender, EventArgs e)
        {
            resultBox.Text = "4";
        }
        void button5_Click(object sender, EventArgs e)
        {
            resultBox.Text = "5";
        }
        void button6_Click(object sender, EventArgs e)
        {
            resultBox.Text = "6";
        }
        void button7_Click(object sender, EventArgs e)
        {
            resultBox.Text = "7";
        }
        void button8_Click(object sender, EventArgs e)
        {
            resultBox.Text = "8";
        }
        void button9_Click(object sender, EventArgs e)
        {
            resultBox.Text = "9";
        }
        void enterButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Enter";
        }
        void addButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Add";
        }
        void subtractButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Subtract";
        }
        void multButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Multiply";
        }
        void divideButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Divide";
        }
        void moduloButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Modulus";
        }
        void piButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Pi";
        }
        void clearButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "clear";
        }
        void graphingButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "Graph";
        }


    }
}
