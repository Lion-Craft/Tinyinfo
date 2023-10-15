using System;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Hardware.Info;
using static System.Net.Mime.MediaTypeNames;
using IniParser;
using IniParser.Model;

namespace Tinyinfo
{
	public partial class MainWindow : Form
	{
		static readonly IHardwareInfo hardwareInfo = new HardwareInfo();
		private delegate void SafeCallDelegate(string text);
		public MainWindow()
		{
			InitializeComponent();

			//	Load Theme
			refreshTheme();			
		}

		//	Thread for updating info in background
		Thread thread;

		//	Runs on form load
		public void startup(object sender, EventArgs e)
		{
			//	Create Thread on start
			thread = new Thread(() => getdata(true));

			//	Get info on load
			getdata(false);
		}

		//	TODO: Put CPU info in separate thread for improved speed

		//	collect system info and write to textBox1
		public void getdata(bool loop)
		{
			var nl = Environment.NewLine;
			do
			{
				//	Refresh lists
				hardwareInfo.RefreshCPUList(true);
				hardwareInfo.RefreshMemoryList();
				hardwareInfo.RefreshBIOSList();
				hardwareInfo.RefreshMotherboardList();
				hardwareInfo.RefreshVideoControllerList();
				hardwareInfo.RefreshBatteryList();
				hardwareInfo.RefreshDriveList();
				hardwareInfo.RefreshNetworkAdapterList();

				//	CPU Info
				foreach (var cpu in hardwareInfo.CpuList)
				{
					//	CPU ID
					WriteTextSafe("ID: " + cpu.ProcessorId + nl);
					treeItem = "cpu.id";
					ShowInfo("");

					//	Manufacturer
					WriteTextSafe("Manufacturer: " + cpu.Manufacturer + nl);
					treeItem = "cpu.manufacturer";
					ShowInfo("");

					//	Model
					WriteTextSafe("Model: " + cpu.Name.Replace("  ", "") + nl);
					treeItem = "cpu.model";
					ShowInfo("");

					// Description
					WriteTextSafe("Description: " + cpu.Description + nl);
					treeItem = "cpu.description";
					ShowInfo("");

					//	Socket
					WriteTextSafe("Socket: " + cpu.SocketDesignation + nl);
					treeItem = "cpu.socket";
					ShowInfo("");

					//	Cores and Threads
					WriteTextSafe("Core Amount: " + cpu.NumberOfCores + " Physical, " + cpu.NumberOfLogicalProcessors + " Logical" + nl);
					treeItem = "cpu.cores";
					ShowInfo("");

					//	VM Firmware
					WriteTextSafe("Virtualization Firmware Enabled: " + cpu.VirtualizationFirmwareEnabled + nl);
					treeItem = "cpu.vmx";
					ShowInfo("");

					//	Current Clockspeed in mHz
					WriteTextSafe("Current Clockspeed:" + cpu.CurrentClockSpeed + "mHz" + nl);
					treeItem = "cpu.speed.current";
					ShowInfo("");
					//	Base Clockspeed in mHz
					WriteTextSafe("Base Clockspeed:" + cpu.MaxClockSpeed + "mHz");
					treeItem = "cpu.speed.base";
					ShowInfo("");

					//	Graphics
					WriteTextSafe(nl + "Video: ");
					//	Create GPU ID
					int id = 0;
					foreach (var gpu in hardwareInfo.VideoControllerList)
					{
						//	Write capacity into float and convert to GB
						float vmemsize = gpu.AdapterRAM;
						vmemsize /= 1073741824;

						//	GPU ID
						WriteTextSafe(nl + "\tGPU " + id + ":" + nl);
						treeItem = "gpu.id";
						ShowInfo("");
						//	Name
						WriteTextSafe("\t\tName: " + gpu.Name + nl);

						//	Manufacturer
						WriteTextSafe("\t\tManufacturer: " + gpu.Manufacturer + nl);

						//	Description
						WriteTextSafe("\t\tDescription: " + gpu.VideoProcessor + nl);

						//	Video mode
						WriteTextSafe("\t\tVideo Mode: " + gpu.VideoModeDescription + " x " + gpu.CurrentRefreshRate + "Hz x " + gpu.CurrentBitsPerPixel + " Bit" + nl);

						//	Video memory amount
						WriteTextSafe("\t\tVRAM Amount: " + vmemsize + "GB" + nl);

						//	Maximum Refresh rate
						WriteTextSafe("\t\tMaximum Refresh Rate: " + gpu.MaxRefreshRate + "Hz" + nl);

						//	Minimum Refresh rate
						WriteTextSafe("\t\tMinimum Refresh Rate: " + gpu.MinRefreshRate + "Hz " + nl);

						//	Driver
						WriteTextSafe("\t\tDriver: " + nl);

						//	Driver Version
						WriteTextSafe("\t\t\tVersion: " + gpu.DriverVersion + nl);

						//	Driver Date
						WriteTextSafe("\t\t\tDate: " + gpu.DriverDate);

						//	Increment GPU ID
						id++;
					}

					//	Memory
					WriteTextSafe(nl + "Memory:");
					foreach (var memory in hardwareInfo.MemoryList)
					{
						//	Write capacity into float and convert to GB
						float memsize = memory.Capacity;
						memsize /= 1073741824;

						//	Bank number
						WriteTextSafe(nl + "\t" + memory.BankLabel + ":" + nl);

						//	Manufacturer
						WriteTextSafe("\t\tManufacturer: " + memory.Manufacturer + nl);

						//	Size
						WriteTextSafe("\t\t\tSize: " + memsize + "GB" + nl);

						//	Speed
						WriteTextSafe("\t\t\tSpeed: " + memory.Speed + "mT/s" + nl);

						//	Part Number
						WriteTextSafe("\t\t\tPart No.: " + memory.PartNumber + nl);

						//	Form Factor
						WriteTextSafe("\t\t\tForm Factor: " + memory.FormFactor + nl);

						//	Minimum Voltage
						WriteTextSafe("\t\t\tMin. Voltage: " + memory.MinVoltage + "mV" + nl);

						//	Maximum voltage
						WriteTextSafe("\t\t\tMax. Voltage: " + memory.MaxVoltage + "mV");
					}

					//	Motherboard
					WriteTextSafe(nl + "Motherboard: " + nl);
					foreach (var motherboard in hardwareInfo.MotherboardList)
					{
						//	Manufacturer
						WriteTextSafe("\tManufacturer: " + motherboard.Manufacturer + nl);
						//	Model
						WriteTextSafe("\tModel: " + motherboard.Product + nl);
						//	Serial Number
						WriteTextSafe("\tSerial No.: " + motherboard.SerialNumber);
					}

					//	BIOS Info
					WriteTextSafe(nl + "BIOS: " + nl);
					foreach (var bios in hardwareInfo.BiosList)
					{
						//	Manufacturer
						WriteTextSafe("\tManufacturer: " + bios.Manufacturer + nl);
						//	Name
						WriteTextSafe("\tName: " + bios.Name + nl);
						//	Version
						WriteTextSafe("\tVersion: " + bios.Version + nl);
						//	Release Date
						WriteTextSafe("\tRelease Date: " + bios.ReleaseDate);
					}

					//	Battery Info
					WriteTextSafe(nl + "Battery: " + nl);
					foreach (var battery in hardwareInfo.BatteryList)
					{
						//	Status
						WriteTextSafe("\tStatus: " + battery.BatteryStatus + nl);
						//	Status Description
						WriteTextSafe("\tStatus Description: " + battery.BatteryStatusDescription + nl);
						//	Battery Percentage
						WriteTextSafe("\tBattery Percentage: " + battery.EstimatedChargeRemaining + "%" + nl);
						//	Time remaining
						WriteTextSafe("\tTime remaining: " + battery.EstimatedRunTime + " Minutes"+ nl);
						//	Expected Life
						WriteTextSafe("\tExpected Life: " + battery.ExpectedLife + nl);
						//	Time to Charge
						WriteTextSafe("\tTime until fully charged: " + battery.TimeToFullCharge + nl);
						//	Time on Battery
						WriteTextSafe("\tTime on Battery: " + battery.TimeOnBattery + nl);
						//	Capacities
						WriteTextSafe("\tCapacities: " + nl);
						//	Design Capacity
						WriteTextSafe("\t\tDesign Capacity: " + battery.DesignCapacity + nl);
						//	Current Capaity
						WriteTextSafe("\t\tFull Charge Capacity: " + battery.FullChargeCapacity + nl);
					}

					//	Drive Info
					WriteTextSafe("Drives: " + nl);
					foreach(var drive in hardwareInfo.DriveList)
					{
						//	Write capacity into float and convert to GB
						float disksize = drive.Size;
						disksize /= 1073741824;

						//	Index
						WriteTextSafe("\tDrive " + drive.Index + ":" + nl);
						//	Name
						WriteTextSafe("\t\tName: " + drive.Name + nl);
						//	Size
						WriteTextSafe("\t\tSize: " + disksize + "GB" + nl);
						//	Manufacturer
						WriteTextSafe("\t\tManufacturer: " + drive.Manufacturer + nl);
						//	Model
						WriteTextSafe("\t\tModel: " + drive.Model + nl);
						//	Firmware
						WriteTextSafe("\t\tFirmware Revision: " + drive.FirmwareRevision + nl);
						//	Serial Number
						WriteTextSafe("\t\tSerial No.: " + drive.SerialNumber + nl);
						//	Partition Count
						WriteTextSafe("\t\tPartition Count: " + drive.Partitions);
					}

					//	Network Adapter Info
					WriteTextSafe(nl + "Network Adapter: ");
					//	Create Network Adapter ID
					int netadaptid = 0;
					foreach (var netadapt in hardwareInfo.NetworkAdapterList)
					{
						//	NIC ID
						WriteTextSafe(nl + "\tNIC " +  netadaptid + ":" + nl);
						//	Name
						WriteTextSafe("\t\tName: " + netadapt.Name + nl);
						//	Product Name
						WriteTextSafe("\t\tProduct Name: " + netadapt.ProductName + nl);
						//	Adapter Type
						WriteTextSafe("\t\tType: " + netadapt.NetConnectionID + nl);
						//	Manufacturer
						WriteTextSafe("\t\tManufacturer: " + netadapt.Manufacturer + nl);
						//	MAC Adress
						WriteTextSafe("\t\tMAC Adress: " + netadapt.MACAddress + nl);
						//	Bytes sent per Second
						WriteTextSafe("\t\tBytes sent per Second: " + netadapt.BytesSentPersec + nl);
						//	Bytes recieved per Second
						WriteTextSafe("\t\tBytes recieved per Second: " + netadapt.BytesReceivedPersec);

						netadaptid++;
					}
				}

				ShowInfo("");

			} while (loop);
		}

		// Safely Overwrite on textbox content
		private void ShowInfo(string text)
		{
            if (outputBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(ShowInfo);
                outputBox.Invoke(d,new object[] { InfoTextBuffer });
            }
            else
            {
                outputBox.Text = InfoTextBuffer;
            }
			if (outputTree.InvokeRequired)
			{
				var d = new SafeCallDelegate(ShowInfo);
				outputTree.Invoke(d, new object[] { InfoTextBuffer });
			}
			else
			{
				ChangeChildNodeText(treeItem, InfoTextBuffer);
			}

		}

		//	Change Child Node's Text 
		//	This currently is rediciolously slow.
		//	TODO: Make faster
		private void ChangeChildNodeText(string node, string text)
		{
			// Find the cpu node
			TreeNode cpuNode = outputTree.Nodes["CpuNode"];
			// Find the video node
			TreeNode gpuNode = outputTree.Nodes["VideoNode"];
			switch (node)
			{
				case "cpu.id":
					// Find the id child node under "cpu" and change its text
					TreeNode cpuIdNode = cpuNode.Nodes["CpuIdNode"];
					cpuIdNode.Text = text;
					break;
				case "cpu.model":
					// Find the id child node under "cpu" and change its text
					TreeNode cpuModelNode = cpuNode.Nodes["CpuModelNode"];
					cpuModelNode.Text = text;
					break;
				case "cpu.cores":
					// Find the name child node under "cpu" and change its text
					TreeNode cpuCoresNode = cpuNode.Nodes["CpuCoresNode"];
					cpuCoresNode.Text = text;
					break;
				case "cpu.manufacturer":
					// Find the manufacturer child node under "cpu" and change its text
					TreeNode cpuManuNode = cpuNode.Nodes["CpuManuNode"];
					cpuManuNode.Text = text;
					break;
				case "cpu.description":
					// Find the description child node under "cpu" and change its text
					TreeNode cpuDescriptionNode = cpuNode.Nodes["CpuDescNode"];
					cpuDescriptionNode.Text = text;
					break;
				case "cpu.socket":
					// Find the description child node under "cpu" and change its text
					TreeNode cpuSocketNode = cpuNode.Nodes["CpuSocketNode"];
					cpuSocketNode.Text = text;
					break;
				case "cpu.vmx":
					// Find the VMX child node under "cpu" and change its text
					TreeNode cpuVmxNode = cpuNode.Nodes["CpuVmxNode"];
					cpuVmxNode.Text = text;
					break;
				case "cpu.speed.base":
					// Find the base clock child node under "cpu" and change its text
					TreeNode cpuBaseNode = cpuNode.Nodes["CpuBaseNode"];
					cpuBaseNode.Text = text;
					break;
				case "cpu.speed.current":
					// Find the current clock child node under "cpu" and change its text
					TreeNode cpuCurrentNode = cpuNode.Nodes["CpuClockNode"];
					cpuCurrentNode.Text = text;
					break;
				case "gpu.id":
					TreeNode gpuIdNode = gpuNode.Nodes["GpuIdNode"];
					gpuIdNode.Text = text;
					break;
				case "gpu.name":
					// Find the "name" child node under "gpu" and change its text
					TreeNode gpuNameNode = gpuNode.Nodes["GpuNameNode"];
					gpuNameNode.Text = text;
					break;
				case "gpu.manufacturer":
					// Find the "manufacturer" child node under "gpu" and change its text
					TreeNode gpuManufacturerNode = gpuNode.Nodes["GpuManuNode"];
					gpuManufacturerNode.Text = text;
					break;
			}
		}

		//	Create treeItem string to select node
		private string treeItem = "";

        // Creating String To Push it later on textbox
        private string InfoTextBuffer = "";
		private void WriteTextSafe(string text)
		{
            // NOTE (HOUDAIFA) : Faster Way

            InfoTextBuffer = text;


            return;
		}

		// Appand Text To Text Buffer
		private void AppendTextSafe(string text)
		{
            // NOTE (HOUDAIFA) : Faster Way

			InfoTextBuffer += text;

            return;
		}

		//	Starts thread, changes button states, update info text and increments progress bar
		public void loadInfo()
		{
			infoLabel.Visible = true;
			progressBar.Visible = true;
			startButton.Enabled = false;
			infoLabel.Text = "Loading System Info.";
			progressBar.Value = 25;
			hardwareInfo.RefreshCPUList();
			stopButton.Enabled = true;
			infoLabel.Text = "Loading System Info..";
			progressBar.Value = 50;
			hardwareInfo.RefreshOperatingSystem();
			pauseButton.Enabled = true;
			infoLabel.Text = "Loading System Info...";
			progressBar.Value = 75;
			progressBar.Value = 85;
			thread.IsBackground = true;
			infoLabel.Text = "Loading System Info....";
			progressBar.Value = 100;
			infoLabel.Visible = false;
			thread.Start();
			progressBar.Visible = false;
		}

		//	Stop update thread
		public void stopUpdate()
		{
			if (thread.IsAlive)
			{
				pauseButton.Enabled = false;
				thread.Abort();
				stopButton.Enabled = false;
				startButton.Enabled = true;
			}
		}

		//	Load System info when Start Button is pressed
		public void startButton_Click(object sender, EventArgs e)
		{
			loadInfo();
		}

		//	Change Button state and abort thread when Stop Button is pressed
		private void stopButton_Click(object sender, EventArgs e)
		{
			stopUpdate();
		}

		//	Start/Stop thread when Play/Pause button is pressed. not used as of v1.4
		private void pauseButton_Click(object sender, EventArgs e)
		{
			if (thread.ThreadState == System.Threading.ThreadState.Stopped) {
				thread.Start();
			}
			else
			{
				thread.Abort();
			}
		}

		private void onTopCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (onTopCheckbox.Checked)
			{
				ActiveForm.TopMost = true;
			}
			else
			{
				ActiveForm.TopMost = false;
			}
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
				startButton.ForeColor = Color.Black;
				stopButton.ForeColor = Color.Black;
				pauseButton.ForeColor = Color.Black;
				onTopCheckbox.ForeColor = Color.Black;
				onTopCheckbox.BackColor = Color.Gray;
				onTopBoxPanel.BackColor = Color.FromName("ButtonFace");
				onTopBoxPanel.ForeColor = Color.White;
				outputBox.BackColor = Color.Black;
				outputBox.ForeColor = Color.White;
			}
			else
			{
				//	Light theme
				ForeColor = Color.Black;
				BackColor = Color.White;
				startButton.ForeColor = Color.Black;
				stopButton.ForeColor = Color.Black;
				pauseButton.ForeColor = Color.Black;
				onTopCheckbox.ForeColor = Color.Black;
				onTopCheckbox.BackColor = Color.White;
				onTopBoxPanel.BackColor = Color.White;
				onTopBoxPanel.ForeColor = Color.Black;
				outputBox.BackColor = Color.White;
				outputBox.ForeColor = Color.Black;
			}

			//	Set font size
			var font = new Font("Segoe UI", Convert.ToInt32(data.GetKey("tinyinfo.font")));

			outputBox.Font = font;
		}

		//	Opens Settings Window
		private void settingsItem_Click(object sender, EventArgs e)
		{
			//	Create Settings Window
			var settings = new SettingsWindow();
			settings.ShowDialog();
			//	Reload Theme
			refreshTheme();
		}

		// Export system info to text file
        private void exportItem_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to choose the destination file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            var filePath = saveFileDialog.FileName;

            // Open a StreamWriter to write to the selected file
            using (var writer = new StreamWriter(filePath))
            {
                var outputBoxValue = outputBox.Text;
                writer.WriteLine(outputBoxValue);

            }
        }

        //	Create ShellAbout
        [DllImport("shell32.dll")]
		static extern int ShellAbout(IntPtr hwnd, string szApp, string szOtherStuff, IntPtr hIcon);

		//	Opens ShellAbout Dialog to display version info
		private void aboutItem_Click(object sender, EventArgs e)
		{
			//	Write version to string
			string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			
			//	Create ShellAbout dialog
			ShellAbout(IntPtr.Zero, "Tinyinfo " + version, "Tinyinfo v." + version, Icon.Handle);
		}

		//	Opens GitHub repo in browser
		private void githubItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Lion-Craft/Tinyinfo");
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			stopUpdate();
		}

		private void refreshItem_Click(object sender, EventArgs e)
		{
			//	Refresh system info
			getdata(false);
		}

		private void exitItem_Click(object sender, EventArgs e)
		{
			//	Stop Updating
			stopUpdate();
			//	Exit Tinyinfo
			System.Windows.Forms.Application.Exit();
		}
	}
}
