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
	public partial class option_preserve : Form
	{
		public List<string> ListOptions = new List<string>();

		public option_preserve()
		{
			InitializeComponent();
		}

		public option_preserve(string strTextBox)
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

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void cleanup_option_CheckedChanged(object sender, EventArgs e)
		{
			//-cleanup
			if (cleanup_option.Checked)
			{
				//string assemblertype = "-cleanup ";
				//ListOptions.Add(assemblertype);
				//string assembler = string.Join("", ListOptions.ToArray());
				//textBox1.Text = assembler;
				ListOptions.Add(zccvariables.cleanup_temp_files);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;

			}
			else if (cleanup_option.Checked == false)
			{
				//string assemblertype = "-cleanup ";
				//ListOptions.Remove(assemblertype);
				//string assembler = string.Join("", ListOptions.ToArray());
				//textBox1.Text = assembler;
				ListOptions.Remove(zccvariables.cleanup_temp_files);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			//-no-cleanup 
			if (radioButton2.Checked)
			{
				string assemblertype = "-no-cleanup ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton2.Checked == false)
			{
				string assemblertype = "-no-cleanup ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				string assemblertype = "-notemp ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton3.Checked == false)
			{
				string assemblertype = "-notemp ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton4.Checked)
			{
				string assemblertype = "-usetemp ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton4.Checked == false)
			{
				string assemblertype = "-usetemp ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}

		private void button4_Click(object sender, EventArgs e)
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
				zccvariables.cleanupOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			else
			{
				floating_point frm = new floating_point(textBox1.Text);
				frm.Show();
				this.Close();
			}
		}

		private void preserve_option_CheckedChanged(object sender, EventArgs e)
		{
			if (preserve_option.Checked)
			{
				string assemblertype = "-preserve ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (preserve_option.Checked == false)
			{
				string assemblertype = "-preserve ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
		}



	}
}
