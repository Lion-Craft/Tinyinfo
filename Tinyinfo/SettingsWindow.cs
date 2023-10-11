using System;
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

			//	check if configuration ini exists
			if (File.Exists("./tinyinfo.ini") == false)
			{
				//	if tinyinfo.ini does not exist create it
				File.WriteAllText("./tinyinfo.ini", "[tinyinfo]\ntheme=light\nfont=10");
			}

			// var parser = new FileIniDataParser();
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
		}
	}
}
