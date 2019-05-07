namespace SecurityQ1
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
            this.txt_Display = new System.Windows.Forms.TextBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_ninth = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.rtb_LogEntry = new System.Windows.Forms.RichTextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Display
            // 
            this.txt_Display.BackColor = System.Drawing.Color.Gray;
            this.txt_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Display.Location = new System.Drawing.Point(74, 42);
            this.txt_Display.Multiline = true;
            this.txt_Display.Name = "txt_Display";
            this.txt_Display.PasswordChar = '*';
            this.txt_Display.Size = new System.Drawing.Size(264, 30);
            this.txt_Display.TabIndex = 0;
            this.txt_Display.TextChanged += new System.EventHandler(this.txt_Display_TextChanged);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.DimGray;
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_one.Location = new System.Drawing.Point(93, 91);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(70, 36);
            this.btn_one.TabIndex = 2;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_four
            // 
            this.btn_four.BackColor = System.Drawing.Color.DimGray;
            this.btn_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_four.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_four.Location = new System.Drawing.Point(93, 144);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(70, 36);
            this.btn_four.TabIndex = 3;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = false;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.BackColor = System.Drawing.Color.DimGray;
            this.btn_seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seven.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_seven.Location = new System.Drawing.Point(93, 197);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(70, 36);
            this.btn_seven.TabIndex = 4;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = false;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.Location = new System.Drawing.Point(93, 250);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(70, 36);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.DimGray;
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zero.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_zero.Location = new System.Drawing.Point(171, 250);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(70, 36);
            this.btn_zero.TabIndex = 9;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.BackColor = System.Drawing.Color.DimGray;
            this.btn_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eight.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_eight.Location = new System.Drawing.Point(171, 197);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(70, 36);
            this.btn_eight.TabIndex = 8;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = false;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.DimGray;
            this.btn_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_five.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_five.Location = new System.Drawing.Point(171, 144);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(70, 36);
            this.btn_five.TabIndex = 7;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_two
            // 
            this.btn_two.BackColor = System.Drawing.Color.DimGray;
            this.btn_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_two.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_two.Location = new System.Drawing.Point(171, 91);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(70, 36);
            this.btn_two.TabIndex = 6;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = false;
            this.btn_two.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.DimGray;
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_enter.Location = new System.Drawing.Point(248, 250);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(70, 36);
            this.btn_enter.TabIndex = 13;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_ninth
            // 
            this.btn_ninth.BackColor = System.Drawing.Color.DimGray;
            this.btn_ninth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ninth.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ninth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ninth.Location = new System.Drawing.Point(248, 197);
            this.btn_ninth.Name = "btn_ninth";
            this.btn_ninth.Size = new System.Drawing.Size(70, 36);
            this.btn_ninth.TabIndex = 12;
            this.btn_ninth.Text = "9";
            this.btn_ninth.UseVisualStyleBackColor = false;
            this.btn_ninth.Click += new System.EventHandler(this.btn_ninth_Click);
            // 
            // btn_six
            // 
            this.btn_six.BackColor = System.Drawing.Color.DimGray;
            this.btn_six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_six.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_six.Location = new System.Drawing.Point(248, 144);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(70, 36);
            this.btn_six.TabIndex = 11;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = false;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_three
            // 
            this.btn_three.BackColor = System.Drawing.Color.DimGray;
            this.btn_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_three.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_three.Location = new System.Drawing.Point(248, 91);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(70, 36);
            this.btn_three.TabIndex = 10;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = false;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(125, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter PIN to Access!";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DimGray;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Location = new System.Drawing.Point(369, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(37, 37);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "&X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rtb_LogEntry
            // 
            this.rtb_LogEntry.BackColor = System.Drawing.Color.Gray;
            this.rtb_LogEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_LogEntry.Location = new System.Drawing.Point(12, 315);
            this.rtb_LogEntry.Name = "rtb_LogEntry";
            this.rtb_LogEntry.Size = new System.Drawing.Size(383, 184);
            this.rtb_LogEntry.TabIndex = 16;
            this.rtb_LogEntry.Text = "";
            this.rtb_LogEntry.TextChanged += new System.EventHandler(this.rtb_LogEntry_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Gray;
            this.lbl_name.Location = new System.Drawing.Point(71, 502);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(257, 13);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "SYED SHAHEER SARWAR | 022-16-113842";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(409, 520);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.rtb_LogEntry);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_ninth);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.txt_Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Display;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_ninth;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox rtb_LogEntry;
        private System.Windows.Forms.Label lbl_name;
    }
}

