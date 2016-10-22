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
	public partial class Memory : Form
	{
		public List<string> ListOptions = new List<string>();

		public int codeSegValue = 0;
		public int constSegValue = 0;

		public Memory()
		{
			InitializeComponent();
		}

		public Memory(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			enableOptions();
		}

		private void enableOptions()
		{
			//sdcc_compiler
			if (zccvariables.sdcc_compiler == true)
			{
				panel1.Enabled = true;
				panel2.Enabled = true;
				panel3.Enabled = true;
				// use the form
			}
			if (zccvariables.sdcc_compiler == false)
			{
				panel1.Enabled = false;
				panel2.Enabled = false;
				panel3.Enabled = false;
			}
		}

		private void code_seg_option_CheckedChanged(object sender, EventArgs e)
		{
			if (code_seg_option.Checked == true)
			{
				codeSegTextbox.Enabled = true;
				code_seg_enter.Enabled = true;
				code_seg_remove.Enabled = false;
			}
			if (code_seg_option.Checked == false)
			{
				codeSegTextbox.Text = "";
				code_seg_remove.Enabled = false;
				code_seg_enter.Enabled = false;
				codeSegTextbox.Enabled = false;


				string globalDefs = "--code-seg=";
				ListOptions.Remove(globalDefs);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}


		private void code_seg_enter_Click(object sender, EventArgs e)
		{
			code_seg_remove.Enabled = true;
			codeSegTextbox.Enabled = false;
			code_seg_enter.Enabled = false;
			code_seg_option.Enabled = false;

			string codeSeg = "--code-seg=" + codeSegValue + " ";
			ListOptions.Add(codeSeg);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void code_seg_remove_Click(object sender, EventArgs e)
		{
			code_seg_remove.Enabled = false;
			codeSegTextbox.Enabled = true;
			code_seg_enter.Enabled = true;
			code_seg_option.Enabled = true;

			string codeSeg = "--code-seg=" + codeSegValue + " ";
			ListOptions.Remove(codeSeg);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void codeSegTextbox_TextChanged(object sender, EventArgs e)
		{
			int temp;

			if (!int.TryParse(codeSegTextbox.Text, out temp))//check to see if letters
			{
				if (codeSegTextbox.TextLength > 0) 
				{
					codeSegTextbox.Text = codeSegTextbox.Text.Substring(0, codeSegTextbox.Text.Length - 1);

					codeSegTextbox.Focus();
					codeSegTextbox.SelectionStart = codeSegTextbox.Text.Length;
				}
			}
				
			else
			{
				// just right
				temp = int.Parse(codeSegTextbox.Text);
				codeSegValue = temp;
			}
		}

		private void const_seg_option_CheckedChanged(object sender, EventArgs e)
		{
			if (const_seg_option.Checked == true)
			{
				constsegTextBox.Enabled = true;
				const_seg_enter.Enabled = true;
				const_seg_remove.Enabled = false;
			}
			if (const_seg_option.Checked == false)
			{
				constsegTextBox.Text = "";
				const_seg_remove.Enabled = false;
				const_seg_enter.Enabled = false;
				constsegTextBox.Enabled = false;


				string globalDefs = "--code-seg=";
				ListOptions.Remove(globalDefs);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}

		private void const_seg_enter_Click(object sender, EventArgs e)
		{
			const_seg_remove.Enabled = true;
			constsegTextBox.Enabled = false;
			const_seg_enter.Enabled = false;
			const_seg_option.Enabled = false;

			string constSeg = "--const-seg=" + constSegValue + " ";
			ListOptions.Add(constSeg);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void const_seg_remove_Click(object sender, EventArgs e)
		{
			const_seg_remove.Enabled = false;
			constsegTextBox.Enabled = true;
			const_seg_enter.Enabled = true;
			const_seg_option.Enabled = true;

			string constSeg = "--const-seg=" + constSegValue + " ";
			ListOptions.Remove(constSeg);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void constsegTextBox_TextChanged(object sender, EventArgs e)
		{
			int temp;

			if (!int.TryParse(constsegTextBox.Text, out temp))//check to see if letters
			{
				if (constsegTextBox.TextLength > 0)
				{
					constsegTextBox.Text = constsegTextBox.Text.Substring(0, constsegTextBox.Text.Length - 1);

					constsegTextBox.Focus();
					constsegTextBox.SelectionStart = constsegTextBox.Text.Length;
				}
			}

			else
			{
				// just right
				temp = int.Parse(constsegTextBox.Text);
				constSegValue = temp;
			}
		}

		private void opt_code_option_CheckedChanged(object sender, EventArgs e)
		{
			if (opt_code_option.Checked == true)
			{
				string codesize = "--opt-code-size ";
				ListOptions.Add(codesize);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
			if (opt_code_option.Checked == false)
			{
				string codesize = "--opt-code-size ";
				ListOptions.Remove(codesize);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (zccvariables.mainMenuChoice == 3)
			{
				//List_wizard
				zccvariables.memoryOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			if (zccvariables.mainMenuChoice == 2)
			{
				//optimization frm = new optimization(textBox1.Text);
				//frm.Show();
				//this.Close();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}




	}
}
