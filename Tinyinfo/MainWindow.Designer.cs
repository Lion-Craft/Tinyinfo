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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.onTopCheckbox = new System.Windows.Forms.CheckBox();
			this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
			this.settings = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.about = new System.Windows.Forms.MenuItem();
			this.github = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(16, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(335, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Press Start to continuously update System Info.";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(526, 278);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 40);
			this.button2.TabIndex = 3;
			this.button2.Text = "Stop";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Enabled = false;
			this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(137, 278);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 40);
			this.button3.TabIndex = 4;
			this.button3.Text = "Pause/Play";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(16, 262);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(624, 10);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 5;
			this.progressBar1.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(16, 33);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(625, 223);
			this.textBox1.TabIndex = 6;
			this.textBox1.WordWrap = false;
			// 
			// onTopCheckbox
			// 
			this.onTopCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.onTopCheckbox.AutoSize = true;
			this.onTopCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.onTopCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.onTopCheckbox.Location = new System.Drawing.Point(386, 286);
			this.onTopCheckbox.Name = "onTopCheckbox";
			this.onTopCheckbox.Size = new System.Drawing.Size(134, 26);
			this.onTopCheckbox.TabIndex = 7;
			this.onTopCheckbox.Text = "Always on Top";
			this.onTopCheckbox.UseVisualStyleBackColor = true;
			this.onTopCheckbox.CheckedChanged += new System.EventHandler(this.onTopCheckbox_CheckedChanged);
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.settings,
            this.menuItem2});
			// 
			// settings
			// 
			this.settings.Index = 0;
			this.settings.Text = "Settings";
			this.settings.Click += new System.EventHandler(this.settings_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.about,
            this.github});
			this.menuItem2.Text = "Help";
			// 
			// about
			// 
			this.about.Index = 0;
			this.about.Text = "About";
			this.about.Click += new System.EventHandler(this.about_Click);
			// 
			// github
			// 
			this.github.Index = 1;
			this.github.Text = "Github";
			this.github.Click += new System.EventHandler(this.github_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(653, 330);
			this.Controls.Add(this.onTopCheckbox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Menu = this.mainMenu;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.Text = "Tinyinfo";
			this.Load += new System.EventHandler(this.startup);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox onTopCheckbox;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem settings;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem about;
		private System.Windows.Forms.MenuItem github;
	}
}

