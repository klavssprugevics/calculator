namespace kalkulators
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.digit_zero = new System.Windows.Forms.Button();
            this.screen_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_comma = new System.Windows.Forms.Button();
            this.digit_nine = new System.Windows.Forms.Button();
            this.digit_eight = new System.Windows.Forms.Button();
            this.digit_seven = new System.Windows.Forms.Button();
            this.digit_six = new System.Windows.Forms.Button();
            this.digit_five = new System.Windows.Forms.Button();
            this.digit_four = new System.Windows.Forms.Button();
            this.digit_three = new System.Windows.Forms.Button();
            this.digit_two = new System.Windows.Forms.Button();
            this.digit_one = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_power = new System.Windows.Forms.Button();
            this.button_module = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.history_textbox = new System.Windows.Forms.RichTextBox();
            this.history_label = new System.Windows.Forms.Label();
            this.clear_history_button = new System.Windows.Forms.Button();
            this.save_history_button = new System.Windows.Forms.Button();
            this.button_factorial = new System.Windows.Forms.Button();
            this.button_nat_log = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // digit_zero
            // 
            this.digit_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_zero.Location = new System.Drawing.Point(78, 303);
            this.digit_zero.Name = "digit_zero";
            this.digit_zero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_zero.Size = new System.Drawing.Size(48, 48);
            this.digit_zero.TabIndex = 0;
            this.digit_zero.Text = "0";
            this.digit_zero.UseVisualStyleBackColor = true;
            this.digit_zero.Click += new System.EventHandler(this.Digit_zero_Click);
            // 
            // screen_box
            // 
            this.screen_box.Location = new System.Drawing.Point(24, 81);
            this.screen_box.Multiline = true;
            this.screen_box.Name = "screen_box";
            this.screen_box.ReadOnly = true;
            this.screen_box.Size = new System.Drawing.Size(156, 43);
            this.screen_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klāvs Spruģevics ITB3";
            // 
            // button_comma
            // 
            this.button_comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_comma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_comma.Location = new System.Drawing.Point(24, 303);
            this.button_comma.Name = "button_comma";
            this.button_comma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_comma.Size = new System.Drawing.Size(48, 48);
            this.button_comma.TabIndex = 3;
            this.button_comma.Text = ".";
            this.button_comma.UseVisualStyleBackColor = true;
            this.button_comma.Click += new System.EventHandler(this.Button_comma_Click);
            // 
            // digit_nine
            // 
            this.digit_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_nine.Location = new System.Drawing.Point(132, 249);
            this.digit_nine.Name = "digit_nine";
            this.digit_nine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_nine.Size = new System.Drawing.Size(48, 48);
            this.digit_nine.TabIndex = 4;
            this.digit_nine.Text = "9";
            this.digit_nine.UseVisualStyleBackColor = true;
            this.digit_nine.Click += new System.EventHandler(this.Digit_nine_Click);
            // 
            // digit_eight
            // 
            this.digit_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_eight.Location = new System.Drawing.Point(78, 249);
            this.digit_eight.Name = "digit_eight";
            this.digit_eight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_eight.Size = new System.Drawing.Size(48, 48);
            this.digit_eight.TabIndex = 5;
            this.digit_eight.Text = "8";
            this.digit_eight.UseVisualStyleBackColor = true;
            this.digit_eight.Click += new System.EventHandler(this.Digit_eight_Click);
            // 
            // digit_seven
            // 
            this.digit_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_seven.Location = new System.Drawing.Point(24, 249);
            this.digit_seven.Name = "digit_seven";
            this.digit_seven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_seven.Size = new System.Drawing.Size(48, 48);
            this.digit_seven.TabIndex = 6;
            this.digit_seven.Text = "7";
            this.digit_seven.UseVisualStyleBackColor = true;
            this.digit_seven.Click += new System.EventHandler(this.Digit_seven_Click);
            // 
            // digit_six
            // 
            this.digit_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_six.Location = new System.Drawing.Point(132, 195);
            this.digit_six.Name = "digit_six";
            this.digit_six.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_six.Size = new System.Drawing.Size(48, 48);
            this.digit_six.TabIndex = 7;
            this.digit_six.Text = "6";
            this.digit_six.UseVisualStyleBackColor = true;
            this.digit_six.Click += new System.EventHandler(this.Digit_six_Click);
            // 
            // digit_five
            // 
            this.digit_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_five.Location = new System.Drawing.Point(78, 195);
            this.digit_five.Name = "digit_five";
            this.digit_five.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_five.Size = new System.Drawing.Size(48, 48);
            this.digit_five.TabIndex = 8;
            this.digit_five.Text = "5";
            this.digit_five.UseVisualStyleBackColor = true;
            this.digit_five.Click += new System.EventHandler(this.Digit_five_Click);
            // 
            // digit_four
            // 
            this.digit_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_four.Location = new System.Drawing.Point(24, 195);
            this.digit_four.Name = "digit_four";
            this.digit_four.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_four.Size = new System.Drawing.Size(48, 48);
            this.digit_four.TabIndex = 9;
            this.digit_four.Text = "4";
            this.digit_four.UseVisualStyleBackColor = true;
            this.digit_four.Click += new System.EventHandler(this.Digit_four_Click);
            // 
            // digit_three
            // 
            this.digit_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_three.Location = new System.Drawing.Point(132, 141);
            this.digit_three.Name = "digit_three";
            this.digit_three.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_three.Size = new System.Drawing.Size(48, 48);
            this.digit_three.TabIndex = 10;
            this.digit_three.Text = "3";
            this.digit_three.UseVisualStyleBackColor = true;
            this.digit_three.Click += new System.EventHandler(this.Digit_three_Click);
            // 
            // digit_two
            // 
            this.digit_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_two.Location = new System.Drawing.Point(78, 141);
            this.digit_two.Name = "digit_two";
            this.digit_two.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_two.Size = new System.Drawing.Size(48, 48);
            this.digit_two.TabIndex = 11;
            this.digit_two.Text = "2";
            this.digit_two.UseVisualStyleBackColor = true;
            this.digit_two.Click += new System.EventHandler(this.Digit_two_Click);
            // 
            // digit_one
            // 
            this.digit_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.digit_one.Location = new System.Drawing.Point(24, 141);
            this.digit_one.Name = "digit_one";
            this.digit_one.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.digit_one.Size = new System.Drawing.Size(48, 48);
            this.digit_one.TabIndex = 12;
            this.digit_one.Text = "1";
            this.digit_one.UseVisualStyleBackColor = true;
            this.digit_one.Click += new System.EventHandler(this.Digit_one_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_clear.Location = new System.Drawing.Point(132, 303);
            this.button_clear.Name = "button_clear";
            this.button_clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_clear.Size = new System.Drawing.Size(48, 48);
            this.button_clear.TabIndex = 13;
            this.button_clear.Text = "CE";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_plus.Location = new System.Drawing.Point(233, 87);
            this.button_plus.Name = "button_plus";
            this.button_plus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_plus.Size = new System.Drawing.Size(48, 48);
            this.button_plus.TabIndex = 14;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_minus.Location = new System.Drawing.Point(287, 87);
            this.button_minus.Name = "button_minus";
            this.button_minus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_minus.Size = new System.Drawing.Size(48, 48);
            this.button_minus.TabIndex = 15;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_multiplication.Location = new System.Drawing.Point(233, 141);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_multiplication.Size = new System.Drawing.Size(48, 48);
            this.button_multiplication.TabIndex = 16;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.Button_multiplication_Click);
            // 
            // button_division
            // 
            this.button_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_division.Location = new System.Drawing.Point(287, 141);
            this.button_division.Name = "button_division";
            this.button_division.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_division.Size = new System.Drawing.Size(48, 48);
            this.button_division.TabIndex = 17;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.Button_division_Click);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(24, 357);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(156, 23);
            this.button_result.TabIndex = 18;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            this.button_result.Click += new System.EventHandler(this.Button_result_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_sqrt.Location = new System.Drawing.Point(287, 249);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_sqrt.Size = new System.Drawing.Size(48, 48);
            this.button_sqrt.TabIndex = 19;
            this.button_sqrt.Text = "√";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.Button_sqrt_Click);
            // 
            // button_power
            // 
            this.button_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_power.Location = new System.Drawing.Point(233, 249);
            this.button_power.Name = "button_power";
            this.button_power.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_power.Size = new System.Drawing.Size(48, 48);
            this.button_power.TabIndex = 20;
            this.button_power.Text = "^";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.Button_power_Click);
            // 
            // button_module
            // 
            this.button_module.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_module.Location = new System.Drawing.Point(287, 303);
            this.button_module.Name = "button_module";
            this.button_module.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_module.Size = new System.Drawing.Size(48, 48);
            this.button_module.TabIndex = 21;
            this.button_module.Text = "%";
            this.button_module.UseVisualStyleBackColor = true;
            this.button_module.Click += new System.EventHandler(this.Button_module_Click_1);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_delete.Location = new System.Drawing.Point(233, 303);
            this.button_delete.Name = "button_delete";
            this.button_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_delete.Size = new System.Drawing.Size(48, 48);
            this.button_delete.TabIndex = 22;
            this.button_delete.Text = "->";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // history_textbox
            // 
            this.history_textbox.Location = new System.Drawing.Point(398, 76);
            this.history_textbox.Name = "history_textbox";
            this.history_textbox.ReadOnly = true;
            this.history_textbox.Size = new System.Drawing.Size(135, 260);
            this.history_textbox.TabIndex = 23;
            this.history_textbox.Text = "";
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.history_label.Location = new System.Drawing.Point(438, 39);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(58, 20);
            this.history_label.TabIndex = 24;
            this.history_label.Text = "History";
            // 
            // clear_history_button
            // 
            this.clear_history_button.Location = new System.Drawing.Point(398, 342);
            this.clear_history_button.Name = "clear_history_button";
            this.clear_history_button.Size = new System.Drawing.Size(68, 23);
            this.clear_history_button.TabIndex = 25;
            this.clear_history_button.Text = "Clear";
            this.clear_history_button.UseVisualStyleBackColor = true;
            this.clear_history_button.Click += new System.EventHandler(this.Clear_history_button_Click);
            // 
            // save_history_button
            // 
            this.save_history_button.Location = new System.Drawing.Point(472, 342);
            this.save_history_button.Name = "save_history_button";
            this.save_history_button.Size = new System.Drawing.Size(61, 23);
            this.save_history_button.TabIndex = 26;
            this.save_history_button.Text = "Save";
            this.save_history_button.UseVisualStyleBackColor = true;
            this.save_history_button.Click += new System.EventHandler(this.Save_history_button_Click);
            // 
            // button_factorial
            // 
            this.button_factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_factorial.Location = new System.Drawing.Point(287, 195);
            this.button_factorial.Name = "button_factorial";
            this.button_factorial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_factorial.Size = new System.Drawing.Size(48, 48);
            this.button_factorial.TabIndex = 27;
            this.button_factorial.Text = "!";
            this.button_factorial.UseVisualStyleBackColor = true;
            this.button_factorial.Click += new System.EventHandler(this.Button_factorial_Click);
            // 
            // button_nat_log
            // 
            this.button_nat_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_nat_log.Location = new System.Drawing.Point(233, 195);
            this.button_nat_log.Name = "button_nat_log";
            this.button_nat_log.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_nat_log.Size = new System.Drawing.Size(48, 48);
            this.button_nat_log.TabIndex = 28;
            this.button_nat_log.Text = "ln";
            this.button_nat_log.UseVisualStyleBackColor = true;
            this.button_nat_log.Click += new System.EventHandler(this.Button_nat_log_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveHistoryToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveHistoryToolStripMenuItem
            // 
            this.saveHistoryToolStripMenuItem.Name = "saveHistoryToolStripMenuItem";
            this.saveHistoryToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveHistoryToolStripMenuItem.Text = "Save history";
            this.saveHistoryToolStripMenuItem.Click += new System.EventHandler(this.SaveHistoryToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.conversionToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // conversionToolStripMenuItem
            // 
            this.conversionToolStripMenuItem.Name = "conversionToolStripMenuItem";
            this.conversionToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.conversionToolStripMenuItem.Text = "Conversion";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Checked = true;
            this.lightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(567, 391);
            this.Controls.Add(this.button_nat_log);
            this.Controls.Add(this.button_factorial);
            this.Controls.Add(this.save_history_button);
            this.Controls.Add(this.clear_history_button);
            this.Controls.Add(this.history_label);
            this.Controls.Add(this.history_textbox);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_module);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.digit_one);
            this.Controls.Add(this.digit_two);
            this.Controls.Add(this.digit_three);
            this.Controls.Add(this.digit_four);
            this.Controls.Add(this.digit_five);
            this.Controls.Add(this.digit_six);
            this.Controls.Add(this.digit_seven);
            this.Controls.Add(this.digit_eight);
            this.Controls.Add(this.digit_nine);
            this.Controls.Add(this.button_comma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screen_box);
            this.Controls.Add(this.digit_zero);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(583, 430);
            this.MinimumSize = new System.Drawing.Size(583, 430);
            this.Name = "Form1";
            this.Text = "Kalkulators - Klāvs Spruģevics";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit_zero;
        private System.Windows.Forms.TextBox screen_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_comma;
        private System.Windows.Forms.Button digit_nine;
        private System.Windows.Forms.Button digit_eight;
        private System.Windows.Forms.Button digit_seven;
        private System.Windows.Forms.Button digit_six;
        private System.Windows.Forms.Button digit_five;
        private System.Windows.Forms.Button digit_four;
        private System.Windows.Forms.Button digit_three;
        private System.Windows.Forms.Button digit_two;
        private System.Windows.Forms.Button digit_one;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_result;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_power;
        private System.Windows.Forms.Button button_module;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.RichTextBox history_textbox;
        private System.Windows.Forms.Label history_label;
        private System.Windows.Forms.Button clear_history_button;
        private System.Windows.Forms.Button save_history_button;
        private System.Windows.Forms.Button button_factorial;
        private System.Windows.Forms.Button button_nat_log;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
    }
}

