using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Calculator : Form
    {
        double fisrtNumber = 0, secondNumber = 0;
        string operation = "";
        string numberString = "";

        public Calculator()
        {
            InitializeComponent();
            lblResult.Text = "";
        }



        private void btnZero_Click(object sender, EventArgs e)
        {
            numberString += "0";

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            // Button 1  !! 
            show(numberString += "1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            show(numberString += "2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            show(numberString += "3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            show(numberString += "4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            show(numberString += "5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            show(numberString += "6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            show(numberString += "7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            show(numberString += "8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            show(numberString += "9");
        }

        // Special Buttons Here !!

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        // Operation Button Starts here !!

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(numberString);

            checkOperator();

            secondNumber = 0;
            operation = "";
            numberString = "";

        }

        private void checkOperator()
        {
            switch (operation)
            {
                case "+":

                    lblResult.Text = Convert.ToDouble(fisrtNumber + secondNumber).ToString();
                    break;
                case "-":
                    lblResult.Text = Convert.ToDouble(fisrtNumber - secondNumber).ToString();
                    break;
                case "*":
                    lblResult.Text = Convert.ToDouble(fisrtNumber * secondNumber).ToString();
                    break;
                case "/":
                    lblResult.Text = Convert.ToDouble(fisrtNumber / secondNumber).ToString();
                    break;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            fisrtNumber = Convert.ToDouble(numberString);
            show(numberString += "+");
            numberString = "";

            operation += "+";

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            fisrtNumber = Convert.ToDouble(numberString);
            show(numberString += "-");
            numberString = "";

            operation += "-";

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            fisrtNumber = Convert.ToDouble(numberString);
            show(numberString += "x");
            numberString = "";

            operation += "*";
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            numberString = "";
            fisrtNumber = 0;
            secondNumber = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            fisrtNumber = Convert.ToDouble(numberString);
            show(numberString += "/");
            numberString = "";

            operation += "/";
        }

        private void btnModulas_Click(object sender, EventArgs e)
        {

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

        }

        private void btnOneOverX_Click(object sender, EventArgs e)
        {

        }


        // Method For Showing Numbers in Label 
        private void show(string input)
        {
            lblResult.Text = input;
        }


    }
}
