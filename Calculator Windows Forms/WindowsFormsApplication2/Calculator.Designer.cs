namespace WindowsFormsApplication2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_float = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_percentage = new System.Windows.Forms.Button();
            this.button_all_clear = new System.Windows.Forms.Button();
            this.button_plus_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(98, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(184, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.DarkOrange;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_plus.Location = new System.Drawing.Point(280, 292);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(80, 69);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.operator_click);
            this.button_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_click);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_equals.Location = new System.Drawing.Point(280, 367);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(80, 69);
            this.button_equals.TabIndex = 5;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_minus.Location = new System.Drawing.Point(280, 217);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(80, 69);
            this.button_minus.TabIndex = 6;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.operator_click);
            this.button_minus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m3_click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_multiplication.Location = new System.Drawing.Point(280, 142);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(80, 69);
            this.button_multiplication.TabIndex = 7;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = false;
            this.button_multiplication.Click += new System.EventHandler(this.operator_click);
            this.button_multiplication.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m2_click);
            // 
            // button_division
            // 
            this.button_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_division.Location = new System.Drawing.Point(280, 65);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(80, 69);
            this.button_division.TabIndex = 8;
            this.button_division.Text = "÷";
            this.button_division.UseVisualStyleBackColor = false;
            this.button_division.Click += new System.EventHandler(this.operator_click);
            this.button_division.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m1_click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(12, 365);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(166, 69);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_click);
            // 
            // button_float
            // 
            this.button_float.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_float.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_float.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_float.Location = new System.Drawing.Point(184, 365);
            this.button_float.Name = "button_float";
            this.button_float.Size = new System.Drawing.Size(80, 69);
            this.button_float.TabIndex = 10;
            this.button_float.Text = ",";
            this.button_float.UseVisualStyleBackColor = false;
            this.button_float.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 69);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(98, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 69);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(184, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 69);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(12, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 69);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(98, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 69);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(184, 140);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 69);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button_percentage
            // 
            this.button_percentage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_percentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_percentage.Location = new System.Drawing.Point(184, 65);
            this.button_percentage.Name = "button_percentage";
            this.button_percentage.Size = new System.Drawing.Size(80, 69);
            this.button_percentage.TabIndex = 17;
            this.button_percentage.Text = "%";
            this.button_percentage.UseVisualStyleBackColor = false;
            this.button_percentage.Click += new System.EventHandler(this.button_percentage_Click);
            // 
            // button_all_clear
            // 
            this.button_all_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_all_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_all_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_all_clear.Location = new System.Drawing.Point(12, 65);
            this.button_all_clear.Name = "button_all_clear";
            this.button_all_clear.Size = new System.Drawing.Size(80, 69);
            this.button_all_clear.TabIndex = 18;
            this.button_all_clear.Text = "C";
            this.button_all_clear.UseVisualStyleBackColor = false;
            this.button_all_clear.Click += new System.EventHandler(this.button_all_clear_Click);
            // 
            // button_plus_minus
            // 
            this.button_plus_minus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_plus_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus_minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_plus_minus.Location = new System.Drawing.Point(98, 65);
            this.button_plus_minus.Name = "button_plus_minus";
            this.button_plus_minus.Size = new System.Drawing.Size(80, 69);
            this.button_plus_minus.TabIndex = 19;
            this.button_plus_minus.Text = "+/-";
            this.button_plus_minus.UseVisualStyleBackColor = false;
            this.button_plus_minus.Click += new System.EventHandler(this.button_plus_minus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(372, 442);
            this.Controls.Add(this.button_plus_minus);
            this.Controls.Add(this.button_all_clear);
            this.Controls.Add(this.button_percentage);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_float);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_float;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_percentage;
        private System.Windows.Forms.Button button_all_clear;
        private System.Windows.Forms.Button button_plus_minus;
    }
}

