using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z88dk_compile_options_helper_beta
{
	public partial class verbose_options : Form
	{
		public List<string> ListOptions = new List<string>();

		public verbose_options()
		{
			InitializeComponent();
		}

		public verbose_options(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);
			
			enableOptions();
		}

		private void enableOptions()
		{


		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				string shutup = "-vn ";
				ListOptions.Add(shutup);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (checkBox1.Checked == false)
			{
				string shutup = "-vn ";
				ListOptions.Remove(shutup);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				string chatty = "-v ";
				ListOptions.Add(chatty);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (checkBox2.Checked == false)
			{
				string chatty = "-v ";
				ListOptions.Remove(chatty);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			//-z80-verb
			if (checkBox3.Checked)
			{
				string naggy = "-z80-verb ";
				ListOptions.Add(naggy);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (checkBox3.Checked == false)
			{
				string naggy = "-z80-verb ";
				ListOptions.Remove(naggy);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			//-specs
			if (checkBox4.Checked)
			{
				string specs = "-specs ";
				ListOptions.Add(specs);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (checkBox4.Checked == false)
			{
				string specs = "-specs ";
				ListOptions.Remove(specs);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox5.Checked)
			{
				string specs = "-h ";
				ListOptions.Add(specs);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (checkBox5.Checked == false)
			{
				string specs = "-h ";
				ListOptions.Remove(specs);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (zccvariables.mainMenuChoice == 3)
			{
				//List_wizard
				zccvariables.verboseOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			else
			{
				option_preserve frm = new option_preserve(textBox1.Text);
				frm.Show();
				this.Close();
			}
		}


		
	}
}
