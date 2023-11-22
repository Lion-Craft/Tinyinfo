using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using IniParser;
using IniParser.Model;

namespace Tinyinfo
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();

			SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.LightSteelBlue;
			this.TransparencyKey = this.BackColor;

			//	Check if file exists, if it doesnt create it with default settings
			if (File.Exists("./tinyinfo.ini") == false)
			{
				File.WriteAllText("./tinyinfo.ini", "[tinyinfo]\ntheme=light\nrefresh=500\nfontsize=10\nfontname=Segoe UI\nfontstyle=Regular\ntransparentsplash=false");
			}

			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");

			//	See if keys new to v3 exist, if not overwrite file with default settings
			if (data.GetKey("tinyinfo.refresh") == null || data.GetKey("tinyinfo.fontsize") == null || data.GetKey("tinyinfo.fontname") == null || data.GetKey("tinyinfo.fontstyle") == null || data.GetKey("tinyinfo.transparentsplash") == null)
			{
				File.WriteAllText("./tinyinfo.ini", "[tinyinfo]\ntheme=light\nrefresh=500\nfontsize=10\nfontname=Segoe UI\nfontstyle=Regular\ntransparentsplash=false");
			}

			//	Read theme setting
			string theme = data.GetKey("tinyinfo.theme").ToLower();
			string transparent = data.GetKey("tinyinfo.transparentsplash").ToLower();

			//	Choose splash according to theme
			if (theme == "dark")
			{
				if (transparent == "true")
				{
					splashPictureBox.Image= Image.FromFile("./img/splash/splash_transparent.png");
				}
				else
				{
					splashPictureBox.Image = Image.FromFile("./img/splash/splash_dark.png");
				}
				splashPictureBox.Refresh();
			}
			else if (theme == "light")
			{
				if (transparent == "true")
				{
					splashPictureBox.Image = Image.FromFile("./img/splash/splash_transparent_white.png");
				}
				else
				{
					splashPictureBox.Image = Image.FromFile("./img/splash/splash.png");
				}
				splashPictureBox.Refresh();
			}
		}
	}
}
