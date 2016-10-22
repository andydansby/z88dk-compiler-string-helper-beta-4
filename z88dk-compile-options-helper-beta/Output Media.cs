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
	public partial class Output_Media : Form
	{
		public List<string> ListOptions = new List<string>();

		public Output_Media()
		{
			InitializeComponent();
		}

		public Output_Media(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);
			
			

			if (zccvariables.classicCompiler == true)
			{
				//MessageBox.Show("CLASSIC");

				media_device_LNDOS.Enabled = true;
				media_device_DPLUS.Enabled = true;
				media_device_LP3DOS.Enabled = true;

				button1.Enabled = true;
				button3.Enabled = false;
				label1.Visible = true;
				label2.Visible = false;

				// use the form
			}
			if (zccvariables.classicCompiler == false)
			{

				//MessageBox.Show("NEW");

				button1.Enabled = true;
				button3.Enabled = true;
				label1.Visible = false;
				label2.Visible = true;

				media_device_LNDOS.Enabled = false;
				media_device_DPLUS.Enabled = false;
				media_device_LP3DOS.Enabled = false;
			}

			enableOptions();
		}

		private void enableOptions()
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (zccvariables.mainMenuChoice == 3)
			{
				//List_wizard
				zccvariables.mediaOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			if (zccvariables.mainMenuChoice == 2)
			{
				if (zccvariables.classicCompiler == true)
				{
					optimization frm = new optimization(textBox1.Text);
					frm.Show();
					this.Close();
				}
				else if (zccvariables.classicCompiler == false)
				{
					zorg frm = new zorg(textBox1.Text);
					frm.Show();
					this.Close();
				}
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}

		private void media_device_LNDOS_CheckedChanged(object sender, EventArgs e)
		{
			if (media_device_LNDOS.Checked)
			{
				string assemblertype = "-lndos ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}
			else if (media_device_LNDOS.Checked == false)
			{
				string assemblertype = "-lndos ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
			}


			button3.Enabled = true;
		}

	}
}
