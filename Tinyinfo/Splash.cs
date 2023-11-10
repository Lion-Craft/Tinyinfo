using System.Drawing;
using System.Windows.Forms;

namespace Tinyinfo
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
			splashPictureBox.Image = Image.FromFile("./img/splash/splash.png");
			splashPictureBox.Refresh();
		}
	}
}
