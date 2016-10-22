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
	public partial class zorg : Form
	{
		public List<string> ListOptions = new List<string>();


		public int zorgValue = 32768;


		
		public zorg()
		{
			InitializeComponent();
		}

		public zorg(string strTextBox)
		{
			InitializeComponent();

			//trackBar1.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);//not working well


			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			#region Luxor ABC80
			if (zccvariables.machine == "abc80")
			{
				zorgValue = 49200;
			}
			#endregion

			#region Luxor ABC800
			if (zccvariables.machine == "abc800")
			{
				zorgValue = 40000;
			}
			#endregion

			#region Jupiter ACE
			if (zccvariables.machine == "ace")
			{
				zorgValue = 24000;
			}
			#endregion

			#region Mattel Aquarius
			if (zccvariables.machine == "aquarius")
			{
				zorgValue = 16384;
			}
			#endregion

			#region Commodore 128
			if (zccvariables.machine == "c128")
			{
				zorgValue = 0;
			}
			#endregion

			#region Philips Videopac C7420
			if (zccvariables.machine == "c7420")
			{
				zorgValue = 0;
			}
			#endregion

			#region CPC
			if (zccvariables.machine == "cpc")
			{
				zorgValue = 1024;
			}
			#endregion

			#region CP/M
			if (zccvariables.machine == "cpm")
			{
				zorgValue = 0;
			}
			#endregion

			#region Embedded
			if (zccvariables.machine == "embedded")
			{
				zorgValue = 0;
			}
			#endregion

			#region Enterprise 64/128 Platform
			if (zccvariables.machine == "enterprise")
			{
				zorgValue = 0;
			}
			#endregion

			#region Galaksija
			if (zccvariables.machine == "gal")
			{
				zorgValue = 0;
			}
			#endregion

			#region Lambda 8300
			//Lambda 8300
			//improved chinese clone of the ZX81
			if (zccvariables.machine == "lambda")
			{
				zorgValue = 16389;
			}
			#endregion

			#region Camputers Lynx
			if (zccvariables.machine == "lynx")
			{
				zorgValue = 32768;
			}
			#endregion

			#region Sord M5
			if (zccvariables.machine == "m5")
			{
				zorgValue = 29696;
			}
			#endregion

			#region CCE MC-1000
			if (zccvariables.machine == "mc1000")
			{
				zorgValue = 0;
			}
			#endregion

			#region MSX
			if (zccvariables.machine == "msx")
			{
				zorgValue = 32768;
			}
			#endregion

			#region Memotech MTX
			if (zccvariables.machine == "mtx")
			{
				zorgValue = 0;
			}
			#endregion

			#region NASCOM 1 & 2
			if (zccvariables.machine == "nascom")
			{
				zorgValue = 1024;
			}
			#endregion

			#region Amstrad NC
			if (zccvariables.machine == "nc")
			{
				zorgValue = 1024;
			}
			#endregion

			#region Grundy Newbrain
			if (zccvariables.machine == "newbrain")
			{
				zorgValue = 20000;
			}
			#endregion

			#region Old School Computer Architecture
			if (zccvariables.machine == "osca")
			{
				zorgValue = 32767;
			}
			#endregion

			#region Sharp OZ-700
			if (zccvariables.machine == "oz")
			{
				zorgValue = 0;
			}
			#endregion

			#region Philips P2000
			if (zccvariables.machine == "p2000")
			{
				zorgValue = 0;
			}
			#endregion

			#region NEC PC-6001
			if (zccvariables.machine == "pc6001")
			{
				zorgValue = 0;
			}
			#endregion

			#region Peters Plus Sprinter
			if (zccvariables.machine == "pps")
			{
				zorgValue = 0;
			}
			#endregion

			#region RCMX000
			if (zccvariables.machine == "rcmx000")
			{
				zorgValue = 0;
			}
			#endregion

			#region Xircom REX 6000
			if (zccvariables.machine == "rex")
			{
				zorgValue = 0;
			}
			#endregion

			#region SAM Coupe
			if (zccvariables.machine == "sam")
			{
				zorgValue = 32768;
			}
			#endregion

			#region SEGA SC-3000
			if (zccvariables.machine == "sc3000")
			{
				zorgValue = 40000;
			}
			#endregion

			#region SMS
			if (zccvariables.machine == "sms")
			{
				zorgValue = 0;
			}
			#endregion

			#region S-OS (The Sentinel)
			if (zccvariables.machine == "sos")
			{
				zorgValue = 3000;
			}
			#endregion

			#region Sorcerer Exidy
			if (zccvariables.machine == "srr")
			{
				zorgValue = 0;
			}
			#endregion

			#region Spectravideo SVI
			if (zccvariables.machine == "svi")
			{
				zorgValue = 0;
			}
			#endregion

			#region Texas Instruments TI8X
			if (zccvariables.machine == "ti8x")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI82
			if (zccvariables.machine == "ti82")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI83
			if (zccvariables.machine == "ti83")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI85
			if (zccvariables.machine == "ti85")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI86
			if (zccvariables.machine == "ti86")
			{
				zorgValue = 24576;
			}
			#endregion

			#region trs80 ** & EG2000
			if (zccvariables.machine == "trs80")
			{
				zorgValue = 20992;
			}
			#endregion

			#region ts2068
			if (zccvariables.machine == "ts2068")
			{
				zorgValue = 32768;
			}
			#endregion

			#region vg5k
			//vg5000
			if (zccvariables.machine == "vg5k")
			{
				zorgValue = 20480;
			}
			#endregion

			#region vz
			if (zccvariables.machine == "vz")
			{
				zorgValue = 0;
			}
			#endregion

			#region x1 **
			if (zccvariables.machine == "x1")
			{
				zorgValue = 0;
			}
			#endregion

			#region Canon X07 **
			if (zccvariables.machine == "x07")
			{
				zorgValue = 1024;
			}
			#endregion

			#region Cambridge z88 **
			if (zccvariables.machine == "z88")
			{
				zorgValue = 16389;
			}
			#endregion

			#region zcc **
			if (zccvariables.machine == "zcc")
			{
				zorgValue = 0;
			}
			#endregion

			#region zx spectrum
			if (zccvariables.machine == "zx")
			{
				zorgValue = 32768;
			}
			#endregion

			#region zx80
			if (zccvariables.machine == "zx80")
			{
				zorgValue = 16389;
			}
			#endregion

			#region zx81
			if (zccvariables.machine == "zx81")
			{
				zorgValue = 16389;
			}
			#endregion

			trackBar1.Value = zorgValue;
			textBox3.Text = zorgValue.ToString();

			enableOptions();
		}

		private void enableOptions()
		{
		}

		private void option_ZORG_CheckedChanged(object sender, EventArgs e)
		{
		//delete
		}



		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			if (trackBar1.Value > 65535)
			{
				trackBar1.Value = 65535;
			}

			if (trackBar1.Value < 1)
			{
				trackBar1.Value = 1;
			}

			textBox2.Text = trackBar1.Value.ToString();
			textBox3.Text = trackBar1.Value.ToString();

			zorgValue = trackBar1.Value;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			//zorgValue = numericUpDown1.Value();


			int temp = int.Parse(textBox3.Text);
			trackBar1.Value = int.Parse(temp.ToString());
			textBox2.Text = textBox3.Text;

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			int temp;

			if (!int.TryParse(textBox3.Text, out temp))//check to see if letters
			{
				if (textBox3.TextLength > 0) 
				{
					textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);

					textBox3.Focus();
					textBox3.SelectionStart = textBox3.Text.Length;
				}
			}
			//if (int.Parse(textBox3.Text, out number))
			if (int.TryParse(textBox3.Text, out temp))
			{
				if (temp > 65535)
				{
					//too high
					MessageBox.Show("too high");
					temp = 65535;
					textBox3.Text = "65535";

					textBox3.Focus();
					textBox3.SelectionStart = textBox3.Text.Length;
				}
				if (temp < 0)
				{
					//too low
					MessageBox.Show("too low");
					temp = 0;
					textBox3.Text = "0";

					textBox3.Focus();
					textBox3.SelectionStart = textBox3.Text.Length;
				}

				
				else
				{
					// just right
					temp = int.Parse(textBox3.Text);
					trackBar1.Value = int.Parse(temp.ToString());
					textBox2.Text = textBox3.Text;

					zorgValue = temp;
				}


			}
		}



		private void reset_zorg_Click(object sender, EventArgs e)
		{
			#region Luxor ABC80
			if (zccvariables.machine == "abc80")
			{
				zorgValue = 49200;
			}
			#endregion

			#region Luxor ABC800
			if (zccvariables.machine == "abc800")
			{
				zorgValue = 40000;
			}
			#endregion

			#region Jupiter ACE
			if (zccvariables.machine == "ace")
			{
				zorgValue = 24000;
			}
			#endregion

			#region Mattel Aquarius
			if (zccvariables.machine == "aquarius")
			{
				zorgValue = 16384;
			}
			#endregion

			#region Commodore 128
			if (zccvariables.machine == "c128")
			{
				zorgValue = 0;
			}
			#endregion

			#region Philips Videopac C7420
			if (zccvariables.machine == "c7420")
			{
				zorgValue = 0;
			}
			#endregion

			#region CPC
			if (zccvariables.machine == "cpc")
			{
				zorgValue = 1024;
			}
			#endregion

			#region CP/M
			if (zccvariables.machine == "cpm")
			{
				zorgValue = 0;
			}
			#endregion

			#region Embedded
			if (zccvariables.machine == "embedded")
			{
				zorgValue = 0;
			}
			#endregion

			#region Enterprise 64/128 Platform
			if (zccvariables.machine == "enterprise")
			{
				zorgValue = 0;
			}
			#endregion

			#region Galaksija
			if (zccvariables.machine == "gal")
			{
				zorgValue = 0;
			}
			#endregion

			#region Lambda 8300
			//Lambda 8300
			//improved chinese clone of the ZX81
			if (zccvariables.machine == "lambda")
			{
				zorgValue = 16389;
			}
			#endregion

			#region Camputers Lynx
			if (zccvariables.machine == "lynx")
			{
				zorgValue = 32768;
			}
			#endregion

			#region Sord M5
			if (zccvariables.machine == "m5")
			{
				zorgValue = 29696;
			}
			#endregion

			#region CCE MC-1000
			if (zccvariables.machine == "mc1000")
			{
				zorgValue = 0;
			}
			#endregion

			#region MSX
			if (zccvariables.machine == "msx")
			{
				zorgValue = 32768;
			}
			#endregion

			#region Memotech MTX
			if (zccvariables.machine == "mtx")
			{
				zorgValue = 0;
			}
			#endregion

			#region NASCOM 1 & 2
			if (zccvariables.machine == "nascom")
			{
				zorgValue = 1024;
			}
			#endregion

			#region Amstrad NC
			if (zccvariables.machine == "nc")
			{
				zorgValue = 1024;
			}
			#endregion

			#region Grundy Newbrain
			if (zccvariables.machine == "newbrain")
			{
				zorgValue = 20000;
			}
			#endregion

			#region Old School Computer Architecture
			if (zccvariables.machine == "osca")
			{
				zorgValue = 32767;
			}
			#endregion

			#region Sharp OZ-700
			if (zccvariables.machine == "oz")
			{
				zorgValue = 0;
			}
			#endregion

			#region Philips P2000
			if (zccvariables.machine == "p2000")
			{
				zorgValue = 0;
			}
			#endregion

			#region NEC PC-6001
			if (zccvariables.machine == "pc6001")
			{
				zorgValue = 0;
			}
			#endregion

			#region Peters Plus Sprinter
			if (zccvariables.machine == "pps")
			{
				zorgValue = 0;
			}
			#endregion

			#region RCMX000
			if (zccvariables.machine == "rcmx000")
			{
				zorgValue = 0;
			}
			#endregion

			#region Xircom REX 6000
			if (zccvariables.machine == "rex")
			{
				zorgValue = 0;
			}
			#endregion

			#region SAM Coupe
			if (zccvariables.machine == "sam")
			{
				zorgValue = 32768;
			}
			#endregion

			#region SEGA SC-3000
			if (zccvariables.machine == "sc3000")
			{
				zorgValue = 40000;
			}
			#endregion

			#region SMS
			if (zccvariables.machine == "sms")
			{
				zorgValue = 0;
			}
			#endregion

			#region S-OS (The Sentinel)
			if (zccvariables.machine == "sos")
			{
				zorgValue = 3000;
			}
			#endregion

			#region Sorcerer Exidy
			if (zccvariables.machine == "srr")
			{
				zorgValue = 0;
			}
			#endregion

			#region Spectravideo SVI
			if (zccvariables.machine == "svi")
			{
				zorgValue = 0;
			}
			#endregion

			#region Texas Instruments TI8X
			if (zccvariables.machine == "ti8x")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI82
			if (zccvariables.machine == "ti82")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI83
			if (zccvariables.machine == "ti83")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI85
			if (zccvariables.machine == "ti85")
			{
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI86
			if (zccvariables.machine == "ti86")
			{
				zorgValue = 24576;
			}
			#endregion

			#region trs80 ** & EG2000
			if (zccvariables.machine == "trs80")
			{
				zorgValue = 20992;
			}
			#endregion

			#region ts2068
			if (zccvariables.machine == "ts2068")
			{
				zorgValue = 32768;
			}
			#endregion

			#region vg5k
			//vg5000
			if (zccvariables.machine == "vg5k")
			{
				zorgValue = 20480;
			}
			#endregion

			#region vz
			if (zccvariables.machine == "vz")
			{
				zorgValue = 0;
			}
			#endregion

			#region x1 **
			if (zccvariables.machine == "x1")
			{
				zorgValue = 0;
			}
			#endregion

			#region Canon X07 **
			if (zccvariables.machine == "x07")
			{
				zorgValue = 1024;
			}
			#endregion

			#region Cambridge z88 **
			if (zccvariables.machine == "z88")
			{
				zorgValue = 16389;
			}
			#endregion

			#region zcc **
			if (zccvariables.machine == "zcc")
			{
				zorgValue = 0;
			}
			#endregion

			#region zx spectrum
			if (zccvariables.machine == "zx")
			{
				zorgValue = 32768;
			}
			#endregion

			#region zx80
			if (zccvariables.machine == "zx80")
			{
				zorgValue = 16389;
			}
			#endregion

			#region zx81
			if (zccvariables.machine == "zx81")
			{
				zorgValue = 16389;
			}
			#endregion

			trackBar1.Value = zorgValue;
			textBox3.Text = zorgValue.ToString();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			string zorg = "-zorg=";
			ListOptions.Add(zorg + zorgValue + " ");
			string zorgOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = zorgOption;

			textBox3.Enabled = false;
			button18.Enabled = false;
			trackBar1.Enabled = false;
			button19.Enabled = true;
			reset_zorg.Enabled = false;
		}


		private void button19_Click(object sender, EventArgs e)
		{
			string zorg = "-zorg=";
			ListOptions.Remove(zorg + zorgValue + " ");
			//MessageBox.Show("Radio Button 2 off");
			string zorgOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = zorgOption;

			textBox3.Enabled = true;
			button19.Enabled = false;
			button18.Enabled = true;
			trackBar1.Enabled = true;
			reset_zorg.Enabled = true;
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
			//where to next??
			//optimization
			if (zccvariables.mainMenuChoice == 3)
			{
				//List_wizard
				zccvariables.zorgOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			if (zccvariables.mainMenuChoice == 2)
			{
				optimization frm = new optimization(textBox1.Text);
				frm.Show();
				this.Close();
			}

		}


		/*
		void trackBar_MouseWheel(object sender, MouseEventArgs e)
		{
			((HandledMouseEventArgs)e).Handled = true;//disable default mouse wheel
			if (e.Delta > 0)
			{
				if (trackBar1.Value < trackBar1.Maximum)
				{
					if (trackBar1.Value > 65535)
					{
						trackBar1.Value = 65535;
					}
					else
					{
						trackBar1.Value = trackBar1.Value + 2048;
					}
				}
			}
			else
			{
				if (trackBar1.Value > trackBar1.Minimum)
				{
					trackBar1.Value = trackBar1.Value - 2048;
				}
			}
		}*/






	}
}
