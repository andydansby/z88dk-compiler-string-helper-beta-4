namespace z88dk_compile_options_helper_beta
{
	partial class Output_Media
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.media_device_LP3DOS = new System.Windows.Forms.RadioButton();
			this.media_device_DPLUS = new System.Windows.Forms.RadioButton();
			this.media_device_LNDOS = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.media_device_LP3DOS);
			this.panel1.Controls.Add(this.media_device_DPLUS);
			this.panel1.Controls.Add(this.media_device_LNDOS);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(446, 180);
			this.panel1.TabIndex = 121;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(251, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 13);
			this.label3.TabIndex = 137;
			this.label3.Text = "Mandatory on Classic Library";
			// 
			// media_device_LP3DOS
			// 
			this.media_device_LP3DOS.AutoSize = true;
			this.media_device_LP3DOS.Enabled = false;
			this.media_device_LP3DOS.Location = new System.Drawing.Point(23, 68);
			this.media_device_LP3DOS.Name = "media_device_LP3DOS";
			this.media_device_LP3DOS.Size = new System.Drawing.Size(59, 17);
			this.media_device_LP3DOS.TabIndex = 136;
			this.media_device_LP3DOS.TabStop = true;
			this.media_device_LP3DOS.Text = "-lp3dos";
			this.media_device_LP3DOS.UseVisualStyleBackColor = true;
			// 
			// media_device_DPLUS
			// 
			this.media_device_DPLUS.AutoSize = true;
			this.media_device_DPLUS.Enabled = false;
			this.media_device_DPLUS.Location = new System.Drawing.Point(23, 45);
			this.media_device_DPLUS.Name = "media_device_DPLUS";
			this.media_device_DPLUS.Size = new System.Drawing.Size(70, 17);
			this.media_device_DPLUS.TabIndex = 135;
			this.media_device_DPLUS.TabStop = true;
			this.media_device_DPLUS.Text = "-DPLUS3";
			this.media_device_DPLUS.UseVisualStyleBackColor = true;
			// 
			// media_device_LNDOS
			// 
			this.media_device_LNDOS.AutoSize = true;
			this.media_device_LNDOS.Enabled = false;
			this.media_device_LNDOS.Location = new System.Drawing.Point(23, 22);
			this.media_device_LNDOS.Name = "media_device_LNDOS";
			this.media_device_LNDOS.Size = new System.Drawing.Size(99, 17);
			this.media_device_LNDOS.TabIndex = 134;
			this.media_device_LNDOS.TabStop = true;
			this.media_device_LNDOS.Text = "-LNDOS - Tape";
			this.media_device_LNDOS.UseVisualStyleBackColor = true;
			this.media_device_LNDOS.CheckedChanged += new System.EventHandler(this.media_device_LNDOS_CheckedChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(11, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(196, 16);
			this.label13.TabIndex = 131;
			this.label13.Text = "Disk Device / Output Media";
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
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightGreen;
			this.button3.Location = new System.Drawing.Point(478, 264);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 134;
			this.button3.Text = "NEXT";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Coral;
			this.button1.Location = new System.Drawing.Point(478, 225);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 133;
			this.button1.Text = "Start Over";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 253);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(446, 56);
			this.textBox1.TabIndex = 132;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(227, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 16);
			this.label2.TabIndex = 135;
			this.label2.Text = "Not used on New Library, Press Next";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 16);
			this.label1.TabIndex = 136;
			this.label1.Text = "Mandatory on Classic Library";
			this.label1.Visible = false;
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 32766;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// Output_Media
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 325);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Output_Media";
			this.Text = "Output_Media";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton media_device_LP3DOS;
		private System.Windows.Forms.RadioButton media_device_DPLUS;
		private System.Windows.Forms.RadioButton media_device_LNDOS;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label3;
	}
}