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
	public partial class floating_point : Form
	{
		public List<string> ListOptions = new List<string>();
		string floatingPoint = "";

		public floating_point()
		{
			InitializeComponent();
		}

		public floating_point(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);


			bool machineFloat = machine_type_for_floating_point(false);

			if (zccvariables.classicCompiler == true)
			{
				noFloatPoint.Enabled = true;
				lmFloatPoint.Enabled = true;

				if (machineFloat == true)
				{
					noFloatPoint.Enabled = true;
					lmFloatPoint.Enabled = true;
					lmzxFloatPoint.Enabled = true;
					lmzxtinyFloatPoint.Enabled = true;
				}
				if (machineFloat == false)
				{
					noFloatPoint.Enabled = true;
					lmFloatPoint.Enabled = true;
					lmzxFloatPoint.Enabled = false;
					lmzxtinyFloatPoint.Enabled = false;
				}
			}


			if (zccvariables.classicCompiler == false)
			{
				noFloatPoint.Enabled = true;
				lmFloatPoint.Enabled = true;
				lmzxFloatPoint.Enabled = false;
				lmzxtinyFloatPoint.Enabled = false;
			}

			if (zccvariables.sdcc_compiler == true)
			{
				panel10.Enabled = true;
			}
			if (zccvariables.sdcc_compiler == false)
			{
				panel10.Enabled = false;
			}

			enableOptions();
		}

		private void enableOptions()
		{
		}




		public bool machine_type_for_floating_point(bool type)
		{
			if (zccvariables.machine == "zx")
			{
				return true;
			}
			if (zccvariables.machine == "zx81")
			{
				return true;
			}
			if (zccvariables.machine == "ts2068")
			{
				return true;
			}
			//cpc
			if (zccvariables.machine == "cpc")
			{
				return true;
			}
			//what about sam & ace & lambda


			else
			{
				return false;
			}
			//return true;
		}


		private void noFloatPoint_CheckedChanged(object sender, EventArgs e)
		{
			//no floating point
			if (noFloatPoint.Checked)
			{
				floatingPoint = "";
				ListOptions.Add(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (noFloatPoint.Checked == false)
			{
				floatingPoint = "";
				ListOptions.Remove(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void lmFloatPoint_CheckedChanged(object sender, EventArgs e)
		{
			if (lmFloatPoint.Checked)
			{
				floatingPoint = "-lm ";
				ListOptions.Add(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (lmFloatPoint.Checked == false)
			{
				floatingPoint = "-lm ";
				ListOptions.Remove(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void lmzxFloatPoint_CheckedChanged(object sender, EventArgs e)
		{
			if (lmzxFloatPoint.Checked)
			{
				floatingPoint = "-lmzx ";
				ListOptions.Add(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (lmzxFloatPoint.Checked == false)
			{
				floatingPoint = "-lmzx ";
				ListOptions.Remove(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void lmzxtinyFloatPoint_CheckedChanged(object sender, EventArgs e)
		{
			if (lmzxtinyFloatPoint.Checked)
			{
				floatingPoint = "-lmzx_tiny ";
				ListOptions.Add(floatingPoint);
				//MessageBox.Show("Radio Button 2 off");
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (lmzxtinyFloatPoint.Checked == false)
			{
				floatingPoint = "-lmzx_tiny ";
				ListOptions.Remove(floatingPoint);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
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
				zccvariables.floatingPointOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			if (zccvariables.mainMenuChoice == 2)
			{
				if (zccvariables.classicCompiler == true)
				{
					Output_Media frm = new Output_Media(textBox1.Text);
					frm.Show();
					this.Close();
				}
				//output media not supported on new compiler
				if(zccvariables.classicCompiler == false)
				{
					zorg frm = new zorg(textBox1.Text);
					frm.Show();
					this.Close();
				}


			}
		}

		private void f_signed_char_CheckedChanged(object sender, EventArgs e)
		{
			if (f_signed_char.Checked)
			{
				string signed_char = "--fsigned-char ";
				ListOptions.Add(signed_char);
				string signed = string.Join("", ListOptions.ToArray());
				textBox1.Text = signed;
			}
			else if (f_signed_char.Checked == false)
			{
				string signed_char = "--fsigned-char ";
				ListOptions.Remove(signed_char);
				string signed = string.Join("", ListOptions.ToArray());
				textBox1.Text = signed;
			}
		}
	}
}
