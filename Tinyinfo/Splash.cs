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

			//	Create ini parser and read ini file
			var parser = new FileIniDataParser();
			IniData data = parser.ReadFile("./tinyinfo.ini");
			
			//	Read theme setting
			string theme = data.GetKey("tinyinfo.theme");

			//	Choose splash according to theme
			if (theme == "dark")
			{
				splashPictureBox.Image = Image.FromFile("./img/splash/splash_dark.png");
				splashPictureBox.Refresh();
			}
			else if (theme == "light")
			{
				splashPictureBox.Image = Image.FromFile("./img/splash/splash.png");
				splashPictureBox.Refresh();
			}
		}
	}
}
