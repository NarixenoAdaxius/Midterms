using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Initialize variables
        private double num1, num2, answer;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //get User inputs
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            String operation = cbOperator.Text;

            CalculatorClass Calculate = new CalculatorClass();
            
            //Operations
            if (operation == "+")
            {
                Calculate.SumEvent += new Formulas(Calculate.addNumbers);
                answer = Calculate.Sum(num1, num2);
                lblDisplayTotal.Text = answer.ToString();
                Calculate.SumEvent -= new Formulas(Calculate.addNumbers);
            }
            else if (operation == "-")
            {
                Calculate.DifferenceEvent += new Formulas(Calculate.subtractNumbers);
                answer = Calculate.Difference(num1, num2);
                lblDisplayTotal.Text = answer.ToString();
                Calculate.DifferenceEvent -= new Formulas(Calculate.subtractNumbers);
            }
            else if (operation == "*")
            {
                Calculate.ProductEvent += new Formulas(Calculate.multiplyNumbers);
                answer = Calculate.Product(num1, num2);
                lblDisplayTotal.Text = answer.ToString();
                Calculate.ProductEvent -= new Formulas(Calculate.multiplyNumbers);
            }
            else if (operation == "/")
            {
                Calculate.QuotientEvent += new Formulas(Calculate.divideNumbers);
                answer = Calculate.Quotient(num1, num2);
                lblDisplayTotal.Text = answer.ToString();
                Calculate.QuotientEvent -= new Formulas(Calculate.divideNumbers);
            }

            // AUTHOR: N4RX(DAUIS)
        }
    }
}
