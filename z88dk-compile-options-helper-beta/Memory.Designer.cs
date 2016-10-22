namespace z88dk_compile_options_helper_beta
{
	partial class Memory
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
			this.button11 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.const_seg_option = new System.Windows.Forms.CheckBox();
			this.code_seg_option = new System.Windows.Forms.CheckBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label25 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.opt_code_option = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.code_seg_remove = new System.Windows.Forms.Button();
			this.code_seg_enter = new System.Windows.Forms.Button();
			this.codeSegTextbox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.const_seg_remove = new System.Windows.Forms.Button();
			this.const_seg_enter = new System.Windows.Forms.Button();
			this.constsegTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.LightGreen;
			this.button11.Location = new System.Drawing.Point(488, 259);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 151;
			this.button11.Text = "NEXT";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Coral;
			this.button4.Location = new System.Drawing.Point(488, 219);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 150;
			this.button4.Text = "Start Over";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 248);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(460, 56);
			this.textBox1.TabIndex = 149;
			// 
			// const_seg_option
			// 
			this.const_seg_option.AutoSize = true;
			this.const_seg_option.Location = new System.Drawing.Point(5, 22);
			this.const_seg_option.Name = "const_seg_option";
			this.const_seg_option.Size = new System.Drawing.Size(81, 17);
			this.const_seg_option.TabIndex = 143;
			this.const_seg_option.Text = "-const-seg=";
			this.const_seg_option.UseVisualStyleBackColor = true;
			this.const_seg_option.CheckedChanged += new System.EventHandler(this.const_seg_option_CheckedChanged);
			// 
			// code_seg_option
			// 
			this.code_seg_option.AutoSize = true;
			this.code_seg_option.Location = new System.Drawing.Point(4, 22);
			this.code_seg_option.Name = "code_seg_option";
			this.code_seg_option.Size = new System.Drawing.Size(82, 17);
			this.code_seg_option.TabIndex = 143;
			this.code_seg_option.Text = "--code-seg=";
			this.code_seg_option.UseVisualStyleBackColor = true;
			this.code_seg_option.CheckedChanged += new System.EventHandler(this.code_seg_option_CheckedChanged);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.CadetBlue;
			this.panel3.Controls.Add(this.label25);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.opt_code_option);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Location = new System.Drawing.Point(16, 186);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(298, 56);
			this.panel3.TabIndex = 154;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.ForeColor = System.Drawing.Color.Yellow;
			this.label25.Location = new System.Drawing.Point(163, 26);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(65, 13);
			this.label25.TabIndex = 155;
			this.label25.Text = "Nightly Build";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(163, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 154;
			this.label2.Text = "SDCC Only";
			// 
			// opt_code_option
			// 
			this.opt_code_option.AutoSize = true;
			this.opt_code_option.Location = new System.Drawing.Point(4, 22);
			this.opt_code_option.Name = "opt_code_option";
			this.opt_code_option.Size = new System.Drawing.Size(110, 17);
			this.opt_code_option.TabIndex = 143;
			this.opt_code_option.Text = "--opt-code-size     ";
			this.opt_code_option.UseVisualStyleBackColor = true;
			this.opt_code_option.CheckedChanged += new System.EventHandler(this.opt_code_option_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 16);
			this.label3.TabIndex = 131;
			this.label3.Text = "OPT Code Size";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(274, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 23);
			this.button1.TabIndex = 123;
			this.button1.Text = "?";
			this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.code_seg_option);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.code_seg_remove);
			this.panel1.Controls.Add(this.code_seg_enter);
			this.panel1.Controls.Add(this.codeSegTextbox);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Location = new System.Drawing.Point(16, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(298, 81);
			this.panel1.TabIndex = 157;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Yellow;
			this.label4.Location = new System.Drawing.Point(163, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 155;
			this.label4.Text = "SDCC Only";
			// 
			// code_seg_remove
			// 
			this.code_seg_remove.Enabled = false;
			this.code_seg_remove.Location = new System.Drawing.Point(196, 52);
			this.code_seg_remove.Name = "code_seg_remove";
			this.code_seg_remove.Size = new System.Drawing.Size(75, 23);
			this.code_seg_remove.TabIndex = 146;
			this.code_seg_remove.Text = "Remove";
			this.code_seg_remove.UseVisualStyleBackColor = true;
			this.code_seg_remove.Click += new System.EventHandler(this.code_seg_remove_Click);
			// 
			// code_seg_enter
			// 
			this.code_seg_enter.Enabled = false;
			this.code_seg_enter.Location = new System.Drawing.Point(110, 53);
			this.code_seg_enter.Name = "code_seg_enter";
			this.code_seg_enter.Size = new System.Drawing.Size(75, 23);
			this.code_seg_enter.TabIndex = 145;
			this.code_seg_enter.Text = "Enter";
			this.code_seg_enter.UseVisualStyleBackColor = true;
			this.code_seg_enter.Click += new System.EventHandler(this.code_seg_enter_Click);
			// 
			// codeSegTextbox
			// 
			this.codeSegTextbox.Enabled = false;
			this.codeSegTextbox.Location = new System.Drawing.Point(14, 55);
			this.codeSegTextbox.Name = "codeSegTextbox";
			this.codeSegTextbox.Size = new System.Drawing.Size(90, 20);
			this.codeSegTextbox.TabIndex = 144;
			this.codeSegTextbox.TextChanged += new System.EventHandler(this.codeSegTextbox_TextChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(11, 3);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(110, 16);
			this.label17.TabIndex = 131;
			this.label17.Text = "Code Segment";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(274, 3);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(21, 23);
			this.button9.TabIndex = 123;
			this.button9.Text = "?";
			this.toolTip1.SetToolTip(this.button9, "For compiling to bankswitched memory (like for the \r\n128\'s extra banks), sdcc tak" +
        "es additional parameters \r\n--code-seg= and --const-seg=");
			this.button9.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CadetBlue;
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.const_seg_option);
			this.panel2.Controls.Add(this.const_seg_remove);
			this.panel2.Controls.Add(this.const_seg_enter);
			this.panel2.Controls.Add(this.constsegTextBox);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Location = new System.Drawing.Point(16, 99);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(298, 81);
			this.panel2.TabIndex = 158;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Yellow;
			this.label6.Location = new System.Drawing.Point(163, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 13);
			this.label6.TabIndex = 155;
			this.label6.Text = "SDCC Only";
			// 
			// const_seg_remove
			// 
			this.const_seg_remove.Enabled = false;
			this.const_seg_remove.Location = new System.Drawing.Point(196, 52);
			this.const_seg_remove.Name = "const_seg_remove";
			this.const_seg_remove.Size = new System.Drawing.Size(75, 23);
			this.const_seg_remove.TabIndex = 146;
			this.const_seg_remove.Text = "Remove";
			this.const_seg_remove.UseVisualStyleBackColor = true;
			this.const_seg_remove.Click += new System.EventHandler(this.const_seg_remove_Click);
			// 
			// const_seg_enter
			// 
			this.const_seg_enter.Enabled = false;
			this.const_seg_enter.Location = new System.Drawing.Point(110, 53);
			this.const_seg_enter.Name = "const_seg_enter";
			this.const_seg_enter.Size = new System.Drawing.Size(75, 23);
			this.const_seg_enter.TabIndex = 145;
			this.const_seg_enter.Text = "Enter";
			this.const_seg_enter.UseVisualStyleBackColor = true;
			this.const_seg_enter.Click += new System.EventHandler(this.const_seg_enter_Click);
			// 
			// constsegTextBox
			// 
			this.constsegTextBox.Enabled = false;
			this.constsegTextBox.Location = new System.Drawing.Point(14, 55);
			this.constsegTextBox.Name = "constsegTextBox";
			this.constsegTextBox.Size = new System.Drawing.Size(90, 20);
			this.constsegTextBox.TabIndex = 144;
			this.constsegTextBox.TextChanged += new System.EventHandler(this.constsegTextBox_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 16);
			this.label5.TabIndex = 131;
			this.label5.Text = "List Files";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(274, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(21, 23);
			this.button2.TabIndex = 123;
			this.button2.Text = "?";
			this.toolTip1.SetToolTip(this.button2, "For compiling to bankswitched memory (like for the \r\n128\'s extra banks), sdcc tak" +
        "es additional parameters \r\n--code-seg= and --const-seg=");
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Memory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 317);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox1);
			this.Name = "Memory";
			this.Text = "Memory";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox const_seg_option;
		private System.Windows.Forms.CheckBox code_seg_option;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox opt_code_option;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button code_seg_remove;
		private System.Windows.Forms.Button code_seg_enter;
		private System.Windows.Forms.TextBox codeSegTextbox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button const_seg_remove;
		private System.Windows.Forms.Button const_seg_enter;
		private System.Windows.Forms.TextBox constsegTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label25;
	}
}