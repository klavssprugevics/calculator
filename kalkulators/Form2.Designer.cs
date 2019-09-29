namespace kalkulators
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.conversion_input = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.conversion_from = new System.Windows.Forms.ComboBox();
			this.conversion_to = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.conversion_output = new System.Windows.Forms.TextBox();
			this.button_convert = new System.Windows.Forms.Button();
			this.button_reverse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(69, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Currency exchange";
			// 
			// conversion_input
			// 
			this.conversion_input.Location = new System.Drawing.Point(74, 72);
			this.conversion_input.Name = "conversion_input";
			this.conversion_input.Size = new System.Drawing.Size(178, 20);
			this.conversion_input.TabIndex = 1;
			this.conversion_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Amount:";
			// 
			// conversion_from
			// 
			this.conversion_from.FormattingEnabled = true;
			this.conversion_from.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "PLN"});
			this.conversion_from.Location = new System.Drawing.Point(74, 98);
			this.conversion_from.Name = "conversion_from";
			this.conversion_from.Size = new System.Drawing.Size(178, 21);
			this.conversion_from.TabIndex = 3;
			this.conversion_from.Text = "EUR";
			// 
			// conversion_to
			// 
			this.conversion_to.FormattingEnabled = true;
			this.conversion_to.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "PLN"});
			this.conversion_to.Location = new System.Drawing.Point(74, 125);
			this.conversion_to.Name = "conversion_to";
			this.conversion_to.Size = new System.Drawing.Size(178, 21);
			this.conversion_to.TabIndex = 4;
			this.conversion_to.Text = "EUR";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label3.Location = new System.Drawing.Point(24, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "From:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.Location = new System.Drawing.Point(39, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "To:";
			// 
			// conversion_output
			// 
			this.conversion_output.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.conversion_output.Location = new System.Drawing.Point(74, 181);
			this.conversion_output.Name = "conversion_output";
			this.conversion_output.Size = new System.Drawing.Size(178, 20);
			this.conversion_output.TabIndex = 7;
			this.conversion_output.Text = "Ouput";
			this.conversion_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button_convert
			// 
			this.button_convert.Location = new System.Drawing.Point(74, 152);
			this.button_convert.Name = "button_convert";
			this.button_convert.Size = new System.Drawing.Size(121, 23);
			this.button_convert.TabIndex = 8;
			this.button_convert.Text = "Convert!";
			this.button_convert.UseVisualStyleBackColor = true;
			this.button_convert.Click += new System.EventHandler(this.Button_convert_Click);
			// 
			// button_reverse
			// 
			this.button_reverse.Location = new System.Drawing.Point(201, 152);
			this.button_reverse.Name = "button_reverse";
			this.button_reverse.Size = new System.Drawing.Size(51, 23);
			this.button_reverse.TabIndex = 9;
			this.button_reverse.Text = "↔️";
			this.button_reverse.UseVisualStyleBackColor = true;
			this.button_reverse.Click += new System.EventHandler(this.Button_reverse_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 231);
			this.Controls.Add(this.button_reverse);
			this.Controls.Add(this.button_convert);
			this.Controls.Add(this.conversion_output);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.conversion_to);
			this.Controls.Add(this.conversion_from);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.conversion_input);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Valūtas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox conversion_input;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox conversion_from;
		private System.Windows.Forms.ComboBox conversion_to;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox conversion_output;
		private System.Windows.Forms.Button button_convert;
		private System.Windows.Forms.Button button_reverse;
	}
}