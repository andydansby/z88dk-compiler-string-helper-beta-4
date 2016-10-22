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
	public partial class quick_start : Form
	{
	
		public List<string> ListOptions = new List<string>();


		public quick_start()
		{
			InitializeComponent();
			
		}

		//form global variables
		//bool enableFloatingPoint = false;
		//bool enableLNDOS = false;
		//bool enableCreateApp = false;

		string floatingPoint = "";
		string fileName = "";
		string outputFile = "";
		string manualEntry = "";
		string reserveRegsIY = "";
		bool sdccCompilerlib = true;
		bool compatableTargetforZXFloats = false;
		int zorgValue = 32768;
		//form global variables

		
		
		public quick_start(string strTextBox)
		{
			InitializeComponent();

			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);

			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			//textBox1.ShortcutsEnabled = false;
			textBox1.Enabled = false;

			textBox5.Enabled = false;


			#region Luxor ABC80
			if (zccvariables.machine == "abc80")
			{
				label1.Text = "Luxor ABC80";
				textBox2.Text = "zcc +abc80 -lm -o adventure -create-app program.c";
				textBox3.Text = "zcc +abc80 -lm  -subtype=wav -o program -create-app program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 49200;
			}
			#endregion

			#region Luxor ABC800
			if (zccvariables.machine == "abc800")
			{
				label1.Text = "Luxor ABC800";
				textBox2.Text = "zcc +abc800 -zorg=40000 -create-app program.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 40000;
			}
			#endregion

			#region Jupiter ACE
			if (zccvariables.machine == "ace")
			{
				label1.Text = "Jupiter ACE";
				textBox2.Text = "zcc +ace -create-app program.c";
				textBox3.Text = "zcc +ace -clib=ansi -create-app -Cz--audio -o program program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 24000;
			}
			#endregion

			#region Mattel Aquarius
			if (zccvariables.machine == "aquarius")
			{
				label1.Text = "Mattel Aquarius";
				textBox2.Text = "zcc +aquarius -lm -create-app -o program program.c";
				textBox3.Text = "zcc +aquarius -subtype=ansi -lm -create-app -o program program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 16384;
			}
			#endregion

			#region Commodore 128
			if (zccvariables.machine == "c128")
			{
				label1.Text = "Commodore C128";
				textBox2.Text = "zcc +c128 -create-app program.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Philips Videopac C7420
			if (zccvariables.machine == "c7420")
			{
				label1.Text = "Philips Videopac C7420";
				textBox2.Text = "zcc +c7420 -create-app program.c";
				textBox3.Text = "zcc +c7420-create-app -zorg=<location> program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region CPC
			if (zccvariables.machine == "cpc")
			{
				label1.Text = "Amstrad CPC";
				textBox2.Text = "zcc +cpc -lndos -lm -create-app -o program adv_a.c";
				textBox3.Text = "zcc +cpc -clib=ansi -lcpcfs -lmz -create-app -o program adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 1024;
			}
			#endregion

			#region CP/M
			if (zccvariables.machine == "cpm")
			{
				label1.Text = "CP/M";
				textBox2.Text = "zcc +cpm -lm -o program.com program.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Embedded
			if (zccvariables.machine == "embedded")
			{
				label1.Text = "Embedded";
				textBox2.Text = "";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Enterprise 64/128 Platform
			if (zccvariables.machine == "enterprise")
			{
				label1.Text = "Enterprise 64/128 Platform";
				textBox2.Text = "zcc  +enterprise -lm -create-app -o program program.c";
				textBox3.Text = "zcc  +enterprise -subtype=com -lm -o program.com program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Galaksija
			if (zccvariables.machine == "gal")
			{
				label1.Text = "Galaksija";
				textBox2.Text = "zcc +gal -create-app -o adventure adv_a.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Lambda 8300
			//Lambda 8300
			//improved chinese clone of the ZX81
			if (zccvariables.machine == "lambda")
			{
				label1.Text = "Lambda 8300";
				textBox2.Text = "zcc +lambda -lzx81_math -create-app program.c";
				textBox3.Text = "zcc +lambda -lm -create-app program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 16389;
			}
			#endregion

			#region Camputers Lynx
			if (zccvariables.machine == "lynx")
			{
				label1.Text = "Camputers Lynx";
				textBox2.Text = "zcc +lynx -lm -create-app adv_a.c";
				textBox3.Text = "zcc +lynx -lm -o adventure.z80 adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 32768;
			}
			#endregion

			#region Sord M5
			if (zccvariables.machine == "m5")
			{
				label1.Text = "Sord M5";
				textBox2.Text = "zcc +m5 -lm -create-app -Cz--audio program.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 29696;
			}
			#endregion

			#region CCE MC-1000
			if (zccvariables.machine == "mc1000")
			{
				label1.Text = "CCE MC-1000";
				textBox2.Text = "zcc +mc1000 -create-app -Cz--audio program.c";
				textBox3.Text = "zcc +mc1000 -clib=ansi -create-app -Cz--audio program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region MSX
			if (zccvariables.machine == "msx")
			{
				label1.Text = "MSX";
				textBox2.Text = "zcc +msx -create-app program.c";
				textBox3.Text = "zcc +msx -create-app -subtype=wav program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 32768;
			}
			#endregion

			#region Memotech MTX
			if (zccvariables.machine == "mtx")
			{
				label1.Text = "Memotech MTX";
				textBox2.Text = "zcc +mtx -lndos -create-app -Cz--audio -o program.bin program.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region NASCOM 1 & 2
			if (zccvariables.machine == "nascom")
			{
				label1.Text = "NASCOM 1 & 2";
				textBox2.Text = "zcc +nascom -lm -o adventure -create-app program.c";
				textBox3.Text = "zcc +nascom -clib=ansi -lm -o program -create-app program.c";
				compatableTargetforZXFloats = false;
			}
			#endregion

			#region Amstrad NC
			if (zccvariables.machine == "nc")
			{
				label1.Text = "Amstrad NC";
				textBox2.Text = "zcc +nc -lm program.c";
				textBox3.Text = "zcc +nc -subtype=ram -lm program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 1024;
			}
			#endregion

			#region Grundy Newbrain
			if (zccvariables.machine == "newbrain")
			{
				label1.Text = "Grundy Newbrain";
				textBox2.Text = "zcc +newbrain -lm -lndos -create-app program.c";
				textBox3.Text = "zcc +newbrain -lm -lnbdrv -create-app program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 20000;
			}
			#endregion

			#region Old School Computer Architecture
			if (zccvariables.machine == "osca")
			{
				label1.Text = "Old School Computer Architecture";
				textBox2.Text = "zcc +osca -lm -lndos -o program.exe program.c";
				textBox3.Text = "zcc +osca -lm -lflosdos -o program.exe program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 32767;
			}
			#endregion

			#region Sharp OZ-700
			if (zccvariables.machine == "oz")
			{
				label1.Text = "Sharp OZ-700";
				textBox2.Text = "zcc +oz -lm -o adv.bin adv_a.c";
				textBox3.Text = "zcc +oz -O3 ansitest.c -pragma-define:ansicolumns=26";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Philips P2000
			if (zccvariables.machine == "p2000")
			{
				label1.Text = "Philips P2000";
				textBox2.Text = "zcc +p2000 -create-app -lm program.c";
				textBox3.Text = "zcc +p2000 -subtype=ansi -create-app -lm program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region NEC PC-6001
			if (zccvariables.machine == "pc6001")
			{
				label1.Text = "NEC PC-6001";
				textBox2.Text = "zcc +pc6001 -create-app -lm program.c";
				textBox3.Text = "zcc +pc6001 -clib=ansi -subtype=32k -oprogram -create-app -lm program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Peters Plus Sprinter
			if (zccvariables.machine == "pps")
			{
				label1.Text = "Peters Plus Sprinter";
				textBox2.Text = "zcc +pps -o adventure.exe adv_a.c";
				textBox3.Text = "zcc +pps -clib=ansi -o adventure.exe adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region RCMX000
			if (zccvariables.machine == "rcmx000")
			{
				label1.Text = "RCMX";
				textBox2.Text = "";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Xircom REX 6000
			if (zccvariables.machine == "rex")
			{
				label1.Text = "Xircom REX 6000";
				textBox2.Text = "zcc +rex -create-app -lm hello.c";
				textBox3.Text = "zcc +rex -subtype=lib -create-app -lm libcode.";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region SAM Coupe
			if (zccvariables.machine == "sam")
			{
				label1.Text = "SAM Coupe";
				textBox2.Text = "zcc +sam -lm application.c";
				textBox3.Text = "zcc +sam -clib=ansi -lm application.c";
				compatableTargetforZXFloats = false;
				zorgValue = 32768;
			}
			#endregion

			#region SEGA SC-3000
			if (zccvariables.machine == "sc3000")
			{
				label1.Text = "SEGA SC-3000";
				textBox2.Text = "zcc +sc3000 -create-app -Cz--audio -oadventure adv_a.c";
				textBox3.Text = "zcc +sc3000 -create-app -subtype=sf7000 -Cz--audio -oadventure -zorg=40000 adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 40000;
			}
			#endregion

			#region SMS
			if (zccvariables.machine == "sms")
			{
				label1.Text = "SMS";
				textBox2.Text = "";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region S-OS (The Sentinel)
			if (zccvariables.machine == "sos")
			{
				label1.Text = "S-OS (The Sentinel)";
				textBox2.Text = "zcc +sos -lndos -oadva -create-app adv_a.c";
				textBox3.Text = "zcc +sos -lgendos -lmalloc -DAMALLOC -oadva -create-app adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 3000;
			}
			#endregion

			#region Sorcerer Exidy
			if (zccvariables.machine == "srr")
			{
				label1.Text = "Sorcerer Exidy";
				textBox2.Text = "zcc +srr -lm -lndos -create-app dstar.c -Cz--audio";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Spectravideo SVI
			if (zccvariables.machine == "svi")
			{
				label1.Text = "Spectravideo SVI";
				textBox2.Text = "zcc +svi -lm -create-app program.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Texas Instruments TI8X
			if (zccvariables.machine == "ti8x")
			{
				label1.Text = "Texas Instruments ti8x";
				textBox2.Text = "zcc +ti8x -lm -o adv_a -create-app adv_a.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI82
			if (zccvariables.machine == "ti82")
			{
				label1.Text = "Texas Instruments";
				textBox2.Text = "zcc +ti82 -lm -o adv_a -create-app adv_a.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI83
			if (zccvariables.machine == "ti83")
			{
				label1.Text = "Texas Instruments";
				textBox2.Text = "zcc +ti83 -lm -o adv_a -create-app adv_a.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI85
			if (zccvariables.machine == "ti85")
			{
				label1.Text = "Texas Instruments";
				textBox2.Text = "zcc +ti85 -lm -o adv_a -create-app adv_a.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 24576;
			}
			#endregion

			#region Texas Instruments TI86
			if (zccvariables.machine == "ti86")
			{
				label1.Text = "Texas Instruments";
				textBox2.Text = "zcc +ti86 -lm -o adv_a -create-app adv_a.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 24576;
			}
			#endregion

			#region trs80 ** & EG2000
			if (zccvariables.machine == "trs80")
			{
				label1.Text = "Tandy TRS-80";
				textBox2.Text = "zcc +trs80 -lndos -lm -create-app -subtype=disk program.c";
				textBox3.Text = "zcc +trs80 -lndos -lm -create-app program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 20992;
			}
			#endregion

			#region ts2068
			if (zccvariables.machine == "ts2068")
			{
				label1.Text = "Timex Sinclair 2068";
				textBox2.Text = "zcc +ts2068 -create-app program.c";
				textBox3.Text = "zcc +ts2068 -clib=ansi -create-app program.c";
				compatableTargetforZXFloats = true;
				zorgValue = 32768;
			}
			#endregion

			#region vg5k
			//vg5000
			if (zccvariables.machine == "vg5k")
			{
				label1.Text = "Philips VG-5000";
				textBox2.Text = "zcc +vg5k -subtype=wav -create-app -lm program.c";
				textBox3.Text = "zcc +vg5k -clib=ansi -subtype=wav -create-app -lm program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 20480;
			}
			#endregion

			#region vz
			if (zccvariables.machine == "vz")
			{
				label1.Text = "VZ 200";
				textBox2.Text = "zcc +vz -lm -o adventure.vz adv_a.c";
				textBox3.Text = "zcc +vz -clib=ansi -lm -o adventure.vz adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region x1 **
			if (zccvariables.machine == "x1")
			{
				label1.Text = "Sharp X1";
				textBox2.Text = "zcc +x1 -lm -lndos adv_a.c";
				textBox3.Text = "zcc +x1 -pragma-define:ansicolumns=80 -lndos vtstone.c";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region Canon X07 **
			if (zccvariables.machine == "x07")
			{
				label1.Text = "Canon X-07";
				textBox2.Text = "zcc +x07 -lndos -create-app program.c";
				textBox3.Text = "zcc +x07 -lndos -create-app -Cz--audio program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 1024;
			}
			#endregion

			#region Cambridge z88 **
			if (zccvariables.machine == "z88")
			{
				label1.Text = "Cambridge z88 ";
				textBox2.Text = "zcc +z88 -create-app -oapp.bas -make-app app.c";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 16389;
			}
			#endregion

			#region zcc **
			if (zccvariables.machine == "zcc")
			{
				label1.Text = "ZCC";
				textBox2.Text = "";
				textBox3.Text = "";
				compatableTargetforZXFloats = false;
				zorgValue = 0;
			}
			#endregion

			#region zx spectrum
			if (zccvariables.machine == "zx")
			{
				label1.Text = "Sinclair ZX Spectrum";
				textBox2.Text = "zcc +zx -lndos -create-app adv_a.c";
				textBox3.Text = "zcc +zx -clib=ansi -lndos -create-app adv_a.c";
				compatableTargetforZXFloats = true;
				zorgValue = 32768;
			}
			#endregion

			#region zx80
			if (zccvariables.machine == "zx80")
			{
				label1.Text = "Sinclair ZX80";
				textBox2.Text = "zcc +zx80 -lm -create-app -Cz–audio program.c";
				textBox3.Text = "zcc +zx -clib=ansi -lndos -create-app adv_a.c";
				compatableTargetforZXFloats = false;
				zorgValue = 16389;
			}
			#endregion

			#region zx81
			if (zccvariables.machine == "zx81")
			{
				label1.Text = "Sinclair ZX81";
				textBox2.Text = "zcc +zx81 -lzx81_math -create-app program.c";
				textBox3.Text = "zcc +zx81 -lm -create-app program.c";
				compatableTargetforZXFloats = false;
				zorgValue = 16389;
			}
			#endregion
			

			trackBar1.Value = zorgValue;
			textBox7.Text = trackBar1.Value.ToString();
			textBox8.Text = trackBar1.Value.ToString();
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

		private void quick_start_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// C Library Selection new/old
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void newLibrary_CheckedChanged(object sender, EventArgs e)
		{

			#region to do whether checked or not
			//disable fsigned on sdcc only
			f_signed_char.Checked = false;
			f_signed_char.Enabled = false;

			//disable floating point options
			noFloatPoint.Checked = false;
			noFloatPoint.Enabled = false;

			lmFloatPoint.Checked = false;
			lmFloatPoint.Enabled = false;

			lmzxFloatPoint.Checked = false;
			lmzxFloatPoint.Enabled = false;

			lmzxtinyFloatPoint.Checked = false;
			lmzxtinyFloatPoint.Enabled = false;


			// disable textbox for compiling string
			textBox1.Enabled = false;
			#endregion

			#region if radio button is checked
			if (newLibrary.Checked == true)
			{
				//indicates that you are using the new library
				zccvariables.classicCompiler = false;

				//enable new library options
				library_sccZ80.Enabled = true;
				library_sdccIX_no_reserve_IY.Enabled = true;
				library_sdccIX_reserve_IY.Enabled = true;
				library_sdccIY_reserve_IY.Enabled = true;
				library_sccZ80.Checked = false;
				library_sdccIX_no_reserve_IY.Checked = false;
				library_sdccIX_reserve_IY.Checked = false;
				library_sdccIY_reserve_IY.Checked = false;

				//disable classic library options
				library_sccZ80_classic.Enabled = false;
				library_sdcc_classic.Enabled = false;
				library_sccZ80_classic.Checked = false;
				library_sdcc_classic.Checked = false;

				sdccCompilerlib = true;


				//disable and remove zorg
				string zorg = "-zorg=";
				ListOptions.Remove(zorg + zorgValue + " ");
				//MessageBox.Show("Radio Button 2 off");
				string zorgOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = zorgOption;
				panel8.Enabled = false;

				//remove and disable output file
				string createApp = "-create-app ";
				ListOptions.Remove(createApp);
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;
				checkBox3.Checked = false;
				textBox5.Text = "";
				string file = "-o " + outputFile + " ";
				ListOptions.Remove(file);
				string uncreate = string.Join("", ListOptions.ToArray());
				textBox1.Text = uncreate;
				panel6.Enabled = false;

				//remove input file
				//manual entry
				string remove_manual = manualEntry + " ";
				ListOptions.Remove(remove_manual);
				string bob = string.Join("", ListOptions.ToArray());
				textBox1.Text = bob;
				textBox6.Text = "";
				textBox6.Enabled = true;
				button15.Enabled = false;
				button16.Enabled = true;
				// remove input file 
				//browsed entry
				button8.Enabled = false;
				button9.Enabled = false;
				textBox4.Text = "";
				string file2 = fileName + " ";
				ListOptions.Remove(file2);
				string create2 = string.Join("", ListOptions.ToArray());
				textBox1.Text = create2;
				textBox4.Enabled = true;
				button7.Enabled = false;//open file button
				button8.Enabled = true;
				button9.Enabled = false;
				panel7.Enabled = false;



				library_sccZ80_classic.BackColor = Color.Transparent;
				library_sdcc_classic.BackColor = Color.Transparent;
				//change color of panel box to indicate next choice
				panel3.BackColor = Color.CadetBlue;
				///reset panel colors floating point/zorg/output file/input file
				panel2.BackColor = Color.LightBlue;
				panel8.BackColor = Color.LightBlue;
				panel6.BackColor = Color.LightBlue;
				panel7.BackColor = Color.LightBlue;
				panel5.BackColor = Color.LightBlue;
				panel10.BackColor = Color.LightBlue;

				
				
			}
			#endregion

			#region if radio button is cleared
			if (newLibrary.Checked == false)
			{
				//disable floating point options until compiler library reset
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;
				//disable floating point options until compiler library reset
			}
			#endregion

		}


		private void classicLibrary_CheckedChanged(object sender, EventArgs e)
		{
			#region to do whether checked or not
			//fsigned on sdcc only
			f_signed_char.Checked = false;
			f_signed_char.Enabled = false;
			
			//disable floating point options until compiler library reset
			noFloatPoint.Checked = false;
			noFloatPoint.Enabled = false;

			lmFloatPoint.Checked = false;
			lmFloatPoint.Enabled = false;

			lmzxFloatPoint.Checked = false;
			lmzxFloatPoint.Enabled = false;

			lmzxtinyFloatPoint.Checked = false;
			lmzxtinyFloatPoint.Enabled = false;



			
			#endregion

			#region if radio button is checked
			if (classicLibrary.Checked == true)
			{
				//MessageBox.Show("classic");

				//indicates that you are using the classic library
				zccvariables.classicCompiler = true;


				sdccCompilerlib = true;

				textBox1.Enabled = false;

				//reset all entrys on this form
				library_sccZ80.Enabled = false;
				library_sdccIX_no_reserve_IY.Enabled = false;
				library_sdccIX_reserve_IY.Enabled = false;
				library_sdccIY_reserve_IY.Enabled = false;
				library_sccZ80.Checked = false;
				library_sdccIX_no_reserve_IY.Checked = false;
				library_sdccIX_reserve_IY.Checked = false;
				library_sdccIY_reserve_IY.Checked = false;


				library_sccZ80_classic.Enabled = true;
				library_sdcc_classic.Enabled = true;
				library_sccZ80_classic.Checked = false;
				library_sdcc_classic.Checked = false;

				//disable and remove zorg
				string zorg = "-zorg=";
				ListOptions.Remove(zorg + zorgValue + " ");
				//MessageBox.Show("Radio Button 2 off");
				string zorgOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = zorgOption;
				panel8.Enabled = false;

				//remove and disable output file
				string createApp = "-create-app ";
				ListOptions.Remove(createApp);
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;
				checkBox3.Checked = false;
				textBox5.Text = "";
				string file = "-o " + outputFile + " ";
				ListOptions.Remove(file);
				string uncreate = string.Join("", ListOptions.ToArray());
				textBox1.Text = uncreate;
				panel6.Enabled = false;

				//remove input file
				//manual entry
				string remove_manual = manualEntry + " ";
				ListOptions.Remove(remove_manual);
				string bob = string.Join("", ListOptions.ToArray());
				textBox1.Text = bob;
				textBox6.Text = "";
				textBox6.Enabled = true;
				button15.Enabled = false;
				button16.Enabled = true;
				// remove input file 
				//browsed entry
				button8.Enabled = false;
				button9.Enabled = false;
				textBox4.Text = "";
				string file2 = fileName + " ";
				ListOptions.Remove(file2);
				string create2 = string.Join("", ListOptions.ToArray());
				textBox1.Text = create2;
				textBox4.Enabled = true;
				button7.Enabled = false;//open file button
				button8.Enabled = true;
				button9.Enabled = false;
				panel7.Enabled = false;


				//change color of panel box to indicate next choice
				panel3.BackColor = Color.CadetBlue;

				library_sccZ80.BackColor = Color.Transparent;
				library_sdccIX_no_reserve_IY.BackColor = Color.Transparent;
				library_sdccIX_reserve_IY.BackColor = Color.Transparent;
				library_sdccIY_reserve_IY.BackColor = Color.Transparent;


				//reset panel colors floating point/zorg/output file/input file
				panel2.BackColor = Color.LightBlue;
				panel8.BackColor = Color.LightBlue;
				panel6.BackColor = Color.LightBlue;
				panel7.BackColor = Color.LightBlue;
				panel5.BackColor = Color.LightBlue;
				panel10.BackColor = Color.LightBlue;
			}
			#endregion

			#region if radio button is cleared
			if (classicLibrary.Checked == false)
			{
				//disable floating point options until compiler library reset
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;
				//disable floating point options until compiler library reset
			}
			#endregion

		}


		/// <summary>
		/// C Library
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		//new library -clib=new
		private void library_sccZ80_CheckedChanged(object sender, EventArgs e)
		{
			#region to do whether checked or not
			checkBox3.Enabled = true;

			media_device_LNDOS.Enabled = false;
			media_device_DPLUS.Enabled = false;
			media_device_LP3DOS.Enabled = false;
			media_device_LNDOS.Checked = false;
			media_device_DPLUS.Checked = false;
			media_device_LP3DOS.Checked = false;
			#endregion

			#region if radio button is checked
			if (library_sccZ80.Checked)
			{
				string assemblertype = "-clib=new ";
				ListOptions.Add(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				sdccCompilerlib = false;

				button7.Enabled = true;//open file button

				//floating point options
				panel2.Enabled = true;

				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = true;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = true;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Black;
				lmFloatPoint.ForeColor = Color.Black;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//floating point options

				f_signed_char.Enabled = false;

				//turn on zorg
				panel8.Enabled = true;
				button18.Enabled = true;
				button19.Enabled = false;
				trackBar1.Enabled = true;
				textBox7.Enabled = true;

				//turn on input file
				panel7.Enabled = true;
				
				//turn on create app & output file
				panel6.Enabled = true;
				checkBox3.Enabled = true;

				//fsigned on sdcc only
				f_signed_char.Checked = false;
				f_signed_char.Enabled = false;

				//turn on floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.LightGray;

			}
			#endregion

			#region if radio button is cleared
			if (library_sccZ80.Checked == false)
			{
				string assemblertype = "-clib=new ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//disable floating point options until compiler library reset
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Gray;
				lmFloatPoint.ForeColor = Color.Gray;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//disable floating point options until compiler library reset

				//fsigned on sdcc only
				f_signed_char.Checked = false;
				f_signed_char.Enabled = false;

				//turn off zorg
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;

				//reset panel colors floating point/zorg/output file/input file
				panel2.BackColor = Color.LightBlue;
				panel8.BackColor = Color.LightBlue;
				panel6.BackColor = Color.LightBlue;
				panel7.BackColor = Color.LightBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.LightGray;
			}
			#endregion

		}

		//new library -clib=sdcc_ix
		private void library_sdccIX_no_reserve_IY_CheckedChanged(object sender, EventArgs e)
		{
			#region to do whether checked or not
			checkBox3.Enabled = true;

			media_device_LNDOS.Enabled = false;
			media_device_DPLUS.Enabled = false;
			media_device_LP3DOS.Enabled = false;
			media_device_LNDOS.Checked = false;
			media_device_DPLUS.Checked = false;
			media_device_LP3DOS.Checked = false;
			#endregion

			#region if radio button is checked
			if (library_sdccIX_no_reserve_IY.Checked)
			{
				string assemblertype = "-clib=sdcc_ix ";
				ListOptions.Add(assemblertype);

				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				if (compatableTargetforZXFloats == true)
				{
					sdccCompilerlib = true;
				}

				//floating point options
				panel2.Enabled = true;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = true;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = true;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Black;
				lmFloatPoint.ForeColor = Color.Black;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//floating point options

				f_signed_char.Enabled = true;


				//turn on zorg
				panel8.Enabled = true;
				button18.Enabled = true;
				button19.Enabled = false;
				trackBar1.Enabled = true;
				textBox7.Enabled = true;

				//turn on input file
				panel7.Enabled = true;

				//turn on create app & output file
				panel6.Enabled = true;
				checkBox3.Enabled = true;

				//turn on fsigned
				panel10.Enabled = true;
				f_signed_char.Enabled = true;
				f_signed_char.Checked = false;

				//turn on floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.CadetBlue;
			}
			#endregion

			#region if radio button is cleared
			if (library_sdccIX_no_reserve_IY.Checked == false)
			{
				string assemblertype = "-clib=sdcc_ix ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//disable floating point options until compiler library reset
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Gray;
				lmFloatPoint.ForeColor = Color.Gray;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//disable floating point options until compiler library reset

				//turn off zorg
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;

				//turn off floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.LightGray;
			}
			#endregion

		}

		//new library -clib=sdcc_iy --reserve-regs-iy
		private void library_sdccIY_reserve_IY_CheckedChanged(object sender, EventArgs e)
		{
			#region to do whether checked or not
			checkBox3.Enabled = true;

			if (compatableTargetforZXFloats == true)
			{
				sdccCompilerlib = true;
			}


			media_device_LNDOS.Enabled = false;
			media_device_DPLUS.Enabled = false;
			media_device_LP3DOS.Enabled = false;
			media_device_LNDOS.Checked = false;
			media_device_DPLUS.Checked = false;
			media_device_LP3DOS.Checked = false;
			button7.Enabled = true;//open file button

			#endregion

			#region if radio button is checked
			if (library_sdccIY_reserve_IY.Checked)
			{
				string assemblertype = "-clib=sdcc_iy ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
				sdccCompilerlib = true;

				//floating point options
				panel2.Enabled = true;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = true;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = true;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Black;
				lmFloatPoint.ForeColor = Color.Black;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//floating point options

				f_signed_char.Enabled = true;

				//turn on zorg
				panel8.Enabled = true;
				button18.Enabled = true;
				button19.Enabled = false;
				trackBar1.Enabled = true;
				textBox7.Enabled = true;

				//turn on input file
				panel7.Enabled = true;

				//turn on create app & output file
				panel6.Enabled = true;
				checkBox3.Enabled = true;

				//turn on fsigned
				panel10.Enabled = true;
				f_signed_char.Enabled = true;
				f_signed_char.Checked = false;

				//turn on floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.CadetBlue;
			}
			#endregion

			#region if radio button is cleared
			if (library_sdccIY_reserve_IY.Checked == false)
			{
				string assemblertype = "-clib=sdcc_iy ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//disable floating point options until compiler library reset
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Gray;
				lmFloatPoint.ForeColor = Color.Gray;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//disable floating point options until compiler library reset

				//turn off zorg
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;

				//turn off floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.LightGray;
			}
			#endregion

		}

		//new library	-clib=sdcc_ix
		private void library_sdccIX_reserve_IY_CheckedChanged(object sender, EventArgs e)
		{

			#region to do whether checked or not
			if (compatableTargetforZXFloats == true)
			{
				sdccCompilerlib = true;
			}
			if (compatableTargetforZXFloats == false)
			{

			}

			media_device_LNDOS.Enabled = false;
			media_device_DPLUS.Enabled = false;
			media_device_LP3DOS.Enabled = false;
			media_device_LNDOS.Checked = false;
			media_device_DPLUS.Checked = false;
			media_device_LP3DOS.Checked = false;
			button7.Enabled = true;//open file button

			//checkBox1.Enabled = true;
			checkBox3.Enabled = true;
			#endregion

			#region if radio button is checked
			if (library_sdccIX_reserve_IY.Checked)
			{
				string assemblertype = "-clib=sdcc_ix --reserve-regs-iy ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;
				sdccCompilerlib = true;

				//floating point options
				panel2.Enabled = true;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = true;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = true;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Black;
				lmFloatPoint.ForeColor = Color.Black;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//floating point options				

				//turn on zorg
				panel8.Enabled = true;
				button18.Enabled = true;
				button19.Enabled = false;
				trackBar1.Enabled = true;
				textBox7.Enabled = true;

				//turn on input file
				panel7.Enabled = true;

				//turn on create app & output file
				panel6.Enabled = true;
				checkBox3.Enabled = true;

				//turn on fsigned
				panel10.Enabled = true;
				f_signed_char.Enabled = true;
				f_signed_char.Checked = false;

				//turn on floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.CadetBlue;

			}
			#endregion

			#region if radio button is cleared
			if (library_sdccIX_reserve_IY.Checked == false)
			{
				string assemblertype = "-clib=sdcc_ix --reserve-regs-iy ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//disable floating point options until compiler library reset
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;

				noFloatPoint.ForeColor = Color.Gray;
				lmFloatPoint.ForeColor = Color.Gray;
				lmzxFloatPoint.ForeColor = Color.Gray;
				lmzxtinyFloatPoint.ForeColor = Color.Gray;
				//disable floating point options until compiler library reset

				//turn off zorg
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;

				//turn off floating point/zorg/output file/input file
				panel2.BackColor = Color.CadetBlue;
				panel8.BackColor = Color.CadetBlue;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;
				//disk device not needed, grey out
				panel5.BackColor = Color.LightGray;
				panel10.BackColor = Color.LightGray;
			}
			#endregion
		
		}

		//classic library
		private void library_sdcc_classic_CheckedChanged(object sender, EventArgs e)
		{
			#region to do whether checked or not
			checkBox3.Enabled = false;

			media_device_LNDOS.Enabled = true;
			media_device_DPLUS.Enabled = true;
			media_device_LP3DOS.Enabled = true;


			media_device_LNDOS.Checked = false;
			media_device_DPLUS.Checked = false;
			media_device_LP3DOS.Checked = false;

			button7.Enabled = false;//open file button
			#endregion

			//-compiler=sdcc
			#region if radio button is checked
			if (library_sdcc_classic.Checked)
			{
				zccvariables.sdcc_compiler = true;

				string assemblertype = "-compiler=sdcc ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				// floating point options, disable panel until media selected
				panel2.Enabled = false;
				panel2.BackColor = Color.LightBlue;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = true;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = true;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = true;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = true;
				// floating point options, disable panel until media selected

				//f_signed option
				f_signed_char.Enabled = false;
				panel10.Enabled = false;
				panel10.BackColor = Color.LightBlue;

				bool machineFloat = machine_type_for_floating_point(false);

				if (machineFloat == true)
				{
					lmzxFloatPoint.Enabled = true;
					lmzxtinyFloatPoint.Enabled = true;
				}

				//turn on floating point/zorg/output file/input file
				//panel2.BackColor = Color.CadetBlue;
				panel5.BackColor = Color.CadetBlue;

				media_device_DPLUS.ForeColor = Color.Gray;
				media_device_LP3DOS.ForeColor = Color.Gray;

				f_signed_char.Enabled = false;
				f_signed_char.Checked = false;
			}
			#endregion

			#region if radio button is cleared
			if (library_sdcc_classic.Checked == false)
			{
				string assemblertype = "-compiler=sdcc ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//disable floating point options until compiler library reset
				panel2.Enabled = false;//problem?
				panel2.BackColor = Color.LightBlue;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;
				//disable floating point options until compiler library reset

				f_signed_char.Enabled = false;

				media_device_DPLUS.ForeColor = Color.Black;
				media_device_LP3DOS.ForeColor = Color.Black;
			}
			#endregion
		}

		//classic library
		private void library_sccZ80_classic_CheckedChanged(object sender, EventArgs e)
		{

			#region to do whether checked or not
			checkBox3.Enabled = false;

			media_device_LNDOS.Enabled = true;
			media_device_DPLUS.Enabled = true;
			media_device_LP3DOS.Enabled = true;

			media_device_LNDOS.Checked = false;
			media_device_DPLUS.Checked = false;
			media_device_LP3DOS.Checked = false;
			button7.Enabled = false;//open file button
			#endregion


			//-compiler=sccz80
			#region if radio button is checked
			if (library_sccZ80_classic.Checked)
			{

				string assemblertype = "-compiler=sccz80 ";
				ListOptions.Add(assemblertype);
				//MessageBox.Show("Radio Button 2 off");
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//floating point options
				panel2.Enabled = true;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = true;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = true;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = true;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = true;

				panel2.Enabled = false;
				panel2.BackColor = Color.LightBlue;
				//floating point options

				f_signed_char.Enabled = false;
				panel10.BackColor = Color.LightGray;

				

				bool machineFloat = machine_type_for_floating_point(false);

				if (machineFloat == true)
				{
					lmzxFloatPoint.Enabled = true;
					lmzxtinyFloatPoint.Enabled = true;
				}

				//turn on floating point/zorg/output file/input file
				panel5.BackColor = Color.CadetBlue;
				zccvariables.sdcc_compiler = false;
				media_device_DPLUS.ForeColor = Color.Gray;
				media_device_LP3DOS.ForeColor = Color.Gray;


				f_signed_char.Enabled = false;
				f_signed_char.Checked = false;
			}
			#endregion

			#region if radio button is cleared
			if (library_sccZ80_classic.Checked == false)
			{
				string assemblertype = "-compiler=sccz80 ";
				ListOptions.Remove(assemblertype);
				string assembler = string.Join("", ListOptions.ToArray());
				textBox1.Text = assembler;

				//disable floating point options until compiler library reset
				panel2.Enabled = false;//problem
				panel2.BackColor = Color.LightBlue;
				noFloatPoint.Checked = false;
				noFloatPoint.Enabled = false;

				lmFloatPoint.Checked = false;
				lmFloatPoint.Enabled = false;

				lmzxFloatPoint.Checked = false;
				lmzxFloatPoint.Enabled = false;

				lmzxtinyFloatPoint.Checked = false;
				lmzxtinyFloatPoint.Enabled = false;
				//disable floating point options until compiler library reset

				f_signed_char.Enabled = false;

				panel10.BackColor = Color.LightGray;

				media_device_DPLUS.ForeColor = Color.Black;
				media_device_LP3DOS.ForeColor = Color.Black;
			}
			#endregion
		}








		/// <summary>
		/// C Library
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//classic library






		/// <summary>
		/// No Floating Point Library
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// LM Floating Point Library
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// LMZX Floating Point Library
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// LMZX Tiny Floating Point Library
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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







		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			

		}







		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			

		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			//-create-app
			if (checkBox3.Checked)
			{
				string createApp = "-create-app ";
				ListOptions.Add(createApp);
				//MessageBox.Show("Radio Button 2 off");
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

				textBox5.Enabled = true;

				button12.Enabled = true;
				button13.Enabled = false;

			}
			else if (checkBox3.Checked == false)
			{
				string createApp = "-create-app ";
				ListOptions.Remove(createApp);
				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

				textBox5.Enabled = false;
			}

		}

		//open file button
		private void button7_Click(object sender, EventArgs e)
		{
			// Show the dialog and get result.
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				//MessageBox.Show("holy moley");
				//fileName = openFileDialog1.FileName;
				fileName = openFileDialog1.SafeFileName;
				textBox4.Text = fileName;
				button8.Enabled = true;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			//add file name
			string file = fileName + " ";
			ListOptions.Add(file);

			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;

			textBox4.Enabled = false;
			textBox1.Enabled = true;

			button7.Enabled = true;//open file button
			button8.Enabled = false;
			button9.Enabled = true;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			//remove file name
			button8.Enabled = false;
			button9.Enabled = false;
			textBox4.Text = "";

			string file = fileName + " ";
			ListOptions.Remove(file);
			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;

			textBox4.Enabled = true;
			button7.Enabled = false;//open file button
			button8.Enabled = true;
			button9.Enabled = false;
			//textBox1.Enabled = false;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			button12.Enabled = true;
			button13.Enabled = true;
			/*
			 // Show the dialog and get result.
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				//MessageBox.Show("holy moley");
				//fileName = openFileDialog1.FileName;
				fileName = openFileDialog1.SafeFileName;
				textBox4.Text = fileName;
				button8.Enabled = true;
				button9.Enabled = true;
			}
			 */


		}

		private void button12_Click(object sender, EventArgs e)
		{

			if (textBox5.Text == "")
			{
				button12.Enabled = true;
				button13.Enabled = false;
			}
			else
			{
				outputFile = textBox5.Text;
				string file = "-o " + outputFile + " ";
				ListOptions.Add(file);

				string create = string.Join("", ListOptions.ToArray());
				textBox1.Text = create;

				button12.Enabled = false;
				button13.Enabled = true;

				textBox4.Enabled = true;
				textBox6.Enabled = true;
				//button12.Enabled = false;
				textBox5.Enabled = false;

				button8.Enabled = true;
				button7.Enabled = true;
			}
			
						
		}

		private void button13_Click(object sender, EventArgs e)
		{			
			textBox5.Text = "";

			string file = "-o " + outputFile + " ";
			ListOptions.Remove(file);
			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;

			button12.Enabled = true;
			button13.Enabled = false;
			textBox5.Enabled = true;
		}


		private void radioButton12_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void media_device_LNDOS_CheckedChanged(object sender, EventArgs e)
		{
			if (media_device_LNDOS.Checked)
			{
				string nodosLibrary = "-lndos ";
				ListOptions.Add(nodosLibrary);
				//MessageBox.Show("Radio Button 2 off");
				string nodos = string.Join("", ListOptions.ToArray());
				textBox1.Text = nodos;


				panel2.BackColor = Color.CadetBlue;
				panel2.Enabled = true;

				noFloatPoint.ForeColor = Color.Black;
				lmFloatPoint.ForeColor = Color.Black;
				lmzxFloatPoint.ForeColor = Color.Black;
				lmzxtinyFloatPoint.ForeColor = Color.Black;

				panel8.Enabled = false;
				panel6.Enabled = true;
				panel7.Enabled = true;

				panel8.BackColor = Color.LightGray;
				panel6.BackColor = Color.CadetBlue;
				panel7.BackColor = Color.CadetBlue;

				if (zccvariables.sdcc_compiler == true)
				{
					panel10.BackColor = Color.CadetBlue;
					panel10.Enabled = true;

					f_signed_char.Enabled = true;
					f_signed_char.Checked = false;
				}

				if (zccvariables.sdcc_compiler == false)
				{
					panel10.BackColor = Color.LightGray;
					panel10.Enabled = false;

					f_signed_char.Enabled = false;
					f_signed_char.Checked = false;
				}

			}
			else if (media_device_LNDOS.Checked == false)
			{
				string nodosLibrary = "-lndos ";
				ListOptions.Remove(nodosLibrary);
				string nodos = string.Join("", ListOptions.ToArray());
				textBox1.Text = nodos;

				panel2.BackColor = Color.LightBlue;
				panel2.Enabled = false;
				panel6.BackColor = Color.LightBlue;
				panel7.BackColor = Color.LightBlue;
				panel5.BackColor = Color.LightBlue;

				if (zccvariables.sdcc_compiler == true)
				{
					panel10.BackColor = Color.CadetBlue;
					panel10.Enabled = true;
				}

				if (zccvariables.sdcc_compiler == false)
				{
					panel10.BackColor = Color.LightGray;
					panel10.Enabled = false;
				}

			}
			//textBox1.ShortcutsEnabled = true;
			textBox1.Enabled = false;
			checkBox3.Enabled = true;
			checkBox3.Checked = false;

			button7.Enabled = true;//open file button

			if (newLibrary.Checked == true)
			{
				button18.Enabled = true;
				button19.Enabled = false;
				trackBar1.Enabled = true;
				textBox7.Enabled = true;
			}
			if (newLibrary.Checked == false)
			{
				button18.Enabled = true;
				button19.Enabled = false;
				trackBar1.Enabled = true;
				textBox7.Enabled = true;
			}


		}


		private void media_device_DPLUS_CheckedChanged(object sender, EventArgs e)
		{
			if (media_device_DPLUS.Checked)
			{
				string nodosLibrary = "-DPLUS3 ";
				ListOptions.Add(nodosLibrary);
				MessageBox.Show("Not Yet Implemented. Sorry \nChoose another Media");
				string nodos = string.Join("", ListOptions.ToArray());
				textBox1.Text = nodos;
			}
			else if (media_device_DPLUS.Checked == false)
			{
				string nodosLibrary = "-DPLUS3 ";
				ListOptions.Remove(nodosLibrary);
				string nodos = string.Join("", ListOptions.ToArray());
				textBox1.Text = nodos;
			}
			//textBox1.ShortcutsEnabled = true;
			textBox1.Enabled = true;
			checkBox3.Enabled = true;
			checkBox3.Checked = false;

			button7.Enabled = true;//open file button

			if (newLibrary.Checked == true)
			{
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;
			}
			if (newLibrary.Checked == false)
			{
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;
			}
		}

		private void media_device_LP3DOS_CheckedChanged(object sender, EventArgs e)
		{
			if (media_device_LP3DOS.Checked)
			{
				string nodosLibrary = "-lp3dos ";
				ListOptions.Add(nodosLibrary);
				MessageBox.Show("Not Yet Implemented. Sorry \nChoose another Media");
				string nodos = string.Join("", ListOptions.ToArray());
				textBox1.Text = nodos;
			}
			else if (media_device_LP3DOS.Checked == false)
			{
				string nodosLibrary = "-lp3dos ";
				ListOptions.Remove(nodosLibrary);
				string nodos = string.Join("", ListOptions.ToArray());
				textBox1.Text = nodos;
			}
			//textBox1.ShortcutsEnabled = true;
			textBox1.Enabled = true;
			checkBox3.Enabled = true;
			checkBox3.Checked = false;
			button7.Enabled = true;//open file button

			if (newLibrary.Checked == true)
			{
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;
			}
			if (newLibrary.Checked == false)
			{
				button18.Enabled = false;
				button19.Enabled = false;
				trackBar1.Enabled = false;
				textBox7.Enabled = false;
			}
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button16_Click(object sender, EventArgs e)
		{

			if (textBox5.Text == "")
			{
				button16.Enabled = false;
				button15.Enabled = false;
			}


			manualEntry = textBox6.Text;
			string manual = manualEntry + " ";

			string create = string.Join("", manual.ToArray());
			ListOptions.Add(create);

			string manualEntry1 = string.Join("", ListOptions.ToArray());


			textBox1.Text = manualEntry1;

			textBox1.Enabled = true;
			button15.Enabled = true;
			button16.Enabled = false;
			textBox6.Enabled = false;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			//textBox6
			string remove_manual = manualEntry + " ";
			ListOptions.Remove(remove_manual);

			string bob = string.Join("", ListOptions.ToArray());
			textBox1.Text = bob;

			// form maintainence
			textBox6.Text = "";
			textBox6.Enabled = true;

			button15.Enabled = false;
			button16.Enabled = true;

			//textBox1.Enabled = false;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			textBox7.Text = trackBar1.Value.ToString();
			textBox8.Text = trackBar1.Value.ToString();

			zorgValue = trackBar1.Value;
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			int temp;			
			
			if (!int.TryParse(textBox7.Text, out temp))//check to see if letters
			{
				if (textBox7.TextLength > 0) 
				{
					textBox7.Text = textBox7.Text.Substring(0, textBox7.Text.Length - 1);

					textBox7.Focus();
					textBox7.SelectionStart = textBox7.Text.Length;
				}
			}



			//if (int.Parse(textBox7.Text, out number))
			if (int.TryParse(textBox7.Text, out temp))
			{
				if (temp > 65535)
				{
					//too high
					MessageBox.Show("The ZORG setting is too high");
					temp = 65535;
					textBox7.Text = "65535";

					textBox7.Focus();
					textBox7.SelectionStart = textBox7.Text.Length;
				}
				if (temp < 0)
				{
					//too low
					MessageBox.Show("The ZORG setting is too low");
					temp = 0;
					textBox7.Text = "0";

					textBox7.Focus();
					textBox7.SelectionStart = textBox7.Text.Length;
				}

				
				else
				{
					// just right
					temp = int.Parse(textBox7.Text);
					trackBar1.Value = int.Parse(temp.ToString());
					textBox8.Text = textBox7.Text;

					zorgValue = temp;
				}
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			string zorg = "-zorg=";
			ListOptions.Add(zorg + zorgValue + " ");
			//MessageBox.Show("Radio Button 2 off");
			string zorgOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = zorgOption;

			button18.Enabled = false;
			button19.Enabled = true;
			textBox7.Enabled = false;
			trackBar1.Enabled = false;
			reset_zorg.Enabled = false;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			string zorg = "-zorg=";
			ListOptions.Remove(zorg + zorgValue + " ");
			//MessageBox.Show("Radio Button 2 off");
			string zorgOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = zorgOption;

			button18.Enabled = true;
			button19.Enabled = false;
			textBox7.Enabled = true;
			trackBar1.Enabled = true;
			reset_zorg.Enabled = true;
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
			textBox7.Text = zorgValue.ToString();
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

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			if (textBox6.Text != "")
			{
				button16.Enabled = true;
			}
			else
			{
				button16.Enabled = false;
			}
		}
	}
}
