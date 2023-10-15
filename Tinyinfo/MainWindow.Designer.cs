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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ID:");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manufacturer:");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Model:");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Description:");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Socket:");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Core Amount:");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Virtualization: ");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Clockspeeds");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("CPU", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node4");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Video", new System.Windows.Forms.TreeNode[] {
            treeNode10});
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node3");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("RAM", new System.Windows.Forms.TreeNode[] {
            treeNode12});
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node7");
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Motherboard", new System.Windows.Forms.TreeNode[] {
            treeNode14});
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node9");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("BIOS", new System.Windows.Forms.TreeNode[] {
            treeNode16});
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node11");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Battery", new System.Windows.Forms.TreeNode[] {
            treeNode18});
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node13");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Drives", new System.Windows.Forms.TreeNode[] {
            treeNode20});
			this.startButton = new System.Windows.Forms.Button();
			this.infoLabel = new System.Windows.Forms.Label();
			this.stopButton = new System.Windows.Forms.Button();
			this.pauseButton = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.onTopCheckbox = new System.Windows.Forms.CheckBox();
			this.menuBar = new System.Windows.Forms.MainMenu(this.components);
			this.fileDropdown = new System.Windows.Forms.MenuItem();
			this.exportItem = new System.Windows.Forms.MenuItem();
			this.settingsItem = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.exitItem = new System.Windows.Forms.MenuItem();
			this.refreshItem = new System.Windows.Forms.MenuItem();
			this.helpDropdown = new System.Windows.Forms.MenuItem();
			this.aboutItem = new System.Windows.Forms.MenuItem();
			this.githubItem = new System.Windows.Forms.MenuItem();
			this.onTopBoxPanel = new System.Windows.Forms.Panel();
			this.outputTree = new System.Windows.Forms.TreeView();
			this.onTopBoxPanel.SuspendLayout();
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
			// pauseButton
			// 
			this.pauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pauseButton.Enabled = false;
			this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pauseButton.Location = new System.Drawing.Point(137, 319);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(115, 40);
			this.pauseButton.TabIndex = 4;
			this.pauseButton.Text = "Pause/Play";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Visible = false;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
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
            this.settingsItem,
            this.menuItem2,
            this.exitItem});
			this.fileDropdown.Text = "File";
			// 
			// exportItem
			// 
			this.exportItem.Index = 0;
			this.exportItem.Text = "Export";
			this.exportItem.Click += new System.EventHandler(this.exportItem_Click);
			// 
			// settingsItem
			// 
			this.settingsItem.Index = 1;
			this.settingsItem.Text = "Settings";
			this.settingsItem.Click += new System.EventHandler(this.settingsItem_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "-";
			// 
			// exitItem
			// 
			this.exitItem.Index = 3;
			this.exitItem.Text = "Exit";
			this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
			// 
			// refreshItem
			// 
			this.refreshItem.Index = 1;
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
			this.aboutItem.Text = "About";
			this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
			// 
			// githubItem
			// 
			this.githubItem.Index = 1;
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
			// outputTree
			// 
			this.outputTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputTree.HotTracking = true;
			this.outputTree.Location = new System.Drawing.Point(16, 33);
			this.outputTree.Name = "outputTree";
			treeNode1.Name = "CpuIdNode";
			treeNode1.Text = "ID:";
			treeNode2.Name = "CpuManuNode";
			treeNode2.Text = "Manufacturer:";
			treeNode3.Name = "CpuModelNode";
			treeNode3.Text = "Model:";
			treeNode4.Name = "CpuDescNode";
			treeNode4.Text = "Description:";
			treeNode5.Name = "CpuSocketNode";
			treeNode5.Text = "Socket:";
			treeNode6.Name = "CpuCoresNode";
			treeNode6.Text = "Core Amount:";
			treeNode7.Name = "CpuVmxNode";
			treeNode7.Text = "Virtualization: ";
			treeNode8.Name = "CpuClocksNode";
			treeNode8.Text = "Clockspeeds";
			treeNode9.Name = "CpuNode";
			treeNode9.Text = "CPU";
			treeNode10.Name = "Node4";
			treeNode10.Text = "Node4";
			treeNode11.Name = "VideoNode";
			treeNode11.Text = "Video";
			treeNode12.Name = "Node3";
			treeNode12.Text = "Node3";
			treeNode13.Name = "MemoryNode";
			treeNode13.Text = "RAM";
			treeNode14.Name = "Node7";
			treeNode14.Text = "Node7";
			treeNode15.Name = "MotherboardNode";
			treeNode15.Text = "Motherboard";
			treeNode16.Name = "Node9";
			treeNode16.Text = "Node9";
			treeNode17.Name = "BiosNode";
			treeNode17.Text = "BIOS";
			treeNode18.Name = "Node11";
			treeNode18.Text = "Node11";
			treeNode19.Name = "BatteryNode";
			treeNode19.Text = "Battery";
			treeNode20.Name = "Node13";
			treeNode20.Text = "Node13";
			treeNode21.Name = "DriveNode";
			treeNode21.Text = "Drives";
			this.outputTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11,
            treeNode13,
            treeNode15,
            treeNode17,
            treeNode19,
            treeNode21});
			this.outputTree.Size = new System.Drawing.Size(651, 255);
			this.outputTree.TabIndex = 9;
			// 
			// MainWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(681, 371);
			this.Controls.Add(this.outputBox);
			this.Controls.Add(this.outputTree);
			this.Controls.Add(this.onTopBoxPanel);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.infoLabel);
			this.Controls.Add(this.startButton);
			this.Menu = this.menuBar;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.Text = "Tinyinfo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.startup);
			this.onTopBoxPanel.ResumeLayout(false);
			this.onTopBoxPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button pauseButton;
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
		private System.Windows.Forms.TreeView outputTree;
	}
}

