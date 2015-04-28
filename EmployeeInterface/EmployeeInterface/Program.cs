using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInterface
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AppPicker());
		}
	}
}

// Changes to make for app picking to work:

// application.run(new AppPicker());

// AppPicker should call authentication

// Depending on admin status, option to run EmployeeInterface, EmployeeInterface2 (different name?), or AdminInterface