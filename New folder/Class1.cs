using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z88dk_compile_options_helper_beta
{
	class Class1
	{

	}


	class zccvariables
	{

		public static string machine = "";
		public static byte mainMenuChoice = 0;

		public static bool restartForm1 = true;

		//public static string machine = "";
		public static bool classicCompiler = false;

		public static bool sdcc_compiler = true;


		//globals for list wizard to check if options are choosen
		public static bool choosenTarget = false;
		public static bool compilerChoice = false;
		public static bool verboseOptions = false;
		public static bool cleanupOptions = false;
		public static bool floatingPointOptions = false;
		public static bool zorgOptions = false;
		public static bool optimizationOptions = false;
		public static bool terminalOptions = false;
		public static bool mediaOptions = false;
		public static bool preprocessorOptions = false;
		public static bool miscellaneousOptions = false;
		public static bool memoryOptions = false;


		//globals for list groups

		string object_String = "";

		// cleaning

		public static string cleanup_temp_files = "-cleanup ";
		public static string no_cleanup_temp_files = "-no-cleanup ";




		public bool machine_type_for_floating_point(bool type)
		{
			if (machine == "zx")
			{
				return true;
			}

			else
			{
				return false;
			}
			//return true;
		}

		public bool interface_one_zx(bool type)
		{
			if (machine == "zx")
			{
				return true;
			}

			else
			{
				return false;
			}
			//return true;
		}









	}












}
