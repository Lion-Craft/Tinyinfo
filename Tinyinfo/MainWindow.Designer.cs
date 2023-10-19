namespace Tinyinfo
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.startButton = new System.Windows.Forms.Button();
			this.infoLabel = new System.Windows.Forms.Label();
			this.stopButton = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.onTopCheckbox = new System.Windows.Forms.CheckBox();
			this.menuBar = new System.Windows.Forms.MainMenu(this.components);
			this.fileDropdown = new System.Windows.Forms.MenuItem();
			this.exportItem = new System.Windows.Forms.MenuItem();
			this.btnExportAsJSON = new System.Windows.Forms.MenuItem();
			this.settingsItem = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.exitItem = new System.Windows.Forms.MenuItem();
			this.refreshItem = new System.Windows.Forms.MenuItem();
			this.helpDropdown = new System.Windows.Forms.MenuItem();
			this.aboutItem = new System.Windows.Forms.MenuItem();
			this.githubItem = new System.Windows.Forms.MenuItem();
			this.onTopBoxPanel = new System.Windows.Forms.Panel();
			this.outputTabs = new System.Windows.Forms.TabControl();
			this.cpuTab = new System.Windows.Forms.TabPage();
			this.ramTab = new System.Windows.Forms.TabPage();
			this.gpuTab = new System.Windows.Forms.TabPage();
			this.cpuModelLabel = new System.Windows.Forms.Label();
			this.cpuManuLabel = new System.Windows.Forms.Label();
			this.onTopBoxPanel.SuspendLayout();
			this.outputTabs.SuspendLayout();
			this.cpuTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.startButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(16, 319);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(115, 40);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// infoLabel
			// 
			this.infoLabel.AutoSize = true;
			this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infoLabel.Location = new System.Drawing.Point(12, 9);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(335, 21);
			this.infoLabel.TabIndex = 2;
			this.infoLabel.Text = "Press Start to continuously update System Info.";
			// 
			// stopButton
			// 
			this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.stopButton.Enabled = false;
			this.stopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stopButton.Location = new System.Drawing.Point(554, 319);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(115, 40);
			this.stopButton.TabIndex = 3;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(16, 294);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(652, 19);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar.TabIndex = 5;
			this.progressBar.Visible = false;
			// 
			// outputBox
			// 
			this.outputBox.AcceptsReturn = true;
			this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputBox.BackColor = System.Drawing.SystemColors.Window;
			this.outputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputBox.Location = new System.Drawing.Point(388, 96);
			this.outputBox.Multiline = true;
			this.outputBox.Name = "outputBox";
			this.outputBox.ReadOnly = true;
			this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.outputBox.Size = new System.Drawing.Size(264, 147);
			this.outputBox.TabIndex = 6;
			this.outputBox.Visible = false;
			this.outputBox.WordWrap = false;
			// 
			// onTopCheckbox
			// 
			this.onTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.onTopCheckbox.AutoSize = true;
			this.onTopCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.onTopCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.onTopCheckbox.Location = new System.Drawing.Point(6, 8);
			this.onTopCheckbox.Name = "onTopCheckbox";
			this.onTopCheckbox.Size = new System.Drawing.Size(134, 26);
			this.onTopCheckbox.TabIndex = 7;
			this.onTopCheckbox.Text = "Always on Top";
			this.onTopCheckbox.UseVisualStyleBackColor = true;
			this.onTopCheckbox.CheckedChanged += new System.EventHandler(this.onTopCheckbox_CheckedChanged);
			// 
			// menuBar
			// 
			this.menuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileDropdown,
            this.refreshItem,
            this.helpDropdown});
			// 
			// fileDropdown
			// 
			this.fileDropdown.Index = 0;
			this.fileDropdown.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.exportItem,
            this.btnExportAsJSON,
            this.settingsItem,
            this.menuItem2,
            this.exitItem});
			this.fileDropdown.Text = "File";
			// 
			// exportItem
			// 
			this.exportItem.Index = 0;
			this.exportItem.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
			this.exportItem.Text = "Export as plain text";
			this.exportItem.Click += new System.EventHandler(this.exportItem_Click);
			// 
			// btnExportAsJSON
			// 
			this.btnExportAsJSON.Index = 1;
			this.btnExportAsJSON.RadioCheck = true;
			this.btnExportAsJSON.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
			this.btnExportAsJSON.Text = "Export as JSON";
			this.btnExportAsJSON.Click += new System.EventHandler(this.btnExportAsJSON_Click);
			// 
			// settingsItem
			// 
			this.settingsItem.Index = 2;
			this.settingsItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.settingsItem.Text = "Settings";
			this.settingsItem.Click += new System.EventHandler(this.settingsItem_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.Text = "-";
			// 
			// exitItem
			// 
			this.exitItem.Index = 4;
			this.exitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.exitItem.Text = "Exit";
			this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
			// 
			// refreshItem
			// 
			this.refreshItem.Index = 1;
			this.refreshItem.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.refreshItem.Text = "Refresh";
			this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
			// 
			// helpDropdown
			// 
			this.helpDropdown.Index = 2;
			this.helpDropdown.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutItem,
            this.githubItem});
			this.helpDropdown.Text = "Help";
			// 
			// aboutItem
			// 
			this.aboutItem.Index = 0;
			this.aboutItem.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.aboutItem.Text = "About";
			this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
			// 
			// githubItem
			// 
			this.githubItem.Index = 1;
			this.githubItem.Shortcut = System.Windows.Forms.Shortcut.ShiftF1;
			this.githubItem.Text = "Github";
			this.githubItem.Click += new System.EventHandler(this.githubItem_Click);
			// 
			// onTopBoxPanel
			// 
			this.onTopBoxPanel.AllowDrop = true;
			this.onTopBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.onTopBoxPanel.Controls.Add(this.onTopCheckbox);
			this.onTopBoxPanel.Location = new System.Drawing.Point(408, 319);
			this.onTopBoxPanel.Name = "onTopBoxPanel";
			this.onTopBoxPanel.Size = new System.Drawing.Size(140, 40);
			this.onTopBoxPanel.TabIndex = 8;
			// 
			// outputTabs
			// 
			this.outputTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTabs.Controls.Add(this.cpuTab);
			this.outputTabs.Controls.Add(this.ramTab);
			this.outputTabs.Controls.Add(this.gpuTab);
			this.outputTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputTabs.Location = new System.Drawing.Point(16, 33);
			this.outputTabs.Name = "outputTabs";
			this.outputTabs.SelectedIndex = 0;
			this.outputTabs.Size = new System.Drawing.Size(652, 255);
			this.outputTabs.TabIndex = 10;
			// 
			// cpuTab
			// 
			this.cpuTab.AutoScroll = true;
			this.cpuTab.Controls.Add(this.cpuManuLabel);
			this.cpuTab.Controls.Add(this.cpuModelLabel);
			this.cpuTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpuTab.Location = new System.Drawing.Point(4, 26);
			this.cpuTab.Name = "cpuTab";
			this.cpuTab.Padding = new System.Windows.Forms.Padding(3);
			this.cpuTab.Size = new System.Drawing.Size(644, 225);
			this.cpuTab.TabIndex = 0;
			this.cpuTab.Text = "CPU";
			this.cpuTab.ToolTipText = "Displays Information about the Computer\'s CPU";
			this.cpuTab.UseVisualStyleBackColor = true;
			// 
			// ramTab
			// 
			this.ramTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ramTab.Location = new System.Drawing.Point(4, 22);
			this.ramTab.Name = "ramTab";
			this.ramTab.Padding = new System.Windows.Forms.Padding(3);
			this.ramTab.Size = new System.Drawing.Size(644, 229);
			this.ramTab.TabIndex = 1;
			this.ramTab.Text = "RAM";
			this.ramTab.ToolTipText = "Displays information about the Computer\'s Memory";
			this.ramTab.UseVisualStyleBackColor = true;
			// 
			// gpuTab
			// 
			this.gpuTab.Location = new System.Drawing.Point(4, 22);
			this.gpuTab.Name = "gpuTab";
			this.gpuTab.Size = new System.Drawing.Size(644, 229);
			this.gpuTab.TabIndex = 2;
			this.gpuTab.Text = "GPU";
			this.gpuTab.ToolTipText = "Displays information about the Computer\'s GPUs";
			this.gpuTab.UseVisualStyleBackColor = true;
			// 
			// cpuModelLabel
			// 
			this.cpuModelLabel.AutoSize = true;
			this.cpuModelLabel.Location = new System.Drawing.Point(6, 3);
			this.cpuModelLabel.Name = "cpuModelLabel";
			this.cpuModelLabel.Size = new System.Drawing.Size(74, 17);
			this.cpuModelLabel.TabIndex = 0;
			this.cpuModelLabel.Text = "CPU Model";
			// 
			// cpuManuLabel
			// 
			this.cpuManuLabel.AutoSize = true;
			this.cpuManuLabel.Location = new System.Drawing.Point(6, 37);
			this.cpuManuLabel.Name = "cpuManuLabel";
			this.cpuManuLabel.Size = new System.Drawing.Size(114, 17);
			this.cpuManuLabel.TabIndex = 1;
			this.cpuManuLabel.Text = "CPU Manufacturer";
			// 
			// MainWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(681, 371);
			this.Controls.Add(this.outputBox);
			this.Controls.Add(this.outputTabs);
			this.Controls.Add(this.onTopBoxPanel);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.infoLabel);
			this.Controls.Add(this.startButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuBar;
			this.Name = "MainWindow";
			this.Text = "Tinyinfo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.Startup);
			this.onTopBoxPanel.ResumeLayout(false);
			this.onTopBoxPanel.PerformLayout();
			this.outputTabs.ResumeLayout(false);
			this.cpuTab.ResumeLayout(false);
			this.cpuTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.CheckBox onTopCheckbox;
		private System.Windows.Forms.MainMenu menuBar;
		private System.Windows.Forms.MenuItem settingsItem;
		private System.Windows.Forms.MenuItem helpDropdown;
		private System.Windows.Forms.MenuItem aboutItem;
		private System.Windows.Forms.MenuItem githubItem;
		public System.Windows.Forms.TextBox outputBox;
		private System.Windows.Forms.Panel onTopBoxPanel;
		private System.Windows.Forms.MenuItem refreshItem;
        private System.Windows.Forms.MenuItem fileDropdown;
        private System.Windows.Forms.MenuItem exportItem;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem exitItem;
        private System.Windows.Forms.MenuItem btnExportAsJSON;
		private System.Windows.Forms.TabControl outputTabs;
		private System.Windows.Forms.TabPage cpuTab;
		private System.Windows.Forms.TabPage ramTab;
		private System.Windows.Forms.TabPage gpuTab;
		private System.Windows.Forms.Label cpuModelLabel;
		private System.Windows.Forms.Label cpuManuLabel;
	}
}

