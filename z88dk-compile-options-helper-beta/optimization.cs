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
	public partial class optimization : Form
	{
		public List<string> ListOptions = new List<string>();

		public optimization()
		{
			InitializeComponent();
		}

		//globals
		string O_0_optimizer_options = "";
		string SO_0_optimizer_options = "";

		int max_alloc = 3000;

		public optimization(string strTextBox)
		{
			InitializeComponent();
			textBox1.Text = strTextBox;
			string platform = strTextBox;
			ListOptions.Add(platform);

			if (zccvariables.sdcc_compiler == true)
			{
				//MessageBox.Show("SDCC");
				label1.Text = "SDCC";

				enable_O_n.Enabled = true;
				enable_SO_n.Enabled = true;
				//Enable_max_alloc_per_node.Enabled = true;
				Enable_OPT_Code_Size.Enabled = true;
				trackBar1.Enabled = true;

				max_alloc_textbox.Enabled = true;
				max_alloc_textbox.Text = max_alloc.ToString();

				enter_max_alloc.Enabled = true;
				remove_max_alloc.Enabled = false;

				enable_O_n.Checked = false;
				enable_SO_n.Checked = false;
				//Enable_max_alloc_per_node.Checked = false;
				Enable_OPT_Code_Size.Checked = false;

			}


			if (zccvariables.sdcc_compiler == false)
			{
				//MessageBox.Show("SCCZ80");
				label1.Text = "SCCZ80";

				enable_O_n.Enabled = true;
				enable_SO_n.Enabled = false;
				//Enable_max_alloc_per_node.Enabled = false;
				Enable_OPT_Code_Size.Enabled = false;

				enable_O_n.Checked = false;
				enable_SO_n.Checked = false;
				//Enable_max_alloc_per_node.Checked = false;
				Enable_OPT_Code_Size.Checked = false;
			}

			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(0, 0);

			enableOptions();
		}

		private void enableOptions()
		{
			if (zccvariables.sdcc_compiler == true)
			{
				panel1.Enabled = true;
				panel2.Enabled = true;
				panel3.Enabled = true;
				panel4.Enabled = true;
				panel5.Enabled = true;
			}
			if (zccvariables.sdcc_compiler == false)
			{
				panel1.Enabled = true;
				panel2.Enabled = false;
				panel3.Enabled = false;
				panel4.Enabled = false;
				panel5.Enabled = false;
			}
		}

		private void enable_O_n_CheckedChanged(object sender, EventArgs e)
		{
			if (enable_O_n.Checked == true)
			{
				O_0_optimizer.Enabled = true;
				O_1_optimizer.Enabled = true;
				O_2_optimizer.Enabled = true;
				O_3_optimizer.Enabled = true;

				O_0_optimizer.Checked = false;
				O_1_optimizer.Checked = false;
				O_2_optimizer.Checked = false;
				O_3_optimizer.Checked = false;

				

				SO_0_sdcc_optimizer.Enabled = false;
				SO_1_sdcc_optimizer.Enabled = false;
				SO_2_sdcc_optimizer.Enabled = false;
				SO_3_sdcc_optimizer.Enabled = false;

				enable_SO_n.Checked = false;

				SO_0_sdcc_optimizer.Checked = false;
				SO_1_sdcc_optimizer.Checked = false;
				SO_2_sdcc_optimizer.Checked = false;
				SO_3_sdcc_optimizer.Checked = false;

			}
			if (enable_O_n.Checked == false)
			{
				O_0_optimizer.Enabled = false;
				O_1_optimizer.Enabled = false;
				O_2_optimizer.Enabled = false;
				O_3_optimizer.Enabled = false;

				O_0_optimizer.Checked = false;
				O_1_optimizer.Checked = false;
				O_2_optimizer.Checked = false;
				O_3_optimizer.Checked = false;

				//turn off optimizer
				SO_0_optimizer_options = "";
				ListOptions.Remove(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}


		private void O_0_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (O_0_optimizer.Checked)
			{
				O_0_optimizer_options = "-O0 ";
				ListOptions.Add(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (O_0_optimizer.Checked == false)
			{
				O_0_optimizer_options = "-O0 ";
				ListOptions.Remove(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void O_1_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (O_1_optimizer.Checked)
			{
				O_0_optimizer_options = "-O1 ";
				ListOptions.Add(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (O_1_optimizer.Checked == false)
			{
				O_0_optimizer_options = "-O1 ";
				ListOptions.Remove(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void O_2_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (O_2_optimizer.Checked)
			{
				O_0_optimizer_options = "-O2 ";
				ListOptions.Add(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (O_2_optimizer.Checked == false)
			{
				O_0_optimizer_options = "-O2 ";
				ListOptions.Remove(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void O_3_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (O_3_optimizer.Checked)
			{
				O_0_optimizer_options = "-O3 ";
				ListOptions.Add(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (O_3_optimizer.Checked == false)
			{
				O_0_optimizer_options = "-O3 ";
				ListOptions.Remove(O_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}


		private void enable_SO_n_CheckedChanged(object sender, EventArgs e)
		{
			if (enable_SO_n.Checked == true)
			{
				SO_0_sdcc_optimizer.Enabled = true;
				SO_1_sdcc_optimizer.Enabled = true;
				SO_2_sdcc_optimizer.Enabled = true;
				SO_3_sdcc_optimizer.Enabled = true;

				SO_0_sdcc_optimizer.Checked = false;
				SO_1_sdcc_optimizer.Checked = false;
				SO_2_sdcc_optimizer.Checked = false;
				SO_3_sdcc_optimizer.Checked = false;


				O_0_optimizer.Enabled = false;
				O_1_optimizer.Enabled = false;
				O_2_optimizer.Enabled = false;
				O_3_optimizer.Enabled = false;

				enable_O_n.Checked = false;
				O_0_optimizer.Checked = false;
				O_1_optimizer.Checked = false;
				O_2_optimizer.Checked = false;
				O_3_optimizer.Checked = false;

			}
			if (enable_SO_n.Checked == false)
			{
				SO_0_sdcc_optimizer.Enabled = false;
				SO_1_sdcc_optimizer.Enabled = false;
				SO_2_sdcc_optimizer.Enabled = false;
				SO_3_sdcc_optimizer.Enabled = false;

				SO_0_sdcc_optimizer.Checked = false;
				SO_1_sdcc_optimizer.Checked = false;
				SO_2_sdcc_optimizer.Checked = false;
				SO_3_sdcc_optimizer.Checked = false;
			}
		}


		private void SO_0_sdcc_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (SO_0_sdcc_optimizer.Checked)
			{
				SO_0_optimizer_options = "-SO0 ";
				ListOptions.Add(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (SO_0_sdcc_optimizer.Checked == false)
			{
				SO_0_optimizer_options = "-SO0 ";
				ListOptions.Remove(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void SO_1_sdcc_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (SO_1_sdcc_optimizer.Checked)
			{
				SO_0_optimizer_options = "-SO1 ";
				ListOptions.Add(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (SO_1_sdcc_optimizer.Checked == false)
			{
				SO_0_optimizer_options = "-SO1 ";
				ListOptions.Remove(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void SO_2_sdcc_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (SO_2_sdcc_optimizer.Checked)
			{
				SO_0_optimizer_options = "-SO2 ";
				ListOptions.Add(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (SO_2_sdcc_optimizer.Checked == false)
			{
				SO_0_optimizer_options = "-SO2 ";
				ListOptions.Remove(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void SO_3_sdcc_optimizer_CheckedChanged(object sender, EventArgs e)
		{
			if (SO_3_sdcc_optimizer.Checked)
			{
				SO_0_optimizer_options = "-SO3 ";
				ListOptions.Add(SO_0_optimizer_options);
				//MessageBox.Show("Radio Button 2 off");
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
			else if (SO_3_sdcc_optimizer.Checked == false)
			{
				SO_0_optimizer_options = "-SO3 ";
				ListOptions.Remove(SO_0_optimizer_options);
				string floatpoint = string.Join("", ListOptions.ToArray());
				textBox1.Text = floatpoint;
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			//textBox7.Text = trackBar1.Value.ToString();
			//textBox8.Text = trackBar1.Value.ToString();

			//max_alloc = trackBar1.Value;
			//max_alloc_textbox

			var round = ((int)(trackBar1.Value / 1000) * 1000);
			trackBar1.Value = round;

			if (round == 3000)
			{
				trackBar1.Value = 3000;
				max_alloc_textbox.Text = trackBar1.Value.ToString();
				max_alloc = trackBar1.Value;
				max_alloc_label.Text = trackBar1.Value.ToString();
				System.Threading.Thread.Sleep(1000);
			}
			if (round == 10000)
			{
				trackBar1.Value = 10000;
				max_alloc_textbox.Text = trackBar1.Value.ToString();
				max_alloc = trackBar1.Value;
				max_alloc_label.Text = trackBar1.Value.ToString();
				System.Threading.Thread.Sleep(1000);
			}
			if (round == 30000)
			{
				trackBar1.Value = 30000;
				max_alloc_textbox.Text = trackBar1.Value.ToString();
				max_alloc = trackBar1.Value;
				max_alloc_label.Text = trackBar1.Value.ToString();
				System.Threading.Thread.Sleep(1000);
			}
			if (round == 200000)
			{
				trackBar1.Value = 200000;
				max_alloc_textbox.Text = trackBar1.Value.ToString();
				max_alloc = trackBar1.Value;
				max_alloc_label.Text = trackBar1.Value.ToString();
				System.Threading.Thread.Sleep(1000);
			}
			if (round == 500000)
			{
				trackBar1.Value = 500000;
				max_alloc_textbox.Text = trackBar1.Value.ToString();
				max_alloc = trackBar1.Value;
				max_alloc_label.Text = trackBar1.Value.ToString();
				System.Threading.Thread.Sleep(1000);
			}


			max_alloc_textbox.Text = trackBar1.Value.ToString();
			max_alloc = trackBar1.Value;
			max_alloc_label.Text = trackBar1.Value.ToString();
		}



		private void max_alloc_textbox_TextChanged(object sender, EventArgs e)
		{
			int temp;

			if (!int.TryParse(max_alloc_textbox.Text, out temp))//check to see if letters
			{
				if (max_alloc_textbox.TextLength > 0)
				{
					max_alloc_textbox.Text = max_alloc_textbox.Text.Substring(0, max_alloc_textbox.Text.Length - 1);

					max_alloc_textbox.Focus();
					max_alloc_textbox.SelectionStart = max_alloc_textbox.Text.Length;
				}
			}


			if (int.TryParse(max_alloc_textbox.Text, out temp))
			{
				if (temp > 1000000)
				{
					//too high
					MessageBox.Show("The max_alloc_textbox setting is too high");
					temp = 1000000;
					max_alloc_textbox.Text = "1000000";

					max_alloc_textbox.Focus();
					max_alloc_textbox.SelectionStart = max_alloc_textbox.Text.Length;
				}
				if (temp < 1000)
				{
					//too low
					MessageBox.Show("The max_alloc_textbox setting is too low");
					temp = 1000;
					max_alloc_textbox.Text = "1000";

					max_alloc_textbox.Focus();
					max_alloc_textbox.SelectionStart = max_alloc_textbox.Text.Length;
				}


				else
				{
					// just right
					temp = int.Parse(max_alloc_textbox.Text);
					trackBar1.Value = int.Parse(temp.ToString());

					max_alloc = temp;
				}
			}

		}



		private void enter_max_alloc_Click(object sender, EventArgs e)
		{

			var round = ((int.Parse(max_alloc_textbox.Text) / 1000) * 1000);
			max_alloc_textbox.Text = round.ToString();

			max_alloc = round;


			//--max-allocs-per-nodeNNNN
			string max = "--max-allocs-per-node";
			ListOptions.Add(max + max_alloc + " ");
			string max_allocOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = max_allocOption;

			enter_max_alloc.Enabled = false;
			remove_max_alloc.Enabled = true;
			max_alloc_textbox.Enabled = false;
			trackBar1.Enabled = false;

			quick_select1.Enabled = false;
			quick_select2.Enabled = false;
			quick_select3.Enabled = false;
			quick_select4.Enabled = false;
			quick_select5.Enabled = false;
			quick_select6.Enabled = false;

		}

		private void remove_max_alloc_Click(object sender, EventArgs e)
		{
			//--max-allocs-per-nodeNNNN
			string max = "--max-allocs-per-node";
			ListOptions.Remove(max + max_alloc + " ");
			string max_allocOption = string.Join("", ListOptions.ToArray());
			textBox1.Text = max_allocOption;

			enter_max_alloc.Enabled = true;
			remove_max_alloc.Enabled = false;
			max_alloc_textbox.Enabled = true;
			trackBar1.Enabled = true;

			quick_select1.Enabled = true;
			quick_select2.Enabled = true;
			quick_select3.Enabled = true;
			quick_select4.Enabled = true;
			quick_select5.Enabled = true;
			quick_select6.Enabled = true;
		}

		private void Enable_OPT_Code_Size_CheckedChanged(object sender, EventArgs e)
		{
			if (Enable_OPT_Code_Size.Checked == true)
			{
				string OPT_Code_Size = "--opt-code-size ";
				ListOptions.Add(OPT_Code_Size);
				string OPTSize = string.Join("", ListOptions.ToArray());
				textBox1.Text = OPTSize;
			}
			if (Enable_OPT_Code_Size.Checked == false)
			{
				string OPT_Code_Size = "--opt-code-size ";
				ListOptions.Remove(OPT_Code_Size);
				string OPTSize = string.Join("", ListOptions.ToArray());
				textBox1.Text = OPTSize;
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
				zccvariables.optimizationOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
			else
			{
				terminal_driver frm = new terminal_driver(textBox1.Text);
				frm.Show();
				this.Close();
			}
		}

		private void quick_select1_Click(object sender, EventArgs e)
		{
			trackBar1.Value = 1000;
			max_alloc_textbox.Text = "1000";
		}

		private void quick_select2_Click(object sender, EventArgs e)
		{
			trackBar1.Value = 3000;
			max_alloc_textbox.Text = "3000";
		}

		private void quick_select3_Click(object sender, EventArgs e)
		{
			trackBar1.Value = 10000;
			max_alloc_textbox.Text = "10000";
		}

		private void quick_select4_Click(object sender, EventArgs e)
		{
			trackBar1.Value = 30000;
			max_alloc_textbox.Text = "30000";
		}


		private void quick_select5_Click(object sender, EventArgs e)
		{
			trackBar1.Value = 200000;
			max_alloc_textbox.Text = "200000";
		}

		private void quick_select6_Click(object sender, EventArgs e)
		{
			trackBar1.Value = 500000;
			max_alloc_textbox.Text = "500000";
		}





	}
}
