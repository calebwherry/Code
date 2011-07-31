//*****************************************
//*****************************************
//**  Caleb Wherry   |   Cameron Druyor  **
//**  ---------------------------------  **
//**        CSCI 3005: Project 2         **
//**            SuperRent!               **
//*****************************************
//*****************************************

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace DocumentView
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
			Application.Run(new SuperRent());
		}
	}
}