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
			this.fontSizeUpDown = new System.Windows.Forms.NumericUpDown();
			this.fontSizeLabel = new System.Windows.Forms.Label();
			this.lightThemeRadioButton = new System.Windows.Forms.RadioButton();
			this.darkThemeRadioButton = new System.Windows.Forms.RadioButton();
			this.themeLabel = new System.Windows.Forms.Label();
			this.applyButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fontSizeUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// fontSizeUpDown
			// 
			this.fontSizeUpDown.Cursor = System.Windows.Forms.Cursors.No;
			this.fontSizeUpDown.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontSizeUpDown.Location = new System.Drawing.Point(68, 12);
			this.fontSizeUpDown.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
			this.fontSizeUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.fontSizeUpDown.Name = "fontSizeUpDown";
			this.fontSizeUpDown.Size = new System.Drawing.Size(43, 22);
			this.fontSizeUpDown.TabIndex = 0;
			this.fontSizeUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// fontSizeLabel
			// 
			this.fontSizeLabel.AutoSize = true;
			this.fontSizeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontSizeLabel.Location = new System.Drawing.Point(8, 14);
			this.fontSizeLabel.Name = "fontSizeLabel";
			this.fontSizeLabel.Size = new System.Drawing.Size(54, 13);
			this.fontSizeLabel.TabIndex = 1;
			this.fontSizeLabel.Text = "Font Size";
			// 
			// lightThemeRadioButton
			// 
			this.lightThemeRadioButton.AutoSize = true;
			this.lightThemeRadioButton.Checked = true;
			this.lightThemeRadioButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lightThemeRadioButton.Location = new System.Drawing.Point(10, 62);
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
			this.darkThemeRadioButton.Location = new System.Drawing.Point(10, 85);
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
			this.themeLabel.Location = new System.Drawing.Point(8, 46);
			this.themeLabel.Name = "themeLabel";
			this.themeLabel.Size = new System.Drawing.Size(41, 13);
			this.themeLabel.TabIndex = 4;
			this.themeLabel.Text = "Theme";
			// 
			// applyButton
			// 
			this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.applyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applyButton.Location = new System.Drawing.Point(10, 135);
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
			this.cancelButton.Location = new System.Drawing.Point(192, 135);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(97, 31);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// SettingsWindow
			// 
			this.AcceptButton = this.applyButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(301, 178);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.themeLabel);
			this.Controls.Add(this.darkThemeRadioButton);
			this.Controls.Add(this.lightThemeRadioButton);
			this.Controls.Add(this.fontSizeLabel);
			this.Controls.Add(this.fontSizeUpDown);
			this.MinimumSize = new System.Drawing.Size(250, 200);
			this.Name = "SettingsWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tinyinfo Settings";
			((System.ComponentModel.ISupportInitialize)(this.fontSizeUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown fontSizeUpDown;
		private System.Windows.Forms.Label fontSizeLabel;
		private System.Windows.Forms.RadioButton lightThemeRadioButton;
		private System.Windows.Forms.RadioButton darkThemeRadioButton;
		private System.Windows.Forms.Label themeLabel;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Button cancelButton;
	}
}