namespace z88dk_compile_options_helper_beta
{
	partial class floating_point
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floating_point));
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lmzxtinyFloatPoint = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.lmzxFloatPoint = new System.Windows.Forms.RadioButton();
			this.lmFloatPoint = new System.Windows.Forms.RadioButton();
			this.noFloatPoint = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button21 = new System.Windows.Forms.Button();
			this.panel10 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.f_signed_char = new System.Windows.Forms.CheckBox();
			this.label29 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel10.SuspendLayout();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightGreen;
			this.button3.Location = new System.Drawing.Point(478, 239);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 129;
			this.button3.Text = "NEXT";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Coral;
			this.button1.Location = new System.Drawing.Point(478, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 128;
			this.button1.Text = "Start Over";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 220);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(460, 56);
			this.textBox1.TabIndex = 127;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CadetBlue;
			this.panel2.Controls.Add(this.lmzxtinyFloatPoint);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.lmzxFloatPoint);
			this.panel2.Controls.Add(this.lmFloatPoint);
			this.panel2.Controls.Add(this.noFloatPoint);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(290, 128);
			this.panel2.TabIndex = 130;
			// 
			// lmzxtinyFloatPoint
			// 
			this.lmzxtinyFloatPoint.AutoSize = true;
			this.lmzxtinyFloatPoint.Enabled = false;
			this.lmzxtinyFloatPoint.Location = new System.Drawing.Point(26, 95);
			this.lmzxtinyFloatPoint.Name = "lmzxtinyFloatPoint";
			this.lmzxtinyFloatPoint.Size = new System.Drawing.Size(67, 17);
			this.lmzxtinyFloatPoint.TabIndex = 135;
			this.lmzxtinyFloatPoint.TabStop = true;
			this.lmzxtinyFloatPoint.Text = "lmzx_tiny";
			this.lmzxtinyFloatPoint.UseVisualStyleBackColor = true;
			this.lmzxtinyFloatPoint.CheckedChanged += new System.EventHandler(this.lmzxtinyFloatPoint_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(198, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 139;
			this.label2.Text = "Optional";
			// 
			// lmzxFloatPoint
			// 
			this.lmzxFloatPoint.AutoSize = true;
			this.lmzxFloatPoint.Enabled = false;
			this.lmzxFloatPoint.Location = new System.Drawing.Point(26, 72);
			this.lmzxFloatPoint.Name = "lmzxFloatPoint";
			this.lmzxFloatPoint.Size = new System.Drawing.Size(45, 17);
			this.lmzxFloatPoint.TabIndex = 134;
			this.lmzxFloatPoint.TabStop = true;
			this.lmzxFloatPoint.Text = "lmzx";
			this.lmzxFloatPoint.UseVisualStyleBackColor = true;
			this.lmzxFloatPoint.CheckedChanged += new System.EventHandler(this.lmzxFloatPoint_CheckedChanged);
			// 
			// lmFloatPoint
			// 
			this.lmFloatPoint.AutoSize = true;
			this.lmFloatPoint.Enabled = false;
			this.lmFloatPoint.Location = new System.Drawing.Point(26, 49);
			this.lmFloatPoint.Name = "lmFloatPoint";
			this.lmFloatPoint.Size = new System.Drawing.Size(35, 17);
			this.lmFloatPoint.TabIndex = 133;
			this.lmFloatPoint.TabStop = true;
			this.lmFloatPoint.Text = "lm";
			this.lmFloatPoint.UseVisualStyleBackColor = true;
			this.lmFloatPoint.CheckedChanged += new System.EventHandler(this.lmFloatPoint_CheckedChanged);
			// 
			// noFloatPoint
			// 
			this.noFloatPoint.AutoSize = true;
			this.noFloatPoint.Enabled = false;
			this.noFloatPoint.Location = new System.Drawing.Point(26, 26);
			this.noFloatPoint.Name = "noFloatPoint";
			this.noFloatPoint.Size = new System.Drawing.Size(106, 17);
			this.noFloatPoint.TabIndex = 132;
			this.noFloatPoint.TabStop = true;
			this.noFloatPoint.Text = "No Floating Point";
			this.noFloatPoint.UseVisualStyleBackColor = true;
			this.noFloatPoint.CheckedChanged += new System.EventHandler(this.noFloatPoint_CheckedChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(103, 16);
			this.label12.TabIndex = 130;
			this.label12.Text = "Floating Point";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(262, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(21, 23);
			this.button2.TabIndex = 122;
			this.button2.Text = "?";
			this.toolTip1.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
			this.button2.UseVisualStyleBackColor = true;
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 32766;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(262, 3);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(21, 23);
			this.button21.TabIndex = 123;
			this.button21.Text = "?";
			this.toolTip1.SetToolTip(this.button21, "By default sdcc makes char unsigned and this will cause problems for many existin" +
        "g \r\nprograms. This option changes char to signed as many existing programs expec" +
        "t. ");
			this.button21.UseVisualStyleBackColor = true;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.CadetBlue;
			this.panel10.Controls.Add(this.label27);
			this.panel10.Controls.Add(this.f_signed_char);
			this.panel10.Controls.Add(this.label29);
			this.panel10.Controls.Add(this.button21);
			this.panel10.Enabled = false;
			this.panel10.Location = new System.Drawing.Point(12, 146);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(290, 48);
			this.panel10.TabIndex = 140;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ForeColor = System.Drawing.Color.Yellow;
			this.label27.Location = new System.Drawing.Point(198, 8);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(58, 13);
			this.label27.TabIndex = 138;
			this.label27.Text = "SDCC only";
			// 
			// f_signed_char
			// 
			this.f_signed_char.AutoSize = true;
			this.f_signed_char.Location = new System.Drawing.Point(14, 20);
			this.f_signed_char.Name = "f_signed_char";
			this.f_signed_char.Size = new System.Drawing.Size(90, 17);
			this.f_signed_char.TabIndex = 137;
			this.f_signed_char.Text = "--fsigned-char";
			this.f_signed_char.UseVisualStyleBackColor = true;
			this.f_signed_char.CheckedChanged += new System.EventHandler(this.f_signed_char_CheckedChanged);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(11, 3);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(93, 16);
			this.label29.TabIndex = 131;
			this.label29.Text = "Signed Char";
			// 
			// floating_point
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 287);
			this.ControlBox = false;
			this.Controls.Add(this.panel10);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "floating_point";
			this.Text = "floating_point";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton lmzxtinyFloatPoint;
		private System.Windows.Forms.RadioButton lmzxFloatPoint;
		private System.Windows.Forms.RadioButton lmFloatPoint;
		private System.Windows.Forms.RadioButton noFloatPoint;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.CheckBox f_signed_char;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Button button21;
	}
}