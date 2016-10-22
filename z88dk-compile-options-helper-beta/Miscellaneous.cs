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
	public partial class Miscellaneous : Form
	{
		public List<string> ListOptions = new List<string>();

		string crt_types = "";
		string crt_file = "";
		string asm_types = "";
		string compiling_opts_types = "";
		string object_file_suffix = "";

		public Miscellaneous()
		{
			InitializeComponent();
		}

		public Miscellaneous(string strTextBox)
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

		private void crt_option_CheckedChanged(object sender, EventArgs e)
		{
			if (crt_option.Checked)
			{
				crt_yes.Enabled = true;
				crt_no.Enabled = true;
			}
			else if (crt_option.Checked == false)
			{
				//asm_types
				crt_types = "";
				ListOptions.Add(crt_types);
				string crtString = string.Join("", ListOptions.ToArray());
				textBox1.Text = crtString;

				crt_yes.Enabled = false;
				crt_yes.Checked = false;
				crt_no.Enabled = false;
				crt_no.Checked = false;
				crt_manual_option.Text = "";
			}
		}

		private void crt_yes_CheckedChanged(object sender, EventArgs e)
		{
			

			if (crt_yes.Checked)
			{
				//crt_types = "-crt0 ";
				//ListOptions.Add(crt_types);
				//string crtString = string.Join("", ListOptions.ToArray());
				//textBox1.Text = crtString;
				crt_browsed_option.Enabled = false;
				browse_for_crt.Enabled = true;
				crt_manual_option.Enabled = true;
			}
			else if (crt_yes.Checked == false)
			{
				string crt = "-crt0 " + crt_file + " ";
				ListOptions.Remove(crt);
				string crtString = string.Join("", ListOptions.ToArray());
				textBox1.Text = crtString;

				crt_browsed_option.Text = "";

				crt_browsed_option.Enabled = false;
				browse_for_crt.Enabled = false;
				crt_manual_option.Enabled = false;
				remove_browsed_crt.Enabled = false;
				remove_manual_crt.Enabled = false;
			}
		}


		private void browse_for_crt_Click(object sender, EventArgs e)
		{
			//open file browser
			//crt_file
			// Show the dialog and get result.
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				//MessageBox.Show("holy moley");
				//fileName = openFileDialog1.FileName;
				crt_file = openFileDialog1.SafeFileName;
				crt_browsed_option.Text = crt_file;
				enter_browsed_crt.Enabled = true;
				browse_for_crt.Enabled = false;
			}
		}

		private void enter_browsed_crt_Click(object sender, EventArgs e)
		{
			//enter browsed file to compiling string
			string file = "-crt0 " + crt_file + " ";
			ListOptions.Add(file);

			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;


			crt_browsed_option.Enabled = false;
			enter_browsed_crt.Enabled = false;
			remove_browsed_crt.Enabled = true;
		}

		private void remove_browsed_crt_Click(object sender, EventArgs e)
		{
			//remove browsed file from compiling string
			string crt = "-crt0 " + crt_file + " ";
			ListOptions.Remove(crt);
			string crtString = string.Join("", ListOptions.ToArray());
			textBox1.Text = crtString;

			crt_browsed_option.Text = "";
			browse_for_crt.Enabled = true;
			enter_browsed_crt.Enabled = false;
			remove_browsed_crt.Enabled = false;
		}

		private void crt_manual_option_TextChanged(object sender, EventArgs e)
		{
			//type in file name
			if (crt_manual_option.Text != "")
			{
				enter_manual_crt.Enabled = true;
			}
			else
			{
				enter_manual_crt.Enabled = false;
			}
		}

		private void enter_manual_crt_Click(object sender, EventArgs e)
		{
			//enter in typed file name to compiling string
			//crt_manual_option
			crt_file = crt_manual_option.Text;

			string file = "-crt0 " + crt_file + " ";
			ListOptions.Add(file);

			string create = string.Join("", ListOptions.ToArray());
			textBox1.Text = create;


			crt_manual_option.Enabled = false;
			enter_manual_crt.Enabled = false;
			remove_manual_crt.Enabled = true;
		}

		private void remove_manual_crt_Click(object sender, EventArgs e)
		{
			//remove in typed file name from compiling string
			string crt = "-crt0 " + crt_file + " ";
			ListOptions.Remove(crt);
			string crtString = string.Join("", ListOptions.ToArray());
			textBox1.Text = crtString;

			crt_manual_option.Text = "";
			enter_manual_crt.Enabled = true;
			remove_manual_crt.Enabled = false;
			crt_manual_option.Enabled = true;
			enter_manual_crt.Enabled = false;
		}







		private void crt_no_CheckedChanged(object sender, EventArgs e)
		{
			if (crt_no.Checked)
			{
				enter_manual_crt.Enabled = false;
				crt_manual_option.Text = "";
				crt_manual_option.Enabled = false;
				enter_manual_crt.Enabled = false;
				remove_manual_crt.Enabled = false;
				crt_browsed_option.Text = "";
				crt_browsed_option.Enabled = false;
				browse_for_crt.Enabled = false;
				enter_browsed_crt.Enabled = false;
				remove_browsed_crt.Enabled = false;


				crt_types = "--no-crt ";
				ListOptions.Add(crt_types);
				string crtString = string.Join("", ListOptions.ToArray());
				textBox1.Text = crtString;
			}
			else if (crt_no.Checked == false)
			{
				crt_types = "--no-crt ";
				ListOptions.Remove(crt_types);
				string crtString = string.Join("", ListOptions.ToArray());
				textBox1.Text = crtString;
			}
		}

		private void asm_option_CheckedChanged(object sender, EventArgs e)
		{
			if (asm_option.Checked)
			{
				z80asm_option.Enabled = true;
				mpm_option.Enabled = true;
				asxx_option.Enabled = true;
				vasm_option.Enabled = true;
				binutils_option.Enabled = true;
			}
			else if (asm_option.Checked == false)
			{
				//asm_types
				asm_types = "";
				ListOptions.Add(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;

				z80asm_option.Enabled = false;
				z80asm_option.Checked = false;
				mpm_option.Enabled = false;
				mpm_option.Checked = false;
				asxx_option.Enabled = false;
				asxx_option.Checked = false;
				vasm_option.Enabled = false;
				vasm_option.Checked = false;
				binutils_option.Enabled = false;
				binutils_option.Checked = false;
			}
		}

		private void z80asm_option_CheckedChanged(object sender, EventArgs e)
		{
			//z80asm
			if (z80asm_option.Checked == true)
			{
				asm_types = "-asm z80asm ";
				ListOptions.Add(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
			if (z80asm_option.Checked == false)
			{
				asm_types = "-asm z80asm ";
				ListOptions.Remove(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
		}

		private void mpm_option_CheckedChanged(object sender, EventArgs e)
		{
			//mpm
			if (mpm_option.Checked == true)
			{
				asm_types = "-asm mpm ";
				ListOptions.Add(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
			if (mpm_option.Checked == false)
			{
				asm_types = "-asm mpm ";
				ListOptions.Remove(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}

		}

		private void asxx_option_CheckedChanged(object sender, EventArgs e)
		{
			//asxx
			if (asxx_option.Checked == true)
			{
				asm_types = "-asm asxx ";
				ListOptions.Add(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
			if (asxx_option.Checked == false)
			{
				asm_types = "-asm asxx ";
				ListOptions.Remove(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}


		}

		private void vasm_option_CheckedChanged(object sender, EventArgs e)
		{
			//vasm
			if (vasm_option.Checked == true)
			{
				asm_types = "-asm vasm ";
				ListOptions.Add(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
			if (vasm_option.Checked == false)
			{
				asm_types = "-asm vasm ";
				ListOptions.Remove(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
		}

		private void binutils_option_CheckedChanged(object sender, EventArgs e)
		{
			//binutils
			if (binutils_option.Checked == true)
			{
				asm_types = "-asm binutils ";
				ListOptions.Add(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
			if (binutils_option.Checked == false)
			{
				asm_types = "-asm binutils ";
				ListOptions.Remove(asm_types);
				string asmString = string.Join("", ListOptions.ToArray());
				textBox1.Text = asmString;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}



		private void compiling_opts_c_CheckedChanged(object sender, EventArgs e)
		{
			if (compiling_opts_c.Checked == true)
			{
				compiling_opts_types = "-c ";
				ListOptions.Add(compiling_opts_types);
				string comp_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = comp_String;
			}
			if (compiling_opts_c.Checked == false)
			{
				compiling_opts_types = "-c ";
				ListOptions.Remove(compiling_opts_types);
				string comp_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = comp_String;
			}
		}

		private void compiling_opts_a_CheckedChanged(object sender, EventArgs e)
		{
			if (compiling_opts_a.Checked == true)
			{
				compiling_opts_types = "-a ";
				ListOptions.Add(compiling_opts_types);
				string comp_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = comp_String;
			}
			if (compiling_opts_a.Checked == false)
			{
				compiling_opts_types = "-a ";
				ListOptions.Remove(compiling_opts_types);
				string comp_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = comp_String;
			}
		}

		private void compiling_opts_S_CheckedChanged(object sender, EventArgs e)
		{
			if (compiling_opts_S.Checked == true)
			{
				compiling_opts_types = "-S ";
				ListOptions.Add(compiling_opts_types);
				string comp_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = comp_String;
			}
			if (compiling_opts_S.Checked == false)
			{
				compiling_opts_types = "-S ";
				ListOptions.Remove(compiling_opts_types);
				string comp_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = comp_String;
			}
		}




		private void relocation_option_CheckedChanged(object sender, EventArgs e)
		{
			if (relocation_option.Checked == true)
			{
				string relocate = "--reloc-info ";
				ListOptions.Add(relocate);
				string relocate_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = relocate_String;
			}
			if (relocation_option.Checked == false)
			{
				string relocate = "--reloc-info ";
				ListOptions.Remove(relocate);
				string relocate_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = relocate_String;
			}
		}

		private void output_map_option_CheckedChanged(object sender, EventArgs e)
		{
			if (output_map_option.Checked == true)
			{
				string outputMap = "-m ";
				ListOptions.Add(outputMap);
				string outputmap_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = outputmap_String;
			}
			if (output_map_option.Checked == false)
			{
				string outputMap = "-m ";
				ListOptions.Remove(outputMap);
				string outputmap_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = outputmap_String;
			}
		}

		private void global_defs_option_CheckedChanged(object sender, EventArgs e)
		{
			if (global_defs_option.Checked == true)
			{
				string globalDefs = "-g ";
				ListOptions.Add(globalDefs);
				string globalDefs_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = globalDefs_String;
			}
			if (global_defs_option.Checked == false)
			{
				string globalDefs = "-g ";
				ListOptions.Remove(globalDefs);
				string globalDefs_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = globalDefs_String;
			}
		}

		private void symbol_map_option_CheckedChanged(object sender, EventArgs e)
		{
			if (symbol_map_option.Checked == true)
			{
				string symbolMap = "-s ";
				ListOptions.Add(symbolMap);
				string symbolMap_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = symbolMap_String;
			}
			if (symbol_map_option.Checked == false)
			{
				string symbolMap = "-s ";
				ListOptions.Remove(symbolMap);
				string symbolMap_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = symbolMap_String;
			}
		}

		private void list_file_option_CheckedChanged(object sender, EventArgs e)
		{
			if (list_file_option.Checked == true)
			{
				string listFile = "--list ";
				ListOptions.Add(listFile);
				string listFile_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = listFile_String;
			}
			if (list_file_option.Checked == false)
			{
				string listFile = "--list ";
				ListOptions.Remove(listFile);
				string listFile_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = listFile_String;
			}
		}

		private void object_suffix_option_CheckedChanged(object sender, EventArgs e)
		{
			if (object_suffix_option.Checked == true)
			{
				// turn on options
				textBox2.Enabled = true;
				suffix_enter.Enabled = true;
				suffix_remove.Enabled = false;

			}
			if (object_suffix_option.Checked == false)
			{
				//turn off options , clear fields
				//object_file_suffix
				textBox2.Text = "";
				suffix_remove.Enabled = false;
				suffix_enter.Enabled = false;
				textBox2.Enabled = false;
			}
		}

		private void suffix_enter_Click(object sender, EventArgs e)
		{
			suffix_remove.Enabled = true;
			textBox2.Enabled = false;
			suffix_enter.Enabled = false;
			object_suffix_option.Enabled = false;

			object_file_suffix = "-M" + textBox2.Text + " ";
			ListOptions.Add(object_file_suffix);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void suffix_remove_Click(object sender, EventArgs e)
		{
			suffix_remove.Enabled = false;
			textBox2.Enabled = true;
			suffix_enter.Enabled = true;
			object_suffix_option.Enabled = true;

			object_file_suffix = "-M" + textBox2.Text + " ";
			ListOptions.Remove(object_file_suffix);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void sdcc_disable_builtin_option_CheckedChanged(object sender, EventArgs e)
		{
			if (sdcc_disable_builtin_option.Checked == true)
			{
				string sdccbuiltin = "-D__SDCC_DISABLE_BUILTIN ";
				ListOptions.Add(sdccbuiltin);
				string sdcc = string.Join("", ListOptions.ToArray());
				textBox1.Text = sdcc;
			}
			if (sdcc_disable_builtin_option.Checked == false)
			{
				string sdccbuiltin = "-D__SDCC_DISABLE_BUILTIN ";
				ListOptions.Remove(sdccbuiltin);
				string sdcc = string.Join("", ListOptions.ToArray());
				textBox1.Text = sdcc;
			}
		}

		private void button11_Click(object sender, EventArgs e)
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
				zccvariables.miscellaneousOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
		}

		private void assembler_comments_option_CheckedChanged(object sender, EventArgs e)
		{
			if (assembler_comments_option.Checked == true)
			{
				string assemberComments = "–c-code-in-asm ";
				ListOptions.Add(assemberComments);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
			if (assembler_comments_option.Checked == false)
			{
				string assemberComments = "–c-code-in-asm ";
				ListOptions.Remove(assemberComments);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}

		private void function_verbose_option_CheckedChanged(object sender, EventArgs e)
		{
			//–fverbose-asm
			if (function_verbose_option.Checked == true)
			{
				string functionVerbose = "–fverbose-asm ";
				ListOptions.Add(functionVerbose);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
			if (function_verbose_option.Checked == false)
			{
				string functionVerbose = "–fverbose-asm ";
				ListOptions.Remove(functionVerbose);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}


		private void m4_macro_option_CheckedChanged(object sender, EventArgs e)
		{
			if (m4_macro_option.Checked == true)
			{
				string listfiles = "–m4 ";
				ListOptions.Add(listfiles);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
			if (m4_macro_option.Checked == false)
			{
				string listfiles = "–m4 ";
				ListOptions.Remove(listfiles);
				string object_String = string.Join("", ListOptions.ToArray());
				textBox1.Text = object_String;
			}
		}












	}
}
