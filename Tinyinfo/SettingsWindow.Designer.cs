namespace Tinyinfo
{
	partial class SettingsWindow
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
			this.lightThemeRadioButton = new System.Windows.Forms.RadioButton();
			this.darkThemeRadioButton = new System.Windows.Forms.RadioButton();
			this.themeLabel = new System.Windows.Forms.Label();
			this.applyButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.refreshRateUpDown = new System.Windows.Forms.NumericUpDown();
			this.refreshRateLabel = new System.Windows.Forms.Label();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.fontButton = new System.Windows.Forms.Button();
			this.settingTabs = new System.Windows.Forms.TabControl();
			this.themeTab = new System.Windows.Forms.TabPage();
			this.generalTab = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.refreshRateUpDown)).BeginInit();
			this.settingTabs.SuspendLayout();
			this.themeTab.SuspendLayout();
			this.generalTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// lightThemeRadioButton
			// 
			this.lightThemeRadioButton.AutoSize = true;
			this.lightThemeRadioButton.Checked = true;
			this.lightThemeRadioButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lightThemeRadioButton.Location = new System.Drawing.Point(6, 23);
			this.lightThemeRadioButton.Name = "lightThemeRadioButton";
			this.lightThemeRadioButton.Size = new System.Drawing.Size(51, 17);
			this.lightThemeRadioButton.TabIndex = 2;
			this.lightThemeRadioButton.TabStop = true;
			this.lightThemeRadioButton.Text = "Light";
			this.lightThemeRadioButton.UseVisualStyleBackColor = true;
			// 
			// darkThemeRadioButton
			// 
			this.darkThemeRadioButton.AutoSize = true;
			this.darkThemeRadioButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkThemeRadioButton.Location = new System.Drawing.Point(6, 46);
			this.darkThemeRadioButton.Name = "darkThemeRadioButton";
			this.darkThemeRadioButton.Size = new System.Drawing.Size(49, 17);
			this.darkThemeRadioButton.TabIndex = 3;
			this.darkThemeRadioButton.Text = "Dark";
			this.darkThemeRadioButton.UseVisualStyleBackColor = true;
			// 
			// themeLabel
			// 
			this.themeLabel.AutoSize = true;
			this.themeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.themeLabel.Location = new System.Drawing.Point(4, 7);
			this.themeLabel.Name = "themeLabel";
			this.themeLabel.Size = new System.Drawing.Size(41, 13);
			this.themeLabel.TabIndex = 4;
			this.themeLabel.Text = "Theme";
			// 
			// applyButton
			// 
			this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applyButton.Location = new System.Drawing.Point(10, 318);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(97, 31);
			this.applyButton.TabIndex = 5;
			this.applyButton.Text = "Apply";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(375, 318);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(97, 31);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// refreshRateUpDown
			// 
			this.refreshRateUpDown.Cursor = System.Windows.Forms.Cursors.Default;
			this.refreshRateUpDown.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshRateUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.refreshRateUpDown.Location = new System.Drawing.Point(105, 12);
			this.refreshRateUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.refreshRateUpDown.Name = "refreshRateUpDown";
			this.refreshRateUpDown.Size = new System.Drawing.Size(43, 22);
			this.refreshRateUpDown.TabIndex = 7;
			this.refreshRateUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// refreshRateLabel
			// 
			this.refreshRateLabel.AutoSize = true;
			this.refreshRateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshRateLabel.Location = new System.Drawing.Point(3, 14);
			this.refreshRateLabel.Name = "refreshRateLabel";
			this.refreshRateLabel.Size = new System.Drawing.Size(96, 13);
			this.refreshRateLabel.TabIndex = 8;
			this.refreshRateLabel.Text = "Max Refresh Rate";
			// 
			// fontDialog
			// 
			this.fontDialog.AllowScriptChange = false;
			this.fontDialog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontDialog.ShowColor = true;
			this.fontDialog.ShowEffects = false;
			// 
			// fontButton
			// 
			this.fontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.fontButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.fontButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontButton.Location = new System.Drawing.Point(349, 231);
			this.fontButton.Name = "fontButton";
			this.fontButton.Size = new System.Drawing.Size(97, 31);
			this.fontButton.TabIndex = 9;
			this.fontButton.Text = "Change Font";
			this.fontButton.UseVisualStyleBackColor = true;
			this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
			// 
			// settingTabs
			// 
			this.settingTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingTabs.Controls.Add(this.themeTab);
			this.settingTabs.Controls.Add(this.generalTab);
			this.settingTabs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settingTabs.HotTrack = true;
			this.settingTabs.Location = new System.Drawing.Point(10, 12);
			this.settingTabs.Multiline = true;
			this.settingTabs.Name = "settingTabs";
			this.settingTabs.SelectedIndex = 0;
			this.settingTabs.ShowToolTips = true;
			this.settingTabs.Size = new System.Drawing.Size(462, 300);
			this.settingTabs.TabIndex = 10;
			// 
			// themeTab
			// 
			this.themeTab.BackColor = System.Drawing.Color.White;
			this.themeTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.themeTab.Controls.Add(this.lightThemeRadioButton);
			this.themeTab.Controls.Add(this.fontButton);
			this.themeTab.Controls.Add(this.darkThemeRadioButton);
			this.themeTab.Controls.Add(this.themeLabel);
			this.themeTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.themeTab.Location = new System.Drawing.Point(4, 26);
			this.themeTab.Name = "themeTab";
			this.themeTab.Padding = new System.Windows.Forms.Padding(3);
			this.themeTab.Size = new System.Drawing.Size(454, 270);
			this.themeTab.TabIndex = 0;
			this.themeTab.Text = "Theme";
			this.themeTab.ToolTipText = "Change Theme Settings";
			// 
			// generalTab
			// 
			this.generalTab.BackColor = System.Drawing.Color.White;
			this.generalTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.generalTab.Controls.Add(this.refreshRateUpDown);
			this.generalTab.Controls.Add(this.refreshRateLabel);
			this.generalTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generalTab.Location = new System.Drawing.Point(4, 26);
			this.generalTab.Name = "generalTab";
			this.generalTab.Padding = new System.Windows.Forms.Padding(3);
			this.generalTab.Size = new System.Drawing.Size(454, 270);
			this.generalTab.TabIndex = 1;
			this.generalTab.Text = "General";
			this.generalTab.ToolTipText = "Change Generic Settings";
			// 
			// SettingsWindow
			// 
			this.AcceptButton = this.applyButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.settingTabs);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.applyButton);
			this.MinimumSize = new System.Drawing.Size(285, 200);
			this.Name = "SettingsWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tinyinfo Settings";
			((System.ComponentModel.ISupportInitialize)(this.refreshRateUpDown)).EndInit();
			this.settingTabs.ResumeLayout(false);
			this.themeTab.ResumeLayout(false);
			this.themeTab.PerformLayout();
			this.generalTab.ResumeLayout(false);
			this.generalTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton lightThemeRadioButton;
		private System.Windows.Forms.RadioButton darkThemeRadioButton;
		private System.Windows.Forms.Label themeLabel;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.NumericUpDown refreshRateUpDown;
		private System.Windows.Forms.Label refreshRateLabel;
		private System.Windows.Forms.FontDialog fontDialog;
		private System.Windows.Forms.Button fontButton;
		private System.Windows.Forms.TabControl settingTabs;
		private System.Windows.Forms.TabPage themeTab;
		private System.Windows.Forms.TabPage generalTab;
	}
}