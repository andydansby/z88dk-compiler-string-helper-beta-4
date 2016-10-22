namespace z88dk_compile_options_helper_beta
{
	partial class verbose_options
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CadetBlue;
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.checkBox5);
			this.panel5.Controls.Add(this.checkBox4);
			this.panel5.Controls.Add(this.checkBox3);
			this.panel5.Controls.Add(this.checkBox2);
			this.panel5.Controls.Add(this.checkBox1);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.button4);
			this.panel5.Location = new System.Drawing.Point(12, 12);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(311, 148);
			this.panel5.TabIndex = 121;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(223, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 138;
			this.label1.Text = "Optional";
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(22, 114);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(100, 17);
			this.checkBox5.TabIndex = 137;
			this.checkBox5.Text = "Print out help -h";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(22, 91);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(172, 17);
			this.checkBox4.TabIndex = 136;
			this.checkBox4.Text = "Print out compiler specs -specs";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(22, 68);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(235, 17);
			this.checkBox3.TabIndex = 135;
			this.checkBox3.Text = "Make the assembler more verbose -z80-verb";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(22, 45);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(274, 17);
			this.checkBox2.TabIndex = 134;
			this.checkBox2.Text = "Output all commands that are run (-vn suppresses) -v";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(22, 22);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(189, 17);
			this.checkBox1.TabIndex = 133;
			this.checkBox1.Text = "Run the compile stages silently -vn";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(11, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(124, 16);
			this.label13.TabIndex = 131;
			this.label13.Text = "Verbose Options";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(407, 1);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(21, 23);
			this.button4.TabIndex = 123;
			this.button4.Text = "?";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 201);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(460, 56);
			this.textBox1.TabIndex = 122;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Coral;
			this.button1.Location = new System.Drawing.Point(478, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 123;
			this.button1.Text = "Start Over";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightGreen;
			this.button3.Location = new System.Drawing.Point(478, 218);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 124;
			this.button3.Text = "NEXT";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 32766;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// verbose_options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 269);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel5);
			this.Name = "verbose_options";
			this.Text = "verbose_options";
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}