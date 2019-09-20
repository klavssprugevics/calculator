using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulators
{
    public partial class Form1 : Form
    {
        double operand1;
        double operand2;
        char operation;
        double result;

        string input = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void Digit_one_Click(object sender, EventArgs e)
        {
            input += "1";
            this.screen_box.Text += "1";
        }

        private void Digit_two_Click(object sender, EventArgs e)
        {
            input += "2";
            this.screen_box.Text += "2";
        }

        private void Digit_three_Click(object sender, EventArgs e)
        {
            input += "3";
            this.screen_box.Text += "3";
        }

        private void Digit_four_Click(object sender, EventArgs e)
        {
            input += "4";
            this.screen_box.Text += "4";
        }

        private void Digit_five_Click(object sender, EventArgs e)
        {
            input += "5";
            this.screen_box.Text += "5";
        }

        private void Digit_six_Click(object sender, EventArgs e)
        {
            input += "6";
            this.screen_box.Text += "6";
        }

        private void Digit_seven_Click(object sender, EventArgs e)
        {
            input += "7";
            this.screen_box.Text += "7";
        }

        private void Digit_eight_Click(object sender, EventArgs e)
        {
            input += "8";
            this.screen_box.Text += "8";
        }

        private void Digit_nine_Click(object sender, EventArgs e)
        {
            input += "9";
            this.screen_box.Text += "9";
        }

        private void Digit_zero_Click(object sender, EventArgs e)
        {
            input += "0";
            this.screen_box.Text += "0";
        }

        //TODO Add verifications, so you cannot use 2 operators in a row.
        //TODO Add history
        //TODO Clear math error with next button press

        private void Button_plus_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "+";
            operation = '+';
            input = string.Empty;

        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "-";
            operation = '-';
            input = string.Empty;

        }

        private void Button_multiplication_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "*";
            operation = '*';
            input = string.Empty;

        }

        private void Button_division_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "/";
            operation = '/';
            input = string.Empty;

        }

        private void Button_result_Click(object sender, EventArgs e)
        {
            operand2 = Double.Parse(input);
            bool math_error = false;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if(operand2 == 0)
                    {
                        math_error = true;
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
            }

            if(math_error)
            {
                this.screen_box.Text = "MATH ERROR";
                input = string.Empty;
            }
            else
            {
                this.screen_box.Text = string.Concat(result);
                input = string.Concat(result);
            }
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            this.screen_box.Text = string.Empty;
            input = string.Empty;

        }

        private void Button_comma_Click(object sender, EventArgs e)
        {
            if(!this.screen_box.Text.EndsWith("."))
            {
                this.screen_box.Text += ".";
                input += ".";
            }
        }
    }
}
