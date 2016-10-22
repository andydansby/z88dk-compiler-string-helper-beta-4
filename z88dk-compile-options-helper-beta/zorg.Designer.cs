namespace z88dk_compile_options_helper_beta
{
	partial class zorg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zorg));
			this.panel1 = new System.Windows.Forms.Panel();
			this.reset_zorg = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.reset_zorg);
			this.panel1.Controls.Add(this.button19);
			this.panel1.Controls.Add(this.button18);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(502, 150);
			this.panel1.TabIndex = 125;
			// 
			// reset_zorg
			// 
			this.reset_zorg.Location = new System.Drawing.Point(221, 5);
			this.reset_zorg.Name = "reset_zorg";
			this.reset_zorg.Size = new System.Drawing.Size(95, 23);
			this.reset_zorg.TabIndex = 152;
			this.reset_zorg.Text = "Reset to Default";
			this.reset_zorg.UseVisualStyleBackColor = true;
			this.reset_zorg.Click += new System.EventHandler(this.reset_zorg_Click);
			// 
			// button19
			// 
			this.button19.Enabled = false;
			this.button19.Location = new System.Drawing.Point(206, 123);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(75, 23);
			this.button19.TabIndex = 151;
			this.button19.Text = "Remove";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.button19_Click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(123, 123);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(75, 23);
			this.button18.TabIndex = 150;
			this.button18.Text = "Enter";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(14, 126);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 147;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 1024;
			this.trackBar1.Location = new System.Drawing.Point(14, 40);
			this.trackBar1.Maximum = 65535;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(473, 45);
			this.trackBar1.SmallChange = 256;
			this.trackBar1.TabIndex = 146;
			this.trackBar1.TickFrequency = 256;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(297, 126);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 143;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(218, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 145;
			this.label5.Text = "32768";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(450, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 144;
			this.label4.Text = "65535";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 143;
			this.label1.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(396, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 138;
			this.label2.Text = "Optional";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 131;
			this.label3.Text = "ZORG";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(463, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(24, 23);
			this.button1.TabIndex = 123;
			this.button1.Text = "?";
			this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(10, 183);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(460, 55);
			this.textBox1.TabIndex = 127;
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 32766;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightGreen;
			this.button3.Location = new System.Drawing.Point(476, 203);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 129;
			this.button3.Text = "NEXT";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Coral;
			this.button4.Location = new System.Drawing.Point(476, 168);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 128;
			this.button4.Text = "Start Over";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// zorg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 250);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.panel1);
			this.Name = "zorg";
			this.Text = "zorg";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button reset_zorg;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}