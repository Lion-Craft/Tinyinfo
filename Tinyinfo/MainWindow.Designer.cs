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
			this.cpuOutputBox = new System.Windows.Forms.TextBox();
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
			this.ramOutputBox = new System.Windows.Forms.TextBox();
			this.gpuTab = new System.Windows.Forms.TabPage();
			this.gpuTabs = new System.Windows.Forms.TabControl();
			this.driverTab = new System.Windows.Forms.TabPage();
			this.gpuOutputBox = new System.Windows.Forms.TextBox();
			this.apiTab = new System.Windows.Forms.TabPage();
			this.nvapiOutputBox = new System.Windows.Forms.TextBox();
			this.boardTab = new System.Windows.Forms.TabPage();
			this.boardOutputBox = new System.Windows.Forms.TextBox();
			this.biosTab = new System.Windows.Forms.TabPage();
			this.biosOutputBox = new System.Windows.Forms.TextBox();
			this.battTab = new System.Windows.Forms.TabPage();
			this.battOutputBox = new System.Windows.Forms.TextBox();
			this.diskTab = new System.Windows.Forms.TabPage();
			this.diskOutputBox = new System.Windows.Forms.TextBox();
			this.netTab = new System.Windows.Forms.TabPage();
			this.netOutputBox = new System.Windows.Forms.TextBox();
			this.onTopBoxPanel.SuspendLayout();
			this.outputTabs.SuspendLayout();
			this.cpuTab.SuspendLayout();
			this.ramTab.SuspendLayout();
			this.gpuTab.SuspendLayout();
			this.gpuTabs.SuspendLayout();
			this.driverTab.SuspendLayout();
			this.apiTab.SuspendLayout();
			this.boardTab.SuspendLayout();
			this.biosTab.SuspendLayout();
			this.battTab.SuspendLayout();
			this.diskTab.SuspendLayout();
			this.netTab.SuspendLayout();
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
			// cpuOutputBox
			// 
			this.cpuOutputBox.AcceptsReturn = true;
			this.cpuOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cpuOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.cpuOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cpuOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpuOutputBox.Location = new System.Drawing.Point(0, 0);
			this.cpuOutputBox.Multiline = true;
			this.cpuOutputBox.Name = "cpuOutputBox";
			this.cpuOutputBox.ReadOnly = true;
			this.cpuOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.cpuOutputBox.Size = new System.Drawing.Size(644, 225);
			this.cpuOutputBox.TabIndex = 6;
			this.cpuOutputBox.WordWrap = false;
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
			this.outputTabs.Controls.Add(this.boardTab);
			this.outputTabs.Controls.Add(this.biosTab);
			this.outputTabs.Controls.Add(this.battTab);
			this.outputTabs.Controls.Add(this.diskTab);
			this.outputTabs.Controls.Add(this.netTab);
			this.outputTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputTabs.Location = new System.Drawing.Point(16, 33);
			this.outputTabs.Name = "outputTabs";
			this.outputTabs.SelectedIndex = 0;
			this.outputTabs.Size = new System.Drawing.Size(652, 255);
			this.outputTabs.TabIndex = 10;
			// 
			// cpuTab
			// 
			this.cpuTab.Controls.Add(this.cpuOutputBox);
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
			this.ramTab.Controls.Add(this.ramOutputBox);
			this.ramTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ramTab.Location = new System.Drawing.Point(4, 26);
			this.ramTab.Name = "ramTab";
			this.ramTab.Padding = new System.Windows.Forms.Padding(3);
			this.ramTab.Size = new System.Drawing.Size(644, 225);
			this.ramTab.TabIndex = 1;
			this.ramTab.Text = "RAM";
			this.ramTab.ToolTipText = "Displays information about the Computer\'s Memory";
			this.ramTab.UseVisualStyleBackColor = true;
			// 
			// ramOutputBox
			// 
			this.ramOutputBox.AcceptsReturn = true;
			this.ramOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ramOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.ramOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ramOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ramOutputBox.Location = new System.Drawing.Point(0, 0);
			this.ramOutputBox.Multiline = true;
			this.ramOutputBox.Name = "ramOutputBox";
			this.ramOutputBox.ReadOnly = true;
			this.ramOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ramOutputBox.Size = new System.Drawing.Size(644, 225);
			this.ramOutputBox.TabIndex = 7;
			this.ramOutputBox.WordWrap = false;
			// 
			// gpuTab
			// 
			this.gpuTab.Controls.Add(this.gpuTabs);
			this.gpuTab.Location = new System.Drawing.Point(4, 26);
			this.gpuTab.Name = "gpuTab";
			this.gpuTab.Size = new System.Drawing.Size(644, 225);
			this.gpuTab.TabIndex = 2;
			this.gpuTab.Text = "GPU";
			this.gpuTab.ToolTipText = "Displays information about the Computer\'s GPUs";
			this.gpuTab.UseVisualStyleBackColor = true;
			// 
			// gpuTabs
			// 
			this.gpuTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpuTabs.Controls.Add(this.driverTab);
			this.gpuTabs.Controls.Add(this.apiTab);
			this.gpuTabs.Location = new System.Drawing.Point(0, 0);
			this.gpuTabs.Name = "gpuTabs";
			this.gpuTabs.SelectedIndex = 0;
			this.gpuTabs.Size = new System.Drawing.Size(641, 225);
			this.gpuTabs.TabIndex = 0;
			// 
			// driverTab
			// 
			this.driverTab.Controls.Add(this.gpuOutputBox);
			this.driverTab.Location = new System.Drawing.Point(4, 26);
			this.driverTab.Name = "driverTab";
			this.driverTab.Padding = new System.Windows.Forms.Padding(3);
			this.driverTab.Size = new System.Drawing.Size(633, 195);
			this.driverTab.TabIndex = 0;
			this.driverTab.Text = "WMI Info";
			this.driverTab.UseVisualStyleBackColor = true;
			// 
			// gpuOutputBox
			// 
			this.gpuOutputBox.AcceptsReturn = true;
			this.gpuOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpuOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.gpuOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gpuOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpuOutputBox.Location = new System.Drawing.Point(0, 0);
			this.gpuOutputBox.Multiline = true;
			this.gpuOutputBox.Name = "gpuOutputBox";
			this.gpuOutputBox.ReadOnly = true;
			this.gpuOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.gpuOutputBox.Size = new System.Drawing.Size(633, 195);
			this.gpuOutputBox.TabIndex = 8;
			this.gpuOutputBox.WordWrap = false;
			// 
			// apiTab
			// 
			this.apiTab.Controls.Add(this.nvapiOutputBox);
			this.apiTab.Location = new System.Drawing.Point(4, 26);
			this.apiTab.Name = "apiTab";
			this.apiTab.Padding = new System.Windows.Forms.Padding(3);
			this.apiTab.Size = new System.Drawing.Size(633, 195);
			this.apiTab.TabIndex = 1;
			this.apiTab.Text = "NvAPI";
			this.apiTab.UseVisualStyleBackColor = true;
			// 
			// nvapiOutputBox
			// 
			this.nvapiOutputBox.AcceptsReturn = true;
			this.nvapiOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nvapiOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.nvapiOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nvapiOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nvapiOutputBox.Location = new System.Drawing.Point(0, 0);
			this.nvapiOutputBox.Multiline = true;
			this.nvapiOutputBox.Name = "nvapiOutputBox";
			this.nvapiOutputBox.ReadOnly = true;
			this.nvapiOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.nvapiOutputBox.Size = new System.Drawing.Size(633, 195);
			this.nvapiOutputBox.TabIndex = 9;
			this.nvapiOutputBox.WordWrap = false;
			// 
			// boardTab
			// 
			this.boardTab.Controls.Add(this.boardOutputBox);
			this.boardTab.Location = new System.Drawing.Point(4, 26);
			this.boardTab.Name = "boardTab";
			this.boardTab.Size = new System.Drawing.Size(644, 225);
			this.boardTab.TabIndex = 3;
			this.boardTab.Text = "Motherboard";
			this.boardTab.UseVisualStyleBackColor = true;
			// 
			// boardOutputBox
			// 
			this.boardOutputBox.AcceptsReturn = true;
			this.boardOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.boardOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.boardOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.boardOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boardOutputBox.Location = new System.Drawing.Point(0, 0);
			this.boardOutputBox.Multiline = true;
			this.boardOutputBox.Name = "boardOutputBox";
			this.boardOutputBox.ReadOnly = true;
			this.boardOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.boardOutputBox.Size = new System.Drawing.Size(644, 225);
			this.boardOutputBox.TabIndex = 7;
			this.boardOutputBox.WordWrap = false;
			// 
			// biosTab
			// 
			this.biosTab.Controls.Add(this.biosOutputBox);
			this.biosTab.Location = new System.Drawing.Point(4, 26);
			this.biosTab.Name = "biosTab";
			this.biosTab.Size = new System.Drawing.Size(644, 225);
			this.biosTab.TabIndex = 4;
			this.biosTab.Text = "BIOS";
			this.biosTab.UseVisualStyleBackColor = true;
			// 
			// biosOutputBox
			// 
			this.biosOutputBox.AcceptsReturn = true;
			this.biosOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.biosOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.biosOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.biosOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.biosOutputBox.Location = new System.Drawing.Point(0, 0);
			this.biosOutputBox.Multiline = true;
			this.biosOutputBox.Name = "biosOutputBox";
			this.biosOutputBox.ReadOnly = true;
			this.biosOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.biosOutputBox.Size = new System.Drawing.Size(644, 225);
			this.biosOutputBox.TabIndex = 7;
			this.biosOutputBox.WordWrap = false;
			// 
			// battTab
			// 
			this.battTab.Controls.Add(this.battOutputBox);
			this.battTab.Location = new System.Drawing.Point(4, 26);
			this.battTab.Name = "battTab";
			this.battTab.Size = new System.Drawing.Size(644, 225);
			this.battTab.TabIndex = 5;
			this.battTab.Text = "Battery";
			this.battTab.UseVisualStyleBackColor = true;
			// 
			// battOutputBox
			// 
			this.battOutputBox.AcceptsReturn = true;
			this.battOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.battOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.battOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.battOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.battOutputBox.Location = new System.Drawing.Point(0, 0);
			this.battOutputBox.Multiline = true;
			this.battOutputBox.Name = "battOutputBox";
			this.battOutputBox.ReadOnly = true;
			this.battOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.battOutputBox.Size = new System.Drawing.Size(644, 225);
			this.battOutputBox.TabIndex = 7;
			this.battOutputBox.WordWrap = false;
			// 
			// diskTab
			// 
			this.diskTab.Controls.Add(this.diskOutputBox);
			this.diskTab.Location = new System.Drawing.Point(4, 26);
			this.diskTab.Name = "diskTab";
			this.diskTab.Size = new System.Drawing.Size(644, 225);
			this.diskTab.TabIndex = 6;
			this.diskTab.Text = "Disk";
			this.diskTab.UseVisualStyleBackColor = true;
			// 
			// diskOutputBox
			// 
			this.diskOutputBox.AcceptsReturn = true;
			this.diskOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.diskOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.diskOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.diskOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diskOutputBox.Location = new System.Drawing.Point(0, 0);
			this.diskOutputBox.Multiline = true;
			this.diskOutputBox.Name = "diskOutputBox";
			this.diskOutputBox.ReadOnly = true;
			this.diskOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.diskOutputBox.Size = new System.Drawing.Size(644, 225);
			this.diskOutputBox.TabIndex = 7;
			this.diskOutputBox.WordWrap = false;
			// 
			// netTab
			// 
			this.netTab.Controls.Add(this.netOutputBox);
			this.netTab.Location = new System.Drawing.Point(4, 26);
			this.netTab.Name = "netTab";
			this.netTab.Size = new System.Drawing.Size(644, 225);
			this.netTab.TabIndex = 7;
			this.netTab.Text = "Network";
			this.netTab.UseVisualStyleBackColor = true;
			// 
			// netOutputBox
			// 
			this.netOutputBox.AcceptsReturn = true;
			this.netOutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.netOutputBox.BackColor = System.Drawing.SystemColors.Window;
			this.netOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.netOutputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.netOutputBox.Location = new System.Drawing.Point(0, 0);
			this.netOutputBox.Multiline = true;
			this.netOutputBox.Name = "netOutputBox";
			this.netOutputBox.ReadOnly = true;
			this.netOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.netOutputBox.Size = new System.Drawing.Size(644, 225);
			this.netOutputBox.TabIndex = 7;
			this.netOutputBox.WordWrap = false;
			// 
			// MainWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(681, 371);
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
			this.ramTab.ResumeLayout(false);
			this.ramTab.PerformLayout();
			this.gpuTab.ResumeLayout(false);
			this.gpuTabs.ResumeLayout(false);
			this.driverTab.ResumeLayout(false);
			this.driverTab.PerformLayout();
			this.apiTab.ResumeLayout(false);
			this.apiTab.PerformLayout();
			this.boardTab.ResumeLayout(false);
			this.boardTab.PerformLayout();
			this.biosTab.ResumeLayout(false);
			this.biosTab.PerformLayout();
			this.battTab.ResumeLayout(false);
			this.battTab.PerformLayout();
			this.diskTab.ResumeLayout(false);
			this.diskTab.PerformLayout();
			this.netTab.ResumeLayout(false);
			this.netTab.PerformLayout();
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
		public System.Windows.Forms.TextBox cpuOutputBox;
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
		public System.Windows.Forms.TextBox ramOutputBox;
		public System.Windows.Forms.TextBox gpuOutputBox;
		private System.Windows.Forms.TabPage boardTab;
		public System.Windows.Forms.TextBox boardOutputBox;
		private System.Windows.Forms.TabPage biosTab;
		public System.Windows.Forms.TextBox biosOutputBox;
		private System.Windows.Forms.TabPage battTab;
		public System.Windows.Forms.TextBox battOutputBox;
		private System.Windows.Forms.TabPage diskTab;
		public System.Windows.Forms.TextBox diskOutputBox;
		private System.Windows.Forms.TabPage netTab;
		public System.Windows.Forms.TextBox netOutputBox;
		private System.Windows.Forms.TabControl gpuTabs;
		private System.Windows.Forms.TabPage driverTab;
		private System.Windows.Forms.TabPage apiTab;
		public System.Windows.Forms.TextBox nvapiOutputBox;
	}
}

