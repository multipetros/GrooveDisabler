﻿/* GrooveDisable v1.0 - Program Entry Point
 * 
 * Copyright (c) 2015, Petros Kyladitis <http://www.multipetros.gr/> 
 * This is free software distributed under the GNU GPL 3, for license details see at 'license.txt' 
 * file, distributed with this program, or see at <http://www.gnu.org/licenses/>
 * */
 
using System;
using System.Windows.Forms;

namespace GrooveDisabler{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
