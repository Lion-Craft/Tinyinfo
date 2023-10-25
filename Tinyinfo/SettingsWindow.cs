using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace Tinyinfo
{
	public partial class SettingsWindow : Form
	{
		public SettingsWindow()
		{
			InitializeComponent();

			//	apply saved theme
			refreshTheme();

			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");

			//	load saved theme setting
			if (data.GetKey("tinyinfo.theme") == "light")
			{
				//	light theme
				lightThemeRadioButton.Checked = true;
				darkThemeRadioButton.Checked = false;
				this.BackColor = Color.White;
				this.ForeColor = Color.Black;
				themeTab.BackColor = Color.White;
				themeTab.ForeColor = Color.Black;
				generalTab.BackColor = Color.White;
				generalTab.ForeColor = Color.Black;
				fontButton.ForeColor = Color.Black;
				applyButton.ForeColor = Color.Black;
				cancelButton.ForeColor = Color.Black;

			}
			else
			{
				//	dark theme
				lightThemeRadioButton.Checked = false;
				darkThemeRadioButton.Checked = true;
				ActiveForm.BackColor = Color.Gray;
				ActiveForm.ForeColor = Color.White;
				themeTab.BackColor = Color.DimGray;
				themeTab.ForeColor = Color.White;
				generalTab.BackColor = Color.DimGray;
				generalTab.ForeColor = Color.White;
				fontButton.ForeColor = Color.Black;
				applyButton.ForeColor = Color.Black;
				cancelButton.ForeColor = Color.Black;
			}

			//	load refresh rate setting
			refreshRateUpDown.Value = Convert.ToInt32(data.GetKey("tinyinfo.refresh"));

			//	load font
			FontStyle fontStyle;
			string savedStyle = data.GetKey("tinyinfo.fontstyle");
			switch (savedStyle)
			{
				default:
					fontStyle = FontStyle.Regular;
					break;
				case "FontStyle.Bold":
					fontStyle = FontStyle.Bold;
					break;
				case "FontStyle.Italic":
					fontStyle = FontStyle.Italic;
					break;
				case "FontStyle.Strikeout":
					fontStyle = FontStyle.Strikeout;
					break;
				case "FontStyle.Underline":
					fontStyle= FontStyle.Underline;
					break;
			}
			Font font = new Font(data.GetKey("tinyinfo.fontname"), Convert.ToInt32(data.GetKey("tinyinfo.fontsize")), fontStyle);

			fontDialog.Font = font;
			ActiveForm.Font = font;
			fontButton.Font = font;
			settingTabs.Font = font;
			themeLabel.Font = font;
			themeTab.Font = font;
			applyButton.Font = font;
			cancelButton.Font = font;
			lightThemeRadioButton.Font = font;
			darkThemeRadioButton.Font = font;
			refreshRateLabel.Font = font;
			refreshRateUpDown.Font = font;
		}

		public void refreshTheme()
		{
			//	Check if file exists, if it doesnt create it with default settings
			if (File.Exists("./tinyinfo.ini") == false)
			{
				File.WriteAllText("./tinyinfo.ini", "[tinyinfo]\ntheme=light\nrefresh=500\nfontsize=10\nfontname=Segoe UI\nfontstyle=FontStyle.Regular");
			}

			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");

			//	Read Settings
			//	Set theme
			if (data.GetKey("tinyinfo.theme") == "dark")
			{
				//	Dark theme
				ForeColor = Color.White;
				BackColor = Color.Gray;
				themeTab.BackColor = Color.DimGray;
				themeTab.ForeColor = Color.White;
				generalTab.BackColor = Color.DimGray;
				generalTab.ForeColor = Color.White;
				fontButton.ForeColor = Color.Black;
				applyButton.ForeColor = Color.Black;
				cancelButton.ForeColor = Color.Black;
			}
			else
			{
				//	Light theme
				ForeColor = Color.Black;
				BackColor = Color.White;
				themeTab.BackColor = Color.White;
				themeTab.ForeColor = Color.Black;
				generalTab.BackColor = Color.White;
				generalTab.ForeColor = Color.Black;
				fontButton.ForeColor = Color.Black;
				applyButton.ForeColor = Color.Black;
				cancelButton.ForeColor = Color.Black;
			}
		}

		private void applyButton_Click(object sender, EventArgs e)
		{
			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");

			//	write theme mode into ini
			if (lightThemeRadioButton.Checked)
			{
				//	light mode
				data["tinyinfo"]["theme"] = "light";
				parser.WriteFile("./tinyinfo.ini", data);
			}
			else
			{
				//	dark mode
				data["tinyinfo"]["theme"] = "dark";
				parser.WriteFile("./tinyinfo.ini", data);
			}

			//	wrire refresh rate into ini file
			data["tinyinfo"]["refresh"] = refreshRateUpDown.Value.ToString();
			parser.WriteFile("./tinyinfo.ini", data);

			//	reload theme
			refreshTheme();
		}

		private void fontButton_Click(object sender, EventArgs e)
		{
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");

			if (fontDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			data["tinyinfo"]["fontname"] = fontDialog.Font.Name.ToString();
			parser.WriteFile("./tinyinfo.ini", data);
			data["tinyinfo"]["fontsize"] = Math.Round(fontDialog.Font.SizeInPoints, 0).ToString();
			parser.WriteFile("./tinyinfo.ini", data);
			data["tinyinfo"]["fontstyle"] = fontDialog.Font.Style.ToString();
			parser.WriteFile("./tinyinfo.ini", data);

			//	Apply font changes.
			FontStyle fontStyle;
			string savedStyle = data.GetKey("tinyinfo.fontstyle");
			switch (savedStyle)
			{
				default:
					fontStyle = FontStyle.Regular;
					break;
				case "FontStyle.Bold":
					fontStyle = FontStyle.Bold;
					break;
				case "FontStyle.Italic":
					fontStyle = FontStyle.Italic;
					break;
				case "FontStyle.Strikeout":
					fontStyle = FontStyle.Strikeout;
					break;
				case "FontStyle.Underline":
					fontStyle= FontStyle.Underline;
					break;
			}
			Font font = new Font(data.GetKey("tinyinfo.fontname"), Convert.ToInt32(data.GetKey("tinyinfo.fontsize")), fontStyle);
			ActiveForm.Font = font;
			fontButton.Font = font;
			settingTabs.Font = font;
			themeLabel.Font = font;
			themeTab.Font = font;
			applyButton.Font = font;
			cancelButton.Font = font;
			lightThemeRadioButton.Font = font;
			darkThemeRadioButton.Font = font;
			refreshRateLabel.Font = font;
			refreshRateUpDown.Font = font;
			refreshRateUpDown.Location = new Point(refreshRateUpDown.Location.X + Convert.ToInt32(font.Size) * 10, refreshRateUpDown.Location.Y);
		}
	}
}
