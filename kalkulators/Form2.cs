using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulators
{
	public partial class Form2 : Form
	{
		// User input value.
		double curr_input = double.NaN;
		 
		// Currency coefficients.	    EUR          USD      PLN
		double[,] coefficient_table = {{1,           1.09361, 4.37802},
										  {0.9136,   1,       3.9982},
										  { 0.22781, 0.24917, 1 }};

		string[] currency_table = { "EUR", "USD", "PLN" };


		public Form2()
		{
			InitializeComponent();
		}


		private void Button_convert_Click(object sender, EventArgs e)
		{
			//Checks for invalid input
			string double_regex = @"^\d+(\.)?(\d+)?$";
			string input = conversion_input.Text;

			if (Regex.IsMatch(input, double_regex))
			{
				curr_input = double.Parse(input);
				conversion();
			}
			else
			{
				MessageBox.Show("Make sure input isn't empty and contains only numbers!");
				return;
			}
		}

		private void conversion()
		{
			// Finds the selected currencies in the currency table and gets the index.
			// Takes the selected coefficient from the table and calculates the converted value.
			int coefficient_index1 = -1; 
			int coefficient_index2 = -1;

			coefficient_index1 = Array.IndexOf(currency_table, conversion_from.Text);
			coefficient_index2 = Array.IndexOf(currency_table, conversion_to.Text);

			double result = curr_input * coefficient_table[coefficient_index1, coefficient_index2];
			conversion_output.Text = result.ToString();
		}

		private void Button_reverse_Click(object sender, EventArgs e)
		{
			string temp = conversion_from.Text;
			conversion_from.Text = conversion_to.Text;
			conversion_to.Text = temp;
			Button_convert_Click(sender, e);
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
			}
		}
	}
}
