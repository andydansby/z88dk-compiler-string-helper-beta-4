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
	public partial class compiler_choice : Form
	{
		public List<string> ListOptions = new List<string>();

		public int targetMachine;
		//public bool classicCompiler = false;

		public compiler_choice()
		{
			InitializeComponent();
		}

		public compiler_choice(string strTextBox)
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

		private void radioButton17_CheckedChanged(object sender, EventArgs e)
		{
			button3.Enabled = false;

			if (radioButton17.Checked)
			{
				//classicCompiler = false;

				zccvariables.classicCompiler = false;
				


				radioButton23.Enabled = true;
				radioButton22.Enabled = true;
				radioButton18.Enabled = true;
				radioButton19.Enabled = true;

				radioButton23.Checked = false;				
				radioButton22.Checked = false;				
				radioButton18.Checked = false;				
				radioButton19.Checked = false;
				

				radioButton20.Checked = false;
				radioButton20.Enabled = false;
				radioButton21.Checked = false;
				radioButton21.Enabled = false;
			}
			else
			{
				radioButton23.Checked = false;
				radioButton23.Enabled = false;
				radioButton22.Checked = false;
				radioButton22.Enabled = false;
				radioButton18.Checked = false;
				radioButton18.Enabled = false;
				radioButton19.Checked = false;
				radioButton19.Enabled = false;
			}


		}

		private void radioButton16_CheckedChanged(object sender, EventArgs e)
		{

			button3.Enabled = false;

			if (radioButton16.Checked == true)
			{
				//classicCompiler = true;
				zccvariables.classicCompiler = true;
				

				radioButton23.Checked = false;
				radioButton23.Enabled = false;
				radioButton22.Checked = false;
				radioButton22.Enabled = false;
				radioButton18.Checked = false;
				radioButton18.Enabled = false;
				radioButton19.Checked = false;
				radioButton19.Enabled = false;

				radioButton20.Checked = false;
				radioButton20.Enabled = true;
				radioButton21.Checked = false;
				radioButton21.Enabled = true;
			}
			else
			{
				radioButton20.Checked = false;
				radioButton20.Enabled = false;
				radioButton21.Checked = false;
				radioButton21.Enabled = false;
			}
		}

		private void radioButton23_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=new
			if (radioButton23.Checked)
			{
				string assemblertype = "-clib=new ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton23.Checked == false)
			{
				string assemblertype = "-clib=new ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			//enable next button
			button3.Enabled = true;
			zccvariables.sdcc_compiler = false;
		}

		private void radioButton22_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton22.Checked)
			{
				string assemblertype = "-clib=sdcc_ix ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton22.Checked == false)
			{
				string assemblertype = "-clib=sdcc_ix ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			//enable next button
			button3.Enabled = true;

			zccvariables.sdcc_compiler = true;
		}

		private void radioButton18_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=sdcc_ix
			if (radioButton18.Checked)
			{
				string assemblertype = "-clib=sdcc_ix --reserve-regs-iy ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton18.Checked == false)
			{
				string assemblertype = "-clib=sdcc_ix --reserve-regs-iy ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			//enable next button
			button3.Enabled = true;
			zccvariables.sdcc_compiler = true;
		}

		private void radioButton19_CheckedChanged(object sender, EventArgs e)
		{
			//-clib=sdcc_iy
			if (radioButton19.Checked)
			{
				string assemblertype = "-clib=sdcc_iy ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

			}
			else if (radioButton19.Checked == false)
			{
				string assemblertype = "-clib=sdcc_iy ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			//enable next button
			button3.Enabled = true;
			zccvariables.sdcc_compiler = true;
		}

		private void radioButton20_CheckedChanged(object sender, EventArgs e)
		{
			//-compiler=sccz80
			if (radioButton20.Checked)
			{
				string assemblertype = "-compiler=sccz80 ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton20.Checked == false)
			{
				string assemblertype = "-compiler=sccz80 ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			button3.Enabled = true;
			zccvariables.sdcc_compiler = false;
		}

		private void radioButton21_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton21.Checked)
			{
				string assemblertype = "-compiler=sdcc ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (radioButton21.Checked == false)
			{
				string assemblertype = "-compiler=sdcc ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			button3.Enabled = true;
			zccvariables.sdcc_compiler = true;
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
				

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			else
			{
				verbose_options frm = new verbose_options(textBox1.Text);
				frm.Show();
				this.Close();
			}
		}



	}
}
