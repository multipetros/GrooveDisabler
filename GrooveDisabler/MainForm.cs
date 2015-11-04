/* GrooveDisable v1.0 - Main Form
 * 
 * Copyright (c) 2015, Petros Kyladitis <http://www.multipetros.gr/> 
 * This is free software distributed under the GNU GPL 3, for license details see at 'license.txt' 
 * file, distributed with this program, or see at <http://www.gnu.org/licenses/>
 * */

using System ;
using System.Collections.Generic ;
using System.Drawing ;
using System.Windows.Forms ;
using System.Diagnostics ;
using System.IO ;
using Microsoft.Win32 ;

namespace GrooveDisabler{
	public partial class MainForm : Form{
		//store office product names as keys and installation paths as values
		private Dictionary<string, string> setups ;
		
		public MainForm(){
			InitializeComponent();
			
			//setup UI tool tips
			string SHARED_FOLDER_TIP = "or \"Shared Folder Synchronization\" as called in MS Office 2010" ;
			ToolTip tip = new ToolTip() ;
			tip.SetToolTip(buttonDisableGroove, SHARED_FOLDER_TIP) ;
			tip.SetToolTip(buttonEnableGroove, SHARED_FOLDER_TIP) ;
			tip.SetToolTip(textBoxInstallationPath, "Founded installation path of the selected MS Office setup") ;
			tip.SetToolTip(listBoxOfficeSetup, "Select your MS Office setup to disable/enable the Groove/Shared\nFolder Synchronization from the Context Menu") ;
			disableGrooveToolStripMenuItem.ToolTipText = SHARED_FOLDER_TIP ;
			enableGrooveToolStripMenuItem.ToolTipText = SHARED_FOLDER_TIP ;
			setupRescanToolStripMenuItem.ToolTipText = "Rescan system registry for Office setups changes" ;
			exitToolStripMenuItem.ToolTipText = "Quit this program" ;
			aboutToolStripMenuItem.ToolTipText = "Show info about this program" ;
		}
		
		/// <summary>
		/// Search the registry for MS Office 2007 or 2010 installation paths
		/// </summary>
		/// <returns>A dictionary with 'MS Office 2007' and 'MS Office 2010' keys and their installation paths as values.
		/// If an installation not found, its value is null.</returns>
		private Dictionary<string, string> FindOfficeSetup(){
			//Office dictionary key names
			string MSO10_NAME = "MS Office 2010" ;
			string MSO07_NAME = "MS Office 2007" ;
			// Office 2010 & 2007 registry keys on same system architectures
			string MSO10_KEY = "Software\\Microsoft\\Office\\14.0\\Common\\InstallRoot" ;
			string MSO07_KEY = "Software\\Microsoft\\Office\\12.0\\Common\\InstallRoot" ;
			// x86 Office 2010 & 2007 registry keys on x64 system
			string MSO10_WOW64_KEY = "Software\\Wow6432Node\\Microsoft\\Office\\14.0\\Common\\InstallRoot" ;
			string MSO07_WOW64_KEY = "Software\\Wow6432Node\\Microsoft\\Office\\12.0\\Common\\InstallRoot" ;
			
			//create 2 cells dictionary & initialize Office 2007 & 2010 keys with null values
			Dictionary<string, string> setup = new Dictionary<string, string>(2) ;
			setup[MSO10_NAME] = null ;
			setup[MSO07_NAME] = null ;
			
			//search for Office 2010 setup in normal node & if not found at WOW64 node
			RegistryKey key = Registry.LocalMachine.OpenSubKey(MSO10_KEY, false) ;
			if(key != null){
				setup[MSO10_NAME] = (string)key.GetValue("Path") ;
			}else{
				key = Registry.LocalMachine.OpenSubKey(MSO10_WOW64_KEY, false) ;
				if(key != null){
					setup[MSO10_NAME] = (string)key.GetValue("Path") ;
				}
			}
			
			//search for Office 2007 setup in normal node & if not found at WOW64 node
			key = Registry.LocalMachine.OpenSubKey(MSO07_KEY, false) ;
			if(key != null){
				setup[MSO07_NAME] = (string)key.GetValue("Path") ;
			}else{
				 key = Registry.LocalMachine.OpenSubKey(MSO07_WOW64_KEY, false) ;
				 if(key != null){
				 	setup[MSO07_NAME] = (string)key.GetValue("Path") ;
				 }
			}
			
			return setup ;
		}
		
		/// <summary>
		/// Search for office setup and initialize the UI elements
		/// </summary>
		private void LoadSetup(){
			listBoxOfficeSetup.Items.Clear() ;
			setups = FindOfficeSetup() ;
			//add dictionary key as listbox items if this key have a value
			foreach(KeyValuePair<string, string> setup in setups){
				if(setup.Value != null){
					listBoxOfficeSetup.Items.Add(setup.Key) ;
				}
			}
			if(listBoxOfficeSetup.Items.Count > 0){ //select the 1st item
				listBoxOfficeSetup.SelectedIndex = listBoxOfficeSetup.Items.Count - 1 ;
			}else{ //hide buttons and make visible the office not found label
				labelOfficeNotFound.Visible = true ;
				buttonDisableGroove.Enabled = false ;
				buttonEnableGroove.Enabled = false ;
				disableGrooveToolStripMenuItem.Enabled = false ;
				enableGrooveToolStripMenuItem.Enabled = false ;
			}
		}
		
		/// <summary>
		/// Used at ContextChange method to determinate the register or unregister job
		/// </summary>
		private enum RegsvGroove{
			Disable,
			Enable
		}
		
		/// <summary>
		/// Unregister or Register the Groove Service, to hide or enable the context menu entry
		/// </summary>
		/// <param name="groove">RegsvGroove.Disable or RegsvGroove.Enable to determinate unregister or register job</param>
		private void ContextChange(RegsvGroove groove){
			string grooveexPath = textBoxInstallationPath.Text + "GROOVEEX.DLL" ;
			
			//if 'GROOVEEX.DLL' not exist inform user and exit
			if(!File.Exists(grooveexPath)){
				MessageBox.Show("GROOVEEX.DLL not found in " + textBoxInstallationPath.Text, "File not found!", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
				return ;
			}
			
			//run 'regsvr32' to register/unregister the groove service
			Process regsvProc = new Process() ;
			regsvProc.StartInfo.FileName = "regsvr32.exe" ;
			if(groove == RegsvGroove.Disable){
				regsvProc.StartInfo.Arguments = "/u \"" + grooveexPath + "\"" ;
			}else{
				regsvProc.StartInfo.Arguments = "\"" + grooveexPath + "\"" ;
			}
			regsvProc.Start() ;
			regsvProc.WaitForExit() ;
		}
		
		void MainFormLoad(object sender, EventArgs e){
			LoadSetup() ; 
		}
		
		void ListBoxOfficeSetupSelectedIndexChanged(object sender, EventArgs e){
			textBoxInstallationPath.Text = setups[(string)listBoxOfficeSetup.SelectedItem] ;
		}
		
		void ButtonDisableGrooveClick(object sender, EventArgs e){
			ContextChange(RegsvGroove.Disable) ;
		}
		
		void ButtonEnableGrooveClick(object sender, EventArgs e){
			ContextChange(RegsvGroove.Enable) ;
		}
		
		void SetupRescanToolStripMenuItemClick(object sender, EventArgs e){
			LoadSetup() ;
		}
		
		void EnableGrooveToolStripMenuItemClick(object sender, EventArgs e){
			ContextChange(RegsvGroove.Enable) ;
		}
		
		void DisableGrooveToolStripMenuItemClick(object sender, EventArgs e){
			ContextChange(RegsvGroove.Disable) ;
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show("GrooveDisabler - v 1.0\nCopyright (c) 2015, Petros Kyladitis\n\nA simple tweak utility to disable/enable MS Office 2007 \"Groove\", or MS Office 2010 \"Shared Folder\" Synchronization from Context Menu.\n\nThis program is free software distributed under the GNU GPL 3, for license details see at 'license.txt' file, distributed with this program, or see at <http://www.gnu.org/licenses/>.", "About GrooveDisabler", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
	}
}