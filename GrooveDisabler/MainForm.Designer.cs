/* GrooveDisable v1.0 - Main Form Designer
 * 
 * Copyright (c) 2015, Petros Kyladitis <http://www.multipetros.gr/> 
 * This is free software distributed under the GNU GPL 3, for license details see at 'license.txt' 
 * file, distributed with this program, or see at <http://www.gnu.org/licenses/>
 * */
 
namespace GrooveDisabler{
	partial class MainForm{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing){
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setupRescanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enableGrooveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disableGrooveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listBoxOfficeSetup = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxInstallationPath = new System.Windows.Forms.TextBox();
			this.buttonDisableGroove = new System.Windows.Forms.Button();
			this.buttonEnableGroove = new System.Windows.Forms.Button();
			this.groupBoxOfficeSetup = new System.Windows.Forms.GroupBox();
			this.labelOfficeNotFound = new System.Windows.Forms.Label();
			this.menuStripMain.SuspendLayout();
			this.groupBoxOfficeSetup.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(323, 24);
			this.menuStripMain.TabIndex = 0;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.setupRescanToolStripMenuItem,
									this.enableGrooveToolStripMenuItem,
									this.disableGrooveToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// setupRescanToolStripMenuItem
			// 
			this.setupRescanToolStripMenuItem.Name = "setupRescanToolStripMenuItem";
			this.setupRescanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.setupRescanToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
			this.setupRescanToolStripMenuItem.Text = "&Rescan Office Setups";
			this.setupRescanToolStripMenuItem.Click += new System.EventHandler(this.SetupRescanToolStripMenuItemClick);
			// 
			// enableGrooveToolStripMenuItem
			// 
			this.enableGrooveToolStripMenuItem.Name = "enableGrooveToolStripMenuItem";
			this.enableGrooveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.enableGrooveToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
			this.enableGrooveToolStripMenuItem.Text = "E&nable Groove";
			this.enableGrooveToolStripMenuItem.Click += new System.EventHandler(this.EnableGrooveToolStripMenuItemClick);
			// 
			// disableGrooveToolStripMenuItem
			// 
			this.disableGrooveToolStripMenuItem.Name = "disableGrooveToolStripMenuItem";
			this.disableGrooveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.disableGrooveToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
			this.disableGrooveToolStripMenuItem.Text = "Di&sable Groove";
			this.disableGrooveToolStripMenuItem.Click += new System.EventHandler(this.DisableGrooveToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "He&lp";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "A&bout";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// listBoxOfficeSetup
			// 
			this.listBoxOfficeSetup.FormattingEnabled = true;
			this.listBoxOfficeSetup.Location = new System.Drawing.Point(6, 19);
			this.listBoxOfficeSetup.Name = "listBoxOfficeSetup";
			this.listBoxOfficeSetup.Size = new System.Drawing.Size(286, 43);
			this.listBoxOfficeSetup.TabIndex = 1;
			this.listBoxOfficeSetup.SelectedIndexChanged += new System.EventHandler(this.ListBoxOfficeSetupSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Installation Path";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// textBoxInstallationPath
			// 
			this.textBoxInstallationPath.Location = new System.Drawing.Point(6, 91);
			this.textBoxInstallationPath.Name = "textBoxInstallationPath";
			this.textBoxInstallationPath.ReadOnly = true;
			this.textBoxInstallationPath.Size = new System.Drawing.Size(286, 20);
			this.textBoxInstallationPath.TabIndex = 3;
			// 
			// buttonDisableGroove
			// 
			this.buttonDisableGroove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.buttonDisableGroove.ForeColor = System.Drawing.Color.Red;
			this.buttonDisableGroove.Location = new System.Drawing.Point(12, 174);
			this.buttonDisableGroove.Name = "buttonDisableGroove";
			this.buttonDisableGroove.Size = new System.Drawing.Size(142, 42);
			this.buttonDisableGroove.TabIndex = 4;
			this.buttonDisableGroove.Text = "Di&sable Groove from Context menu";
			this.buttonDisableGroove.UseVisualStyleBackColor = true;
			this.buttonDisableGroove.Click += new System.EventHandler(this.ButtonDisableGrooveClick);
			// 
			// buttonEnableGroove
			// 
			this.buttonEnableGroove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.buttonEnableGroove.ForeColor = System.Drawing.Color.Green;
			this.buttonEnableGroove.Location = new System.Drawing.Point(168, 174);
			this.buttonEnableGroove.Name = "buttonEnableGroove";
			this.buttonEnableGroove.Size = new System.Drawing.Size(142, 42);
			this.buttonEnableGroove.TabIndex = 5;
			this.buttonEnableGroove.Text = "E&nable Groove from Context menu";
			this.buttonEnableGroove.UseVisualStyleBackColor = true;
			this.buttonEnableGroove.Click += new System.EventHandler(this.ButtonEnableGrooveClick);
			// 
			// groupBoxOfficeSetup
			// 
			this.groupBoxOfficeSetup.Controls.Add(this.labelOfficeNotFound);
			this.groupBoxOfficeSetup.Controls.Add(this.textBoxInstallationPath);
			this.groupBoxOfficeSetup.Controls.Add(this.label1);
			this.groupBoxOfficeSetup.Controls.Add(this.listBoxOfficeSetup);
			this.groupBoxOfficeSetup.Location = new System.Drawing.Point(12, 38);
			this.groupBoxOfficeSetup.Name = "groupBoxOfficeSetup";
			this.groupBoxOfficeSetup.Size = new System.Drawing.Size(298, 121);
			this.groupBoxOfficeSetup.TabIndex = 6;
			this.groupBoxOfficeSetup.TabStop = false;
			this.groupBoxOfficeSetup.Text = "MS Office Setup";
			// 
			// labelOfficeNotFound
			// 
			this.labelOfficeNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.labelOfficeNotFound.ForeColor = System.Drawing.Color.Maroon;
			this.labelOfficeNotFound.Location = new System.Drawing.Point(6, 19);
			this.labelOfficeNotFound.Name = "labelOfficeNotFound";
			this.labelOfficeNotFound.Size = new System.Drawing.Size(286, 92);
			this.labelOfficeNotFound.TabIndex = 4;
			this.labelOfficeNotFound.Text = "MS Office 2007 or MS Office 2010\r\nnot found installed on your system";
			this.labelOfficeNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelOfficeNotFound.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 228);
			this.Controls.Add(this.groupBoxOfficeSetup);
			this.Controls.Add(this.buttonEnableGroove);
			this.Controls.Add(this.buttonDisableGroove);
			this.Controls.Add(this.menuStripMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "GrooveDisabler";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.groupBoxOfficeSetup.ResumeLayout(false);
			this.groupBoxOfficeSetup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelOfficeNotFound;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem disableGrooveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enableGrooveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setupRescanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxOfficeSetup;
		private System.Windows.Forms.Button buttonEnableGroove;
		private System.Windows.Forms.Button buttonDisableGroove;
		private System.Windows.Forms.TextBox textBoxInstallationPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxOfficeSetup;
		private System.Windows.Forms.MenuStrip menuStripMain;
	}
}
