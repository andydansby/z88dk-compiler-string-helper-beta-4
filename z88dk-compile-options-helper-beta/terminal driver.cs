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
	public partial class terminal_driver : Form
	{
		public List<string> ListOptions = new List<string>();
		int startUP_Value = 0;

		public terminal_driver()
		{
			InitializeComponent();
		}		

		public terminal_driver(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			enableOptions();

			#region new compiler
/*
			if (zccvariables.classicCompiler == false)
			{
				//.true.MessageBox.Show("Classic Compiler");

				compiler_type.Text = "New Compiler";

				panel4.Enabled = true;
				panel3.Enabled = true;
				panel2.Enabled = false;

				panel3.BackColor = Color.CadetBlue;
				panel4.BackColor = Color.CadetBlue;
				panel2.BackColor = Color.DarkGray;

				radioButton2.Enabled = true;
				radioButton1.Enabled = true;
				radioButton3.Enabled = true;
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
				radioButton6.Enabled = true;
				radioButton7.Enabled = true;
				radioButton15.Enabled = false;
				radioButton14.Enabled = true;
				radioButton13.Enabled = true;
				radioButton12.Enabled = true;
				radioButton11.Enabled = true;
				radioButton10.Enabled = true;
				radioButton9.Enabled = true;
				radioButton8.Enabled = true;

				radioButton2.Checked = false;
				radioButton1.Checked = false;
				radioButton3.Checked = false;
				radioButton4.Checked = false;
				radioButton5.Checked = false;
				radioButton6.Checked = false;
				radioButton7.Checked = false;
				radioButton14.Checked = false;
				radioButton13.Checked = false;
				radioButton12.Checked = false;
				radioButton11.Checked = false;
				radioButton10.Checked = false;
				radioButton9.Checked = false;
				radioButton8.Checked = false;

				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;
				radioButton19.Enabled = false;
				radioButton20.Enabled = false;
				radioButton21.Enabled = false;
				radioButton22.Enabled = false;
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;
				radioButton28.Enabled = false;
				radioButton29.Enabled = false;
				radioButton30.Enabled = false;
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton42.Enabled = false;
				radioButton43.Enabled = false;
			}
 */
			#endregion

			#region classic compiler
/*
			if (zccvariables.classicCompiler == true)
			{
				//MessageBox.Show("New Compiler");

				compiler_type.Text = "Classic Compiler";

				panel4.Enabled = false;
				panel3.Enabled = false;
				panel2.Enabled = true;

				panel3.BackColor = Color.DarkGray;
				panel4.BackColor = Color.DarkGray;
				panel2.BackColor = Color.CadetBlue;

				radioButton1.Enabled = false;
				radioButton2.Enabled = false;				
				radioButton3.Enabled = false;
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;
				radioButton7.Enabled = false;

				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;
				radioButton11.Enabled = false;
				radioButton12.Enabled = false;
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				

				radioButton15.Enabled = true;
				radioButton16.Enabled = true;
				radioButton17.Enabled = true;
				radioButton18.Enabled = true;
				radioButton19.Enabled = true;
				radioButton20.Enabled = true;
				radioButton21.Enabled = true;
				radioButton22.Enabled = true;
				radioButton23.Enabled = true;
				radioButton24.Enabled = true;
				radioButton25.Enabled = true;
				radioButton26.Enabled = true;
				radioButton27.Enabled = true;
				radioButton28.Enabled = true;
				radioButton29.Enabled = true;
				radioButton30.Enabled = true;
				radioButton31.Enabled = true;
				radioButton32.Enabled = true;
				radioButton33.Enabled = true;
				radioButton34.Enabled = true;
				radioButton35.Enabled = true;
				radioButton36.Enabled = true;
				radioButton37.Enabled = true;
				radioButton38.Enabled = true;
				radioButton39.Enabled = true;
				radioButton40.Enabled = true;
				radioButton41.Enabled = true;
				radioButton42.Enabled = true;
				radioButton43.Enabled = true;

			}
*/
			#endregion



			#region choose machine

			#region Luxor ABC80
			if (zccvariables.machine == "abc80")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Luxor ABC800
			if (zccvariables.machine == "abc800")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Jupiter ACE
			if (zccvariables.machine == "ace")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Mattel Aquarius
			if (zccvariables.machine == "aquarius")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Commodore 128
			if (zccvariables.machine == "c128")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Philips Videopac C7420
			if (zccvariables.machine == "c7420")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region CPC
			if (zccvariables.machine == "cpc")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region CP/M
			if (zccvariables.machine == "cpm")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Embedded
			if (zccvariables.machine == "embedded")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1 / CRT";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Enterprise 64/128 Platform
			if (zccvariables.machine == "enterprise")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Galaksija
			if (zccvariables.machine == "gal")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Lambda 8300
			//Lambda 8300
			//improved chinese clone of the ZX81
			if (zccvariables.machine == "lambda")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Camputers Lynx
			if (zccvariables.machine == "lynx")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Sord M5
			if (zccvariables.machine == "m5")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region CCE MC-1000
			if (zccvariables.machine == "mc1000")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region MSX
			if (zccvariables.machine == "msx")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = true;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Memotech MTX
			if (zccvariables.machine == "mtx")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region NASCOM 1 & 2
			if (zccvariables.machine == "nascom")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Amstrad NC
			if (zccvariables.machine == "nc")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Grundy Newbrain
			if (zccvariables.machine == "newbrain")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2 / irq extender (under development)";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Old School Computer Architecture
			if (zccvariables.machine == "osca")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Sharp OZ-700
			if (zccvariables.machine == "oz")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2 / DK compatibility mode";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Philips P2000
			if (zccvariables.machine == "p2000")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region NEC PC-6001
			if (zccvariables.machine == "pc6001")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Peters Plus Sprinter
			if (zccvariables.machine == "pps")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region RCMX000
			if (zccvariables.machine == "rcmx000")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Xircom REX 6000
			if (zccvariables.machine == "rex")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region SAM Coupe
			if (zccvariables.machine == "sam")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region SEGA SC-3000
			if (zccvariables.machine == "sc3000")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region SMS
			if (zccvariables.machine == "sms")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region S-OS (The Sentinel)
			if (zccvariables.machine == "sos")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Sorcerer Exidy
			if (zccvariables.machine == "srr")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Spectravideo SVI
			if (zccvariables.machine == "svi")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Texas Instruments TI8X
			if (zccvariables.machine == "ti8x")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Texas Instruments TI82
			if (zccvariables.machine == "ti82")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Texas Instruments TI83
			if (zccvariables.machine == "ti83")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = true;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = true;//startup 3
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
				radioButton6.Enabled = true;//startup 6
				radioButton7.Enabled = true;//startup 7
				radioButton8.Enabled = true;
				radioButton9.Enabled = true;
				radioButton10.Enabled = true;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1 / Ion, Ti-Explorer";//startup 1
				radioButton2.Text = "-startup=2 / Venus";//startup 2
				radioButton3.Text = "-startup=3 / ZES";//startup 3
				radioButton4.Text = "-startup=4 / Anova, SOS";//startup 4
				radioButton5.Text = "-startup=5 / Ti-Explorer, AShell, SOS, Anova";//startup 5
				radioButton6.Text = "-startup=6 / Ti-Explorer, AShell, SOS, Anova";//startup 6
				radioButton7.Text = "-startup=7 / SOS, Anova";//startup 7
				radioButton8.Text = "-startup=8 / Venus Explorer, Venus";//startup 8
				radioButton9.Text = "-startup=9 / Ion, Ti-Explorer, ZASMLOAD, plain TIOS";//startup 9
				radioButton10.Text = "-startup=10 / Plain TIOS, ZASMLOAD";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Texas Instruments TI85
			if (zccvariables.machine == "ti85")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = true;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1 / Rigel";//startup 1
				radioButton2.Text = "-startup=2 / PhatOS (unstable)";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Texas Instruments TI86
			if (zccvariables.machine == "ti86")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region trs80 ** & EG2000
			if (zccvariables.machine == "trs80")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region ts2068
			if (zccvariables.machine == "ts2068")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = true;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = true;
				radioButton9.Enabled = true;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = true;
				radioButton32.Enabled = true;
				radioButton33.Enabled = true;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = true;
				radioButton37.Enabled = true;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = true;
				radioButton41.Enabled = true;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0 / output: 32x24 no control codes";//startup 0
				radioButton1.Text = "-startup=1 / output: 32x24 w/ control codes";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4 / 64x24 fixed width no control codes";//startup 4
				radioButton5.Text = "-startup=5 / 64x24 fixed width w/ control codes";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8 / output: fzx proportional font no control";//startup 8
				radioButton9.Text = "-startup=9 / output: fzx proportional font w/ control";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31 used for Games with no need for Terminal";//startup 31
				radioButton32.Text = "-startup=32 IF2 Cart output: 32x24 no control codes";//startup 32
				radioButton33.Text = "-startup=33 IF2 Cart output: 32x24 w/ control codes";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36 IF2 Cart 64x24 fixed width no control codes";//startup 36
				radioButton37.Text = "-startup=37 IF2 Cart 64x24 fixed width w/ control codes";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40 IF2 Cart fzx proportional font no control";//startup 40
				radioButton41.Text = "-startup=41 IF2 Cart fzx proportional font w/ control";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region vg5k
			//vg5000
			if (zccvariables.machine == "vg5k")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region vz
			if (zccvariables.machine == "vz")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region x1 **
			if (zccvariables.machine == "x1")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Canon X07 **
			if (zccvariables.machine == "x07")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region Cambridge z88 **
			if (zccvariables.machine == "z88")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region zcc **
			if (zccvariables.machine == "zcc")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region zx spectrum / possible interface 1?
			if (zccvariables.machine == "zx")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = true;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = true;
				radioButton9.Enabled = true;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = true;
				radioButton32.Enabled = true;
				radioButton33.Enabled = true;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = true;
				radioButton37.Enabled = true;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = true;
				radioButton41.Enabled = true;
				radioButton63.Enabled = true;

				radioButton0.Text = "-startup=0 / output: 32x24 no control codes";//startup 0
				radioButton1.Text = "-startup=1 / output: 32x24 w/ control codes";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4 / 64x24 fixed width no control codes";//startup 4
				radioButton5.Text = "-startup=5 / 64x24 fixed width w/ control codes";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8 / output: fzx proportional font no control";//startup 8
				radioButton9.Text = "-startup=9 / output: fzx proportional font w/ control";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31 used for Games with no need for Terminal";//startup 31
				radioButton32.Text = "-startup=32 IF2 Cart output: 32x24 no control codes";//startup 32
				radioButton33.Text = "-startup=33 IF2 Cart output: 32x24 w/ control codes";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36 IF2 Cart 64x24 fixed width no control codes";//startup 36
				radioButton37.Text = "-startup=37 IF2 Cart 64x24 fixed width w/ control codes";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40 IF2 Cart fzx proportional font no control";//startup 40
				radioButton41.Text = "-startup=41 IF2 Cart fzx proportional font w/ control";//startup 41
				radioButton63.Text = "-startup=63 IF2 used for Games with no need for Terminal";//startup 63

				//
				//256×192 WRX HRG
			}
			#endregion

			#region zx80
			if (zccvariables.machine == "zx80")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion

			#region zx81
			if (zccvariables.machine == "zx81")
			{
				radioButton0.Enabled = true;
				radioButton1.Enabled = true;
				radioButton2.Enabled = true;//startup 2
				radioButton3.Enabled = true;//startup 3
				radioButton4.Enabled = true;
				radioButton5.Enabled = true;
				radioButton6.Enabled = true;//startup 6
				radioButton7.Enabled = true;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = true;
				radioButton14.Enabled = true;
				radioButton15.Enabled = true;
				radioButton16.Enabled = true;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = true;
				radioButton24.Enabled = true;
				radioButton25.Enabled = true;
				radioButton26.Enabled = true;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = true;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1 / FAST mode, no video output";//startup 1
				radioButton2.Text = "-startup=2 / SLOW mode, no high resolution";//startup 2
				radioButton3.Text = "-startup=3 / 256×192 WRX HRG (1)";//startup 3
				radioButton4.Text = "-startup=4 / 256×192 WRX HRG (2)";//startup 4
				radioButton5.Text = "-startup=5 / 256×64 WRX HRG (1)";//startup 5
				radioButton6.Text = "-startup=6 / 256×64 WRX HRG (2)";//startup 6
				radioButton7.Text = "-startup=7 / 256×64 Grayscale HRG";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13 / 256×192 ARX HRG(1)";//startup 13
				radioButton14.Text = "-startup=14 / 256×192 ARX HRG(2)";//startup 14
				radioButton15.Text = "-startup=15 / 256×64 ARX HRG(1)";//startup 15
				radioButton16.Text = "-startup=16 / 256×64 ARX HRG(2)";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23 256×192 WRX HRG + CHROMA81 (1)";//startup 23
				radioButton24.Text = "-startup=24 256×192 WRX HRG + CHROMA81 (2)";//startup 24
				radioButton25.Text = "-startup=25 256×64 WRX HRG + CHROMA81 (1)";//startup 25
				radioButton26.Text = "-startup=26 256×64 WRX HRG + CHROMA81 (2)";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31 used for Games with no need for Terminal";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
			}
			#endregion


/*
				radioButton0.Enabled = true;
				radioButton1.Enabled = false;
				radioButton2.Enabled = false;//startup 2
				radioButton3.Enabled = false;//startup 3
				radioButton4.Enabled = false;
				radioButton5.Enabled = false;
				radioButton6.Enabled = false;//startup 6
				radioButton7.Enabled = false;//startup 7
				radioButton8.Enabled = false;
				radioButton9.Enabled = false;
				radioButton10.Enabled = false;//startup 10
				radioButton11.Enabled = false;//startup 11
				radioButton12.Enabled = false;//startup 12
				radioButton13.Enabled = false;
				radioButton14.Enabled = false;
				radioButton15.Enabled = false;
				radioButton16.Enabled = false;
				radioButton17.Enabled = false;
				radioButton18.Enabled = false;//startup 18
				radioButton19.Enabled = false;//startup 19
				radioButton20.Enabled = false;//startup 20
				radioButton21.Enabled = false;//startup 21
				radioButton22.Enabled = false;//startup 22
				radioButton23.Enabled = false;
				radioButton24.Enabled = false;
				radioButton25.Enabled = false;
				radioButton26.Enabled = false;
				radioButton27.Enabled = false;//startup 27
				radioButton28.Enabled = false;//startup 28
				radioButton29.Enabled = false;//startup 29
				radioButton30.Enabled = false;//startup 30
				radioButton31.Enabled = false;
				radioButton32.Enabled = false;
				radioButton33.Enabled = false;
				radioButton34.Enabled = false;
				radioButton35.Enabled = false;
				radioButton36.Enabled = false;
				radioButton37.Enabled = false;
				radioButton38.Enabled = false;
				radioButton39.Enabled = false;
				radioButton40.Enabled = false;
				radioButton41.Enabled = false;
				radioButton63.Enabled = false;

				radioButton0.Text = "-startup=0";//startup 0
				radioButton1.Text = "-startup=1";//startup 1
				radioButton2.Text = "-startup=2";//startup 2
				radioButton3.Text = "-startup=3";//startup 3
				radioButton4.Text = "-startup=4";//startup 4
				radioButton5.Text = "-startup=5";//startup 5
				radioButton6.Text = "-startup=6";//startup 6
				radioButton7.Text = "-startup=7";//startup 7
				radioButton8.Text = "-startup=8";//startup 8
				radioButton9.Text = "-startup=9";//startup 9
				radioButton10.Text = "-startup=10";//startup 10
				radioButton11.Text = "-startup=11";//startup 11
				radioButton12.Text = "-startup=12";//startup 12
				radioButton13.Text = "-startup=13";//startup 13
				radioButton14.Text = "-startup=14";//startup 14
				radioButton15.Text = "-startup=15";//startup 15
				radioButton16.Text = "-startup=16";//startup 16
				radioButton17.Text = "-startup=17";//startup 17
				radioButton18.Text = "-startup=18";//startup 18
				radioButton19.Text = "-startup=19";//startup 19
				radioButton20.Text = "-startup=20";//startup 20
				radioButton21.Text = "-startup=21";//startup 21
				radioButton22.Text = "-startup=22";//startup 22
				radioButton23.Text = "-startup=23";//startup 23
				radioButton24.Text = "-startup=24";//startup 24
				radioButton25.Text = "-startup=25";//startup 25
				radioButton26.Text = "-startup=26";//startup 26
				radioButton27.Text = "-startup=27";//startup 27
				radioButton28.Text = "-startup=28";//startup 28
				radioButton29.Text = "-startup=29";//startup 29
				radioButton30.Text = "-startup=30";//startup 30
				radioButton31.Text = "-startup=31";//startup 31
				radioButton32.Text = "-startup=32";//startup 32
				radioButton33.Text = "-startup=33";//startup 33
				radioButton34.Text = "-startup=34";//startup 34
				radioButton35.Text = "-startup=35";//startup 35
				radioButton36.Text = "-startup=36";//startup 36
				radioButton37.Text = "-startup=37";//startup 37
				radioButton38.Text = "-startup=38";//startup 38
				radioButton39.Text = "-startup=39";//startup 39
				radioButton40.Text = "-startup=40";//startup 40
				radioButton41.Text = "-startup=41";//startup 41
				radioButton63.Text = "-startup=63";//startup 63
*/
			#endregion					
			
		}

		private void enableOptions()
		{


		}

		private void radioButton0_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton0.Checked)
			{
				string startup = "-startup=0 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton0.Checked == false)
			{
				string startup = "-startup=0 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				string startup = "-startup=1 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton1.Checked == false)
			{
				string startup = "-startup=1 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				string startup = "-startup=2 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton2.Checked == false)
			{
				string startup = "-startup=2 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton3.Checked)
			{
				string startup = "-startup=3 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton3.Checked == false)
			{
				string startup = "-startup=3 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton4.Checked)
			{
				string startup = "-startup=4 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton4.Checked == false)
			{
				string startup = "-startup=4 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton5.Checked)
			{
				string startup = "-startup=5 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton5.Checked == false)
			{
				string startup = "-startup=5 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton6.Checked)
			{
				string startup = "-startup=6 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton6.Checked == false)
			{
				string startup = "-startup=6 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton7_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton7.Checked)
			{
				string startup = "-startup=7 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton7.Checked == false)
			{
				string startup = "-startup=7 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton8_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton8.Checked)
			{
				string startup = "-startup=8 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton8.Checked == false)
			{
				string startup = "-startup=8 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton9.Checked)
			{
				string startup = "-startup=9 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton9.Checked == false)
			{
				string startup = "-startup=9 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton10_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton10.Checked)
			{
				string startup = "-startup=10 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton10.Checked == false)
			{
				string startup = "-startup=10 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton11_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton11.Checked)
			{
				string startup = "-startup=11 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton11.Checked == false)
			{
				string startup = "-startup=11 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton12_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton12.Checked)
			{
				string startup = "-startup=12 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton12.Checked == false)
			{
				string startup = "-startup=12 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton13_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton13.Checked)
			{
				string startup = "-startup=13 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton13.Checked == false)
			{
				string startup = "-startup=13 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton14_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton14.Checked)
			{
				string startup = "-startup=14 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton14.Checked == false)
			{
				string startup = "-startup=14 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton15_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton15.Checked)
			{
				string startup = "-startup=15 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton15.Checked == false)
			{
				string startup = "-startup=15 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton16_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton16.Checked)
			{
				string startup = "-startup=16 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton16.Checked == false)
			{
				string startup = "-startup=16 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton17_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton17.Checked)
			{
				string startup = "-startup=17 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton17.Checked == false)
			{
				string startup = "-startup=17 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton18_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton18.Checked)
			{
				string startup = "-startup=18 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton18.Checked == false)
			{
				string startup = "-startup=18 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton19_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton19.Checked)
			{
				string startup = "-startup=19 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton19.Checked == false)
			{
				string startup = "-startup=19 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton20_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton20.Checked)
			{
				string startup = "-startup=20 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton20.Checked == false)
			{
				string startup = "-startup=20 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton21_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton21.Checked)
			{
				string startup = "-startup=21 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton21.Checked == false)
			{
				string startup = "-startup=21 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton22_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton22.Checked)
			{
				string startup = "-startup=22 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton22.Checked == false)
			{
				string startup = "-startup=22 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton23_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton23.Checked)
			{
				string startup = "-startup=23 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton23.Checked == false)
			{
				string startup = "-startup=23 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton24_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton24.Checked)
			{
				string startup = "-startup=24 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton24.Checked == false)
			{
				string startup = "-startup=24 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton25_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton25.Checked)
			{
				string startup = "-startup=25 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton25.Checked == false)
			{
				string startup = "-startup=25 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton26_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton26.Checked)
			{
				string startup = "-startup=26 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton26.Checked == false)
			{
				string startup = "-startup=26 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton27_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton27.Checked)
			{
				string startup = "-startup=27 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton27.Checked == false)
			{
				string startup = "-startup=27 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton28_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton28.Checked)
			{
				string startup = "-startup=28 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton28.Checked == false)
			{
				string startup = "-startup=28 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton29_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton29.Checked)
			{
				string startup = "-startup=29 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton21.Checked == false)
			{
				string startup = "-startup=29 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton30_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton30.Checked)
			{
				string startup = "-startup=30 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton30.Checked == false)
			{
				string startup = "-startup=30 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton31_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton31.Checked)
			{
				string startup = "-startup=31 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton31.Checked == false)
			{
				string startup = "-startup=31 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton32_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton32.Checked)
			{
				string startup = "-startup=32 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton32.Checked == false)
			{
				string startup = "-startup=32 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton33_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton33.Checked)
			{
				string startup = "-startup=33 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton33.Checked == false)
			{
				string startup = "-startup=33 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton34_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton34.Checked)
			{
				string startup = "-startup=34 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton34.Checked == false)
			{
				string startup = "-startup=34 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton35_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton35.Checked)
			{
				string startup = "-startup=35 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton35.Checked == false)
			{
				string startup = "-startup=35 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton36_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton36.Checked)
			{
				string startup = "-startup=36 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton36.Checked == false)
			{
				string startup = "-startup=36 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton37_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton37.Checked)
			{
				string startup = "-startup=37 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton37.Checked == false)
			{
				string startup = "-startup=37 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton38_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton38.Checked)
			{
				string startup = "-startup=38 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton38.Checked == false)
			{
				string startup = "-startup=38 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton39_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton39.Checked)
			{
				string startup = "-startup=39 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton39.Checked == false)
			{
				string startup = "-startup=39 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton40_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton40.Checked)
			{
				string startup = "-startup=40 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton40.Checked == false)
			{
				string startup = "-startup=40 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton41_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton41.Checked)
			{
				string startup = "-startup=41 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton41.Checked == false)
			{
				string startup = "-startup=41 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButton63_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton63.Checked)
			{
				string startup = "-startup=63 ";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButton63.Checked == false)
			{
				string startup = "-startup=63 ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonNone.Checked)
			{
				string startup = "";
				ListOptions.Add(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
			else if (radioButtonNone.Checked == false)
			{
				string startup = "";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;
			}
		}

		private void enterYourOwn_CheckedChanged(object sender, EventArgs e)
		{
			if (enterYourOwn.Checked)
			{
				textBox2.Enabled = true;
				enter_your_own_startup.Enabled = true;
			}
			else if (enterYourOwn.Checked == false)
			{
				string startup = "-startup=" + startUP_Value.ToString() + " ";
				ListOptions.Remove(startup);
				string startupOption = string.Join("", ListOptions.ToArray());
				textBox1.Text = startupOption;

				textBox2.Enabled = false;
				remove_your_own_startup.Enabled = false;
				enter_your_own_startup.Enabled = false;


			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			int temp;

			if (!int.TryParse(textBox2.Text, out temp))//check to see if letters
			{
				if (textBox2.TextLength > 0)
				{
					textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);

					textBox2.Focus();
					textBox2.SelectionStart = textBox2.Text.Length;
				}
			}
			//if (int.Parse(textBox3.Text, out number))
			if (int.TryParse(textBox2.Text, out temp))
			{
				if (temp > 99)
				{
					//too high
					MessageBox.Show("too high");
					temp = 65535;
					//textBox2.Text = "99";

					textBox2.Focus();
					textBox2.SelectionStart = textBox2.Text.Length;
				}
				if (temp < 0)
				{
					//too low
					MessageBox.Show("too low");
					temp = 0;
					//textBox2.Text = "0";

					//textBox2.Focus();
					//textBox2.SelectionStart = textBox2.Text.Length;
				}
				else
				{
					// just right
					temp = int.Parse(textBox2.Text);
					//textBox2.Text = textBox3.Text;

					startUP_Value = temp;
				}
			}
		}

		private void enter_your_own_startup_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("startup=" + startUP_Value.ToString());
			textBox2.Enabled = false;
			enter_your_own_startup.Enabled = false;
			remove_your_own_startup.Enabled = true;

			string startup = "-startup=" + startUP_Value.ToString() + " ";
			ListOptions.Add(startup);
			string startupOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = startupOption;
		}

		private void remove_your_own_startup_Click(object sender, EventArgs e)
		{
			textBox2.Enabled = true;
			enter_your_own_startup.Enabled = true;
			remove_your_own_startup.Enabled = false;

			string startup = "-startup=" + startUP_Value.ToString() + " ";
			ListOptions.Remove(startup);
			string startupOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = startupOption;

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
				zccvariables.terminalOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			else
			{
				Preprocessor frm = new Preprocessor(textBox1.Text);
				frm.Show();
				this.Close();
				//Preprocessor
			}
		}




	}
}
