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
	public partial class output_file : Form
	{
		public List<string> ListOptions = new List<string>();

		string outputFile = "";

		public output_file()
		{
			InitializeComponent();
		}

		public output_file(string strTextBox)
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



		private void add_file_Click(object sender, EventArgs e)
		{
			if (outputFileTextbox.Text == "")
			{
				add_file.Enabled = true;
				remove_file.Enabled = false;
			}
			else
			{
				outputFile = outputFileTextbox.Text;
				string file = "-o " + outputFile + " ";
				ListOptions.Add(file);

				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

				add_file.Enabled = false;
				remove_file.Enabled = true;
			}
		}

		private void remove_file_Click(object sender, EventArgs e)
		{
			outputFileTextbox.Text = "";

			string file = "-o " + outputFile + " ";
			ListOptions.Remove(file);
			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;

			add_file.Enabled = true;
			remove_file.Enabled = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{

			if (zccvariables.mainMenuChoice == 2)
			{
				//optimization frm = new optimization(textBox1.Text);
				//frm.Show();
				//this.Close();
			}

			if (zccvariables.mainMenuChoice == 3)
			{
				//List_wizard
				zccvariables.zorgOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
		}

		private void create_app_option_CheckedChanged(object sender, EventArgs e)
		{
			if (create_app_option.Checked)
			{
				string createApp = "-create-app ";
				ListOptions.Add(createApp);
				//MessageBox.Show("Radio Button 2 off");
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

			}
			else if (create_app_option.Checked == false)
			{
				string createApp = "-create-app ";
				ListOptions.Remove(createApp);
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;
			}
		}

		private void create_library_option_CheckedChanged(object sender, EventArgs e)
		{
			if (create_app_option.Checked)
			{
				string createApp = "-x ";
				ListOptions.Add(createApp);
				//MessageBox.Show("Radio Button 2 off");
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

			}
			else if (create_app_option.Checked == false)
			{
				string createApp = "-x ";
				ListOptions.Remove(createApp);
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;
			}
		}

		private void subtype_tape_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=tape
			//-subtype=default
		}

		private void subtype_if2_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=if2
			//"-subtype=if2" only if startup>=32 (see below) to make an if2 cartridge.
			//if2 carts with subtype=rom.
		}

		private void subtype_disk_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=disk
		}

		private void subtype_wav_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=wav
		}

		private void subtype_turbo_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=turbo
		}

		private void subtype_zxvgs_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=zxvgs
		}

		private void subtype_ROM_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=rom
		}

		private void subtype_app_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=app
		}

		private void subtype_MSXdos_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=msxdos
		}

		private void subtype_wrx_CheckedChanged(object sender, EventArgs e)
		{
			//-subtype=wrx
		}







	}
}
