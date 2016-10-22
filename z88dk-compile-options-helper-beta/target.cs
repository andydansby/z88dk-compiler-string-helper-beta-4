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
	public partial class target : Form
	{
		public target()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zx ";
			zccvariables.machine = "zx";
			button1.Enabled = true;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ts2068 ";
			zccvariables.machine = "ts2068";
			button1.Enabled = true;
		}

		private void radioButton49_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zx81 ";
			zccvariables.machine = "zx81";
			button1.Enabled = true;
		}

		private void radioButton42_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zx80 ";
			zccvariables.machine = "zx80";
			button1.Enabled = true;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +abc80 ";
			zccvariables.machine = "abc80";
			button1.Enabled = true;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +abc800 ";
			zccvariables.machine = "abc800";
			button1.Enabled = true;
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ace ";
			zccvariables.machine = "ace";
			button1.Enabled = true;
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +aquarius ";
			zccvariables.machine = "aquarius";
			button1.Enabled = true;
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +c128 ";
			zccvariables.machine = "c128";
			button1.Enabled = true;
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +c7420 ";
			zccvariables.machine = "c7420";
			button1.Enabled = true;
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +cpc ";
			zccvariables.machine = "cpc";
			button1.Enabled = true;
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +cpm ";
			zccvariables.machine = "cpm";
			button1.Enabled = true;
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +embedded ";
			zccvariables.machine = "embedded";
			button1.Enabled = true;
		}

		private void radioButton12_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +enterprise ";
			zccvariables.machine = "enterprise";
			button1.Enabled = true;
		}

		private void radioButton13_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +gal ";
			zccvariables.machine = "gal";
			button1.Enabled = true;
		}

		private void radioButton14_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +lambda ";
			zccvariables.machine = "lambda";
			button1.Enabled = true;
		}

		private void radioButton15_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +lynx ";
			zccvariables.machine = "lynx";
			button1.Enabled = true;
		}

		private void radioButton16_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +m5 ";
			zccvariables.machine = "m5";
			button1.Enabled = true;
		}

		private void radioButton17_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +mc1000 ";
			zccvariables.machine = "mc1000";
			button1.Enabled = true;
		}

		private void radioButton18_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +msx ";
			zccvariables.machine = "msx";
			button1.Enabled = true;
		}

		private void radioButton19_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +mtx ";
			zccvariables.machine = "mtx";
			button1.Enabled = true;
		}

		private void radioButton20_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +nascom ";
			zccvariables.machine = "nascom";
			button1.Enabled = true;
		}

		private void radioButton21_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +nc ";
			zccvariables.machine = "nc";
			button1.Enabled = true;
		}

		private void radioButton22_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +newbrain ";
			zccvariables.machine = "newbrain";
			button1.Enabled = true;
		}

		private void radioButton23_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +osca ";
			zccvariables.machine = "osca";
			button1.Enabled = true;
		}

		private void radioButton24_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +oz ";
			zccvariables.machine = "oz";
			button1.Enabled = true;
		}

		private void radioButton25_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +p2000 ";
			zccvariables.machine = "p2000";
			button1.Enabled = true;
		}

		private void radioButton26_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +pc6001 ";
			zccvariables.machine = "pc6001";
			button1.Enabled = true;
		}

		private void radioButton27_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +pps ";
			zccvariables.machine = "pps"; 
			button1.Enabled = true;
		}

		private void radioButton28_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +rcmx000 ";
			zccvariables.machine = "rcmx000";
			button1.Enabled = true;
		}

		private void radioButton29_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +rex ";
			zccvariables.machine = "rex";
			button1.Enabled = true;
		}

		private void radioButton30_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sam ";
			zccvariables.machine = "sam";
			button1.Enabled = true;
		}

		private void radioButton31_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sc3000 ";
			zccvariables.machine = "sc3000";
			button1.Enabled = true;
		}

		private void radioButton32_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sms ";
			zccvariables.machine = "sms";
			button1.Enabled = true;
		}

		private void radioButton33_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +sos ";
			zccvariables.machine = "sos";
			button1.Enabled = true;
		}

		private void radioButton34_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +srr ";
			zccvariables.machine = "srr";
			button1.Enabled = true;
		}

		private void radioButton35_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +svi ";
			zccvariables.machine = "svi";
			button1.Enabled = true;
		}

		private void radioButton36_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti8x ";
			zccvariables.machine = "ti8x";
			button1.Enabled = true;
		}

		private void radioButton37_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti82 ";
			zccvariables.machine = "ti82";
			button1.Enabled = true;
		}

		private void radioButton38_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti83 ";
			zccvariables.machine = "ti83";
			button1.Enabled = true;
		}

		private void radioButton39_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti85 ";
			zccvariables.machine = "ti85";
			button1.Enabled = true;
		}

		private void radioButton40_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +ti86 ";
			zccvariables.machine = "ti86";
			button1.Enabled = true;
		}

		private void radioButton41_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +trs80 ";
			zccvariables.machine = "trs80";
			button1.Enabled = true;
		}

		private void radioButton43_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +vg5k ";
			zccvariables.machine = "vg5k";
			button1.Enabled = true;
		}

		private void radioButton44_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +vz ";
			zccvariables.machine = "vz";
			button1.Enabled = true;
		}

		private void radioButton45_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +x1 ";
			zccvariables.machine = "x1";
			button1.Enabled = true;
		}

		private void radioButton46_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +x07 ";
			zccvariables.machine = "x07";
			button1.Enabled = true;
		}

		private void radioButton47_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +z88 ";
			zccvariables.machine = "z88";
			button1.Enabled = true;
		}

		private void radioButton48_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "zcc +zcc ";
			zccvariables.machine = "zcc";
			button1.Enabled = true;
		}

		//next screen
		private void button1_Click(object sender, EventArgs e)
		{
			//this.Hide();

			//quick start
			if (zccvariables.mainMenuChoice == 1)
			{
				quick_start frm = new quick_start(textBox1.Text);
				frm.Show();
				this.Close();
			}

			//wizard
			if (zccvariables.mainMenuChoice == 2)
			{
				compiler_choice frm = new compiler_choice(textBox1.Text);
				frm.Show();
				this.Close();
			}

			//list wizard
			if (zccvariables.mainMenuChoice == 3)
			{
				//Form1 frm = (Form1)Application.OpenForms["Form1"];

				//List_wizard(textBox1.Text);

				//List_wizard frm = (List_wizard)Application.OpenForms["List_wizard"];
				//frm.Show();



				//List_wizard
				//zccvariables.choosenTarget = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
		}



	}
}
