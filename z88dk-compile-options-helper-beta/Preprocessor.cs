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
	public partial class Preprocessor : Form
	{
		public List<string> ListOptions = new List<string>();

		string directoryName = "";

		public Preprocessor()
		{
			InitializeComponent();
		}

		public Preprocessor(string strTextBox)
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


		private void preprocessor_add_CheckedChanged(object sender, EventArgs e)
		{
			if (preprocessor_add.Checked == true)
			{
				// turn on options
				textBox2.Enabled = true;
				preprocessor_enter.Enabled = true;
				preprocessor_remove.Enabled = false;

			}
			if (preprocessor_add.Checked == false)
			{
				textBox2.Text = "";
				preprocessor_enter.Enabled = false;
				preprocessor_remove.Enabled = false;
				textBox2.Enabled = false;
			}
		}

		private void preprocessor_enter_Click(object sender, EventArgs e)
		{
			preprocessor_remove.Enabled = true;
			textBox2.Enabled = false;
			preprocessor_enter.Enabled = false;
			preprocessor_add.Enabled = false;

			string preprocessorAdd = "-Cp-" + textBox2.Text + " ";
			ListOptions.Add(preprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void preprocessor_remove_Click(object sender, EventArgs e)
		{
			preprocessor_remove.Enabled = false;
			textBox2.Enabled = true;
			preprocessor_enter.Enabled = true;
			preprocessor_add.Enabled = true;

			string preprocessorAdd = "-Cp-" + textBox2.Text + " ";
			ListOptions.Remove(preprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void assembler_add_CheckedChanged(object sender, EventArgs e)
		{
			if (assembler_add.Checked == true)
			{
				// turn on options
				textBox3.Enabled = true;
				assembler_enter.Enabled = true;
				assembler_remove.Enabled = false;
				
			}
			if (assembler_add.Checked == false)
			{
				textBox3.Text = "";
				assembler_enter.Enabled = false;
				assembler_remove.Enabled = false;
				textBox3.Enabled = false;
			}
		}

		private void assembler_enter_Click(object sender, EventArgs e)
		{
			assembler_remove.Enabled = true;
			textBox3.Enabled = false;
			assembler_enter.Enabled = false;
			assembler_add.Enabled = false;
			
			string preprocessorAdd = "-Ca-" + textBox3.Text + " ";
			ListOptions.Add(preprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void assembler_remove_Click(object sender, EventArgs e)
		{
			assembler_remove.Enabled = false;
			textBox3.Enabled = true;
			assembler_enter.Enabled = true;
			assembler_add.Enabled = true;

			string preprocessorAdd = "-Ca-" + textBox3.Text + " ";
			ListOptions.Remove(preprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void linker_add_CheckedChanged(object sender, EventArgs e)
		{
			if (linker_add.Checked == true)
			{
				// turn on options
				textBox4.Enabled = true;
				linker_enter.Enabled = true;
				linker_remove.Enabled = false;

			}
			if (linker_add.Checked == false)
			{
				textBox4.Text = "";
				linker_enter.Enabled = false;
				linker_remove.Enabled = false;
				textBox4.Enabled = false;
			}
		}

		private void linker_enter_Click(object sender, EventArgs e)
		{
			linker_remove.Enabled = true;
			textBox4.Enabled = false;
			linker_enter.Enabled = false;
			linker_add.Enabled = false;

			string linkerAdd = "-Cl-" + textBox4.Text + " ";
			ListOptions.Add(linkerAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void linker_remove_Click(object sender, EventArgs e)
		{
			linker_remove.Enabled = false;
			textBox4.Enabled = true;
			linker_enter.Enabled = true;
			linker_add.Enabled = true;

			string linkerAdd = "-Cl-" + textBox4.Text + " ";
			ListOptions.Remove(linkerAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void appmake_add_CheckedChanged(object sender, EventArgs e)
		{
			if (appmake_add.Checked == true)
			{
				// turn on options
				textBox5.Enabled = true;
				appmake_enter.Enabled = true;
				appmake_remove.Enabled = false;

			}
			if (appmake_add.Checked == false)
			{
				textBox5.Text = "";
				appmake_enter.Enabled = false;
				appmake_remove.Enabled = false;
				textBox5.Enabled = false;
			}
		}

		private void appmake_enter_Click(object sender, EventArgs e)
		{
			appmake_remove.Enabled = true;
			textBox5.Enabled = false;
			appmake_enter.Enabled = false;
			appmake_add.Enabled = false;

			string appmakeAdd = "-Cz-" + textBox5.Text + " ";
			ListOptions.Add(appmakeAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void appmake_remove_Click(object sender, EventArgs e)
		{
			appmake_remove.Enabled = false;
			textBox5.Enabled = true;
			appmake_enter.Enabled = true;
			appmake_add.Enabled = true;

			string appmakeAdd = "-Cz-" + textBox5.Text + " ";
			ListOptions.Remove(appmakeAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void sccz80_add_CheckedChanged(object sender, EventArgs e)
		{
			if (sccz80_add.Checked == true)
			{
				// turn on options
				textBox6.Enabled = true;
				sccz80_enter.Enabled = true;
				sccz80_remove.Enabled = false;
				
			}
			if (sccz80_add.Checked == false)
			{
				textBox6.Text = "";
				sccz80_enter.Enabled = false;
				sccz80_remove.Enabled = false;
				textBox6.Enabled = false;
			}
		}

		private void sccz80_enter_Click(object sender, EventArgs e)
		{
			sccz80_remove.Enabled = true;
			textBox6.Enabled = false;
			sccz80_enter.Enabled = false;
			sccz80_add.Enabled = false;
			
			string sccz80Add = "-Cc-" + textBox6.Text + " ";
			ListOptions.Add(sccz80Add);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void sccz80_remove_Click(object sender, EventArgs e)
		{
			sccz80_remove.Enabled = false;
			textBox6.Enabled = true;
			sccz80_enter.Enabled = true;
			sccz80_add.Enabled = true;

			string sccz80Add = "-Cc-" + textBox6.Text + " ";
			ListOptions.Remove(sccz80Add);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void scdd_add_CheckedChanged(object sender, EventArgs e)
		{
			if (scdd_add.Checked == true)
			{
				// turn on options
				textBox7.Enabled = true;
				scdd_enter.Enabled = true;
				scdd_remove.Enabled = false;
				
			}
			if (scdd_add.Checked == false)
			{
				textBox7.Text = "";
				scdd_enter.Enabled = false;
				scdd_remove.Enabled = false;
				textBox7.Enabled = false;
			}
		}

		private void scdd_enter_Click(object sender, EventArgs e)
		{
			scdd_remove.Enabled = true;
			textBox7.Enabled = false;
			scdd_enter.Enabled = false;
			scdd_add.Enabled = false;
			
			string scddAdd = "-Cs-" + textBox7.Text + " ";
			ListOptions.Add(scddAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void scdd_remove_Click(object sender, EventArgs e)
		{
			scdd_remove.Enabled = false;
			textBox7.Enabled = true;
			scdd_enter.Enabled = true;
			scdd_add.Enabled = true;

			string scddAdd = "-Cs-" + textBox7.Text + " ";
			ListOptions.Remove(scddAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void define_preprocessor_option_CheckedChanged(object sender, EventArgs e)
		{
			if (define_preprocessor_option.Checked == true)
			{
				// turn on options
				textBox8.Enabled = true;
				define_option_enter.Enabled = true;
				define_option_remove.Enabled = false;

			}
			if (define_preprocessor_option.Checked == false)
			{
				textBox8.Text = "";
				define_option_enter.Enabled = false;
				define_option_remove.Enabled = false;
				textBox8.Enabled = false;
			}
		}

		private void define_option_enter_Click(object sender, EventArgs e)
		{
			define_option_remove.Enabled = true;
			textBox8.Enabled = false;
			define_option_enter.Enabled = false;
			define_preprocessor_option.Enabled = false;

			string preprocessorAdd = "-D " + textBox8.Text + " ";
			ListOptions.Add(preprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void define_option_remove_Click(object sender, EventArgs e)
		{
			define_option_remove.Enabled = false;
			textBox8.Enabled = true;
			define_option_enter.Enabled = true;
			define_preprocessor_option.Enabled = true;

			string preprocessorAdd = "-D " + textBox8.Text + " ";
			ListOptions.Remove(preprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void undefine_preprocessor_option_CheckedChanged(object sender, EventArgs e)
		{
			if (undefine_preprocessor_option.Checked == true)
			{
				// turn on options
				textBox9.Enabled = true;
				undefine_option_enter.Enabled = true;
				undefine_option_remove.Enabled = false;

			}
			if (undefine_preprocessor_option.Checked == false)
			{
				textBox9.Text = "";
				undefine_option_enter.Enabled = false;
				undefine_option_remove.Enabled = false;
				textBox9.Enabled = false;
			}
		}

		private void undefine_option_enter_Click(object sender, EventArgs e)
		{
			undefine_option_remove.Enabled = true;
			textBox9.Enabled = false;
			undefine_option_enter.Enabled = false;
			undefine_preprocessor_option.Enabled = false;

			string unpreprocessorAdd = "-U " + textBox9.Text + " ";
			ListOptions.Add(unpreprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void undefine_option_remove_Click(object sender, EventArgs e)
		{
			undefine_option_remove.Enabled = false;
			textBox9.Enabled = true;
			undefine_option_enter.Enabled = true;
			undefine_preprocessor_option.Enabled = true;

			string unpreprocessorAdd = "-U " + textBox9.Text + " ";
			ListOptions.Remove(unpreprocessorAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void include_preprocessor_directory_CheckedChanged(object sender, EventArgs e)
		{
			if (include_preprocessor_directory.Checked == true)
			{
				browse_directory.Enabled = true;
				
			}
			else if (include_preprocessor_directory.Checked == false)
			{
				include_directory.Enabled = false;
				browse_directory.Enabled = false;
				remove_directory.Enabled = false;
				textBox10.Text = "";
			}
		}

		private void browse_directory_Click(object sender, EventArgs e)
		{
			// Show the dialog and get result.
			FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				directoryName = folderBrowserDialog1.SelectedPath;
			}
			textBox10.Text = directoryName;
			include_directory.Enabled = true;
		}

		private void include_directory_Click(object sender, EventArgs e)
		{
			remove_directory.Enabled = true;
			textBox10.Enabled = false;
			include_directory.Enabled = false;
			include_preprocessor_directory.Enabled = false;
			browse_directory.Enabled = false;

			string includeDirectoryAdd = "-I " + textBox10.Text + " ";
			ListOptions.Add(includeDirectoryAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;
		}

		private void remove_directory_Click(object sender, EventArgs e)
		{
			remove_directory.Enabled = false;
			textBox10.Enabled = true;
			include_directory.Enabled = false;
			include_preprocessor_directory.Enabled = true;
			browse_directory.Enabled = true;
			

			string includeDirectoryAdd = "-I " + textBox10.Text + " ";
			ListOptions.Remove(includeDirectoryAdd);
			string object_String = string.Join("", ListOptions.ToArray());
			textBox1.Text = object_String;

			//textBox10.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			zccvariables.restartForm1 = true;

			Form1 startOver = (Form1)Application.OpenForms["Form1"];
			startOver.Show();

			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			if (zccvariables.mainMenuChoice == 2)
			{
				//optimization frm = new optimization(textBox1.Text);
				//frm.Show();
				//this.Close();
				MessageBox.Show("where to next???");
			}

			if (zccvariables.mainMenuChoice == 3)
			{
				//List_wizard
				zccvariables.preprocessorOptions = true;

				List_wizard frm = new List_wizard(textBox1.Text);
				frm.Show();

				this.Close();
			}
		}
	}
}
