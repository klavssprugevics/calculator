using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kalkulators
{
    //TODO sākumā var izvēlēties negatīvu skaitli
    //TODO message box to close when pressing "X"
    //TODO Nicer dizains
    //TODO Conversion -> New form vai arī expanded windows


    //BUGS
    // operand, operation, C, new operation -> crash

    public partial class Form1 : Form
    {
        double operand1;                    // 1st operand, parsed after selecting an operation.
        double operand2;                    // 2nd operand, parsed after pressing "=" button.
        char operation;                     // Operation selected by the user with buttons.
        double result;                      // Result after an operation, afterwards Operand1 = result.

        string history = string.Empty;      // String that contains all the equation history.
        string input = string.Empty;        // String that's being parsed into operand1/operand2.



        public Form1()
        {
            InitializeComponent();
        }


        // Number button click events.
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

        private void Button_comma_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }

            if (!this.screen_box.Text.EndsWith("."))
            {
                this.screen_box.Text += ".";
                input += ".";
            }
        }


        // Operation(2 operands) button click events.
        private void Button_plus_Click(object sender, EventArgs e)
        {
            if(is_last_character_operator())
            {
                // If the user wants to change the operator, they can just change by pressing on a different one.
                this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
                this.screen_box.Text += "+";
                operation = '+';
                return;
            }
            parse_two_operand_operation('+');
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
                this.screen_box.Text += "-";
                operation = '-';
                return;
            }
            parse_two_operand_operation('-');
        }

        private void Button_multiplication_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
                this.screen_box.Text += "*";
                operation = '*';
                return;
            }
            parse_two_operand_operation('*');
        }

        private void Button_division_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
                this.screen_box.Text += "/";
                operation = '/';
                return;
            }
            parse_two_operand_operation('/');
        }

        private void Button_power_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
                this.screen_box.Text += "^";
                operation = '^';
                return;
            }
            parse_two_operand_operation('^');
        }

        private void Button_module_Click_1(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
                this.screen_box.Text += "%";
                operation = '%';
                return;
            }
            parse_two_operand_operation('%');
        }
        

        // Operation(1 operand) button click events.
        private void Button_sqrt_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }
            operand1 = Double.Parse(input);
            parse_one_operand_operation("sqrt");
        }

        private void Button_nat_log_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }

            operand1 = Double.Parse(input);

            if (operand1 <= 0)
            {
                return;
            }
            parse_one_operand_operation("ln");
        }

        private void Button_factorial_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }
            operand1 = Double.Parse(input);

            if (operand1 % 1 != 0 || operand1 < 0)
            {

                return;
            }
            parse_one_operand_operation("fact");
        }


        // Clear & delete button click events.

        // Completely wipes everything except for the history.
        private void Button_clear_Click(object sender, EventArgs e)
        {
            this.screen_box.Text = string.Empty;
            input = string.Empty;
            operand1 = 0;
            operand2 = 0;
        }

        // Deletes the last character in the input (not operand).
        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (is_textbox_empty())
            {
                return;
            }

            if (is_last_character_operator() == false && input.Length != 0)
            {
                input = input.Remove(input.Length - 1);
            }
            this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);
        }


        // History textbox button click events.
        private void Clear_history_button_Click(object sender, EventArgs e)
        {
            history = string.Empty;
            this.history_textbox.Text = string.Empty;
        }

        private void Save_history_button_Click(object sender, EventArgs e)
        {

            // Creates a new SaveFileDialog object, to choose the save path.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save log";
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            if (path != "")
            {
                // Writes the history to the desired filepath.
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(this.history_textbox.Text);
                streamWriter.Close();
            }
        }


        // Menu strip button click events.

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string quitMessage = "Are you sure you want to quit?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;


            DialogResult result = MessageBox.Show(quitMessage, "", buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();

            }
        }

        private void SaveHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_history_button_Click(sender, e);
        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lightToolStripMenuItem.Checked)
            {
                lightToolStripMenuItem.Checked = false;
                darkToolStripMenuItem.Checked = true;

                this.BackColor = System.Drawing.Color.LightSlateGray;
            }
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (darkToolStripMenuItem.Checked)
            {
                darkToolStripMenuItem.Checked = false;
                lightToolStripMenuItem.Checked = true;

                this.BackColor = SystemColors.Control;
            }
        }



        // Main function for calculating the result after "=" is clicked.
        private void Button_result_Click(object sender, EventArgs e)
        {
            // Checks whether the input(2nd operand) is empty.
            if(input == "")
            {
                return;
            }

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
                case '%':
                    result = operand1 % operand2;
                    break;
                case '^':
                    result = Math.Pow(operand1, operand2);
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
                default:
                    {
                        return;
                    }
            }

            if(math_error)
            {
                MessageBox.Show("MATH ERROR");
                this.screen_box.Text = string.Empty;
                input = string.Empty;
                operand1 = 0;
                operand2 = 0;
            }
            else
            {
                operand1 = result;
                operation = ' ';

                history = this.screen_box.Text + "=";
                history += result;
                this.history_textbox.AppendText(history + "\n");
                this.screen_box.Text = string.Concat(result);
                input = string.Concat(result);
            }
        }


        // Various helper functions definitions.

        // Checks whether the textbox is empty.
        private bool is_textbox_empty()
        {
            if (this.screen_box.Text.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // All operations that require only one operand are defined here.
        private void parse_one_operand_operation(string oper)
        {
            switch (oper)
            {
                case "sqrt":
                    result = Math.Sqrt(operand1);
                    history = "sqrt(" + this.screen_box.Text + ") =";
                    break;
                case "ln":
                    result = Math.Log(operand1);
                    history = "ln(" + this.screen_box.Text + ") =";
                    break;
                case "fact":
                    result = factorial(operand1);
                    history = this.screen_box.Text + "! = ";
                    break;
            }

            history += result;
            this.history_textbox.AppendText(history + "\n");
            this.screen_box.Text = string.Concat(result);
            input = string.Concat(result);
        }

        // All operations that require two operands are defined here.
        private void parse_two_operand_operation(char oper)
        {
            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + oper;
            operation = oper;
            input = string.Empty;
        }

        // Recurrent function for a factorial.
        private double factorial(double n)
        {
            if (n == 1)
                return 1;

            return n * factorial(n - 1);

        }

        // Checks whether the last character in the textbox is an operator.
        private bool is_last_character_operator()
        {
            if (is_textbox_empty())
            {
                Console.WriteLine("TextBox is empty!");
                return true;
            }
            char last_character = this.screen_box.Text[this.screen_box.Text.Length - 1];


            if (last_character.Equals('+') || last_character.Equals('-') || last_character.Equals('/') ||
                last_character.Equals('*') || last_character.Equals('%') || last_character.Equals('^'))
            {
                Console.WriteLine($"Last character:{last_character} ");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}