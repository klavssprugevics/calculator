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

    //TODO Clear math error with next button press
    //TODO valūtu konvertācija


    //TODO pārveidot, lai input validācijai izmantotu regex

    public partial class Form1 : Form
    {
        double operand1;
        double operand2;
        char operation;
        double result;
        string history = string.Empty;

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


        private void Button_plus_Click(object sender, EventArgs e)
        {
            if(is_last_character_operator())
            {
                return;
            }

            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "+";
            operation = '+';
            input = string.Empty;

        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }
            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "-";
            operation = '-';
            input = string.Empty;

        }

        private void Button_multiplication_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }


            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "*";
            operation = '*';
            input = string.Empty;

        }

        private void Button_division_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }

            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "/";
            operation = '/';
            input = string.Empty;

        }

        private void Button_result_Click(object sender, EventArgs e)
        {
            if(input == string.Empty)
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

        private void Button_clear_Click(object sender, EventArgs e)
        {
            this.screen_box.Text = string.Empty;
            input = string.Empty;

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

        private void Button_power_Click(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }

            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "^";
            operation = '^';
            input = string.Empty;
        }

        private void Button_sqrt_Click(object sender, EventArgs e)
        {
            if(is_last_character_operator())
            {
                return;
            }

            operand1 = Double.Parse(input);
            result = Math.Sqrt(operand1);

            history = "sqrt(" + this.screen_box.Text + ") =";
            history += result;
            this.history_textbox.AppendText(history + "\n");

            this.screen_box.Text = string.Concat(result);
            input = string.Concat(result);


        }

        private void Button_module_Click_1(object sender, EventArgs e)
        {
            if (is_last_character_operator())
            {
                return;
            }

            operand1 = Double.Parse(input);
            this.screen_box.Text = screen_box.Text + "%";
            operation = '%';
            input = string.Empty;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (is_textbox_empty())
            {
                return;
            }

            if (is_last_character_operator() == false && input.Length != 0)
            {
                input.Remove(input.Length - 1);

            }

            this.screen_box.Text = this.screen_box.Text.Remove(this.screen_box.Text.Length - 1);


        }
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
            

        private bool is_last_character_operator()
        {
            if (is_textbox_empty())
            {
                Console.WriteLine("TextBox is empty!");
                return true;
            }
            char last_character = this.screen_box.Text[this.screen_box.Text.Length - 1];


            if(last_character.Equals('+') || last_character.Equals('-') || last_character.Equals('/') ||
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

        private void Clear_history_button_Click(object sender, EventArgs e)
        {
            history = string.Empty;
            this.history_textbox.Text = string.Empty;
        }

        private void Save_history_button_Click(object sender, EventArgs e)
        {

            //Izveido jaunu saveFileDialog objektu, lai izveletos path
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save log";
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            //Ja path nav empty, tad ieraksta visu history failā un saglabā path
            if(path != "")
            {

                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(this.history_textbox.Text);
                streamWriter.Close();
            }
        }
    }
}
