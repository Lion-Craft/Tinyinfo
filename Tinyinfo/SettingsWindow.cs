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
				radioButton1.Checked = true;
				radioButton2.Checked = false;
				this.BackColor = Color.White;
				this.ForeColor = Color.Black;
				button1.ForeColor = Color.Black;
				button2.ForeColor = Color.Black;
				
			}
			else
			{
				//	dark theme
				radioButton1.Checked = false;
				radioButton2.Checked = true;
				ActiveForm.BackColor = Color.Black;
				ActiveForm.ForeColor = Color.White;
				button1.ForeColor = Color.Black;
				button2.ForeColor = Color.Black;
			}

			//	load font size setting
			numericUpDown1.Value = Convert.ToInt32(data.GetKey("tinyinfo.font"));
		}

		public void refreshTheme()
		{
			//	Check if file exists, if it doesnt create it with default settings
			if (File.Exists("./tinyinfo.ini") == false)
			{
				File.WriteAllText("./tinyinfo.ini", "[tinyinfo]\ntheme=light\nfont=10");
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
				BackColor = Color.Black;
				button1.ForeColor = Color.Black;
				button2.ForeColor = Color.Black;
			}
			else
			{
				//	Light theme
				ForeColor = Color.Black;
				BackColor = Color.White;
				button1.ForeColor = Color.Black;
				button2.ForeColor = Color.Black;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");

			//	write theme mode into ini
			if (radioButton1.Checked)
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

			//	write font size into ini file
			data["tinyinfo"]["font"] = numericUpDown1.Value.ToString();
			parser.WriteFile("./tinyinfo.ini", data);

			//	reload theme
			refreshTheme();
		}
	}
}
