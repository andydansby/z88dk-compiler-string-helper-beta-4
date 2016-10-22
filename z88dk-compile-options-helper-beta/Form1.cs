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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();


			if (zccvariables.restartForm1 == false)
			{
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
			}
			if (zccvariables.restartForm1 == true)
			{
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;

				zccvariables.choosenTarget = false;

			}


			zccvariables.choosenTarget = false;
			zccvariables.compilerChoice = false;
			zccvariables.verboseOptions = false;
			zccvariables.cleanupOptions = false;
			zccvariables.floatingPointOptions = false;
			zccvariables.zorgOptions = false;
			zccvariables.optimizationOptions = false;
			zccvariables.terminalOptions = false;
			zccvariables.mediaOptions = false;
			zccvariables.preprocessorOptions = false;
			zccvariables.miscellaneousOptions = false;
			zccvariables.memoryOptions = false;
			zccvariables.restartForm1 = true;
			zccvariables.machine = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//button1.Enabled = false;
			//button2.Enabled = false;
			//button3.Enabled = false;

			//quick start
			zccvariables.mainMenuChoice = 1;
			target frm = new target();
			frm.Show();

			//testing may need to remove
			this.Hide();
		}


		private void button2_Click(object sender, EventArgs e)
		{
			//button1.Enabled = false;
			//button2.Enabled = false;
			//button3.Enabled = false;

			//wizard
			zccvariables.mainMenuChoice = 2;
			target frm = new target();
			frm.Show();

			//testing may need to remove
			this.Hide();

		}		

		private void button3_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("not yet implemented");

			//floating_point frm = new floating_point(textBox1.Text);
			//frm.Show();

			//long wizard
			zccvariables.mainMenuChoice = 3;

			List_wizard frm = new List_wizard();
			frm.Show();


			//this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AboutBox1 frm = new AboutBox1();
			frm.Show();
		}



	}
}
