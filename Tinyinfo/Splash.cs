using System;
using System.Drawing;
using System.Windows.Forms;
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

			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");
			
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
