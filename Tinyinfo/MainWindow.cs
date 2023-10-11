using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Hardware.Info;

namespace Tinyinfo
{
	public partial class MainWindow : Form
	{
		static readonly IHardwareInfo hardwareInfo = new HardwareInfo();
		private delegate void SafeCallDelegate(string text);
		public MainWindow()
		{
			InitializeComponent();
		}

		//	Thread for updating info in background
		Thread thread;

		//	Runs on form load
		//
		//	This solution is pretty bad but it works.
		public void startup(object sender, EventArgs e)
		{
			var nl = Environment.NewLine;
			//	Refresh lists
			hardwareInfo.RefreshCPUList(true);
			hardwareInfo.RefreshMemoryList();
			hardwareInfo.RefreshBIOSList();
			hardwareInfo.RefreshMotherboardList();
			hardwareInfo.RefreshVideoControllerList();

			foreach (var cpu in hardwareInfo.CpuList)
			{
				//	CPU Info
				WriteTextSafe("CPU:" + nl);

				//	CPU ID
				AppendTextSafe("\tID: " + cpu.ProcessorId + nl);

				//	Manufacturer and Model
				AppendTextSafe("\tManufacturer: " + cpu.Manufacturer + nl);
				AppendTextSafe("\tModel: " + cpu.Name.Replace("  ", "") + nl);

				// Description
				AppendTextSafe("\tDescription: " + cpu.Description + nl);

				//	Socket
				AppendTextSafe("\tSocket: " + cpu.SocketDesignation + nl);

				//	Cores and Threads
				AppendTextSafe("\tCore Amount: " + cpu.NumberOfCores + " Physical, " + cpu.NumberOfLogicalProcessors + " Logical" + nl);

				//	VM Firmware
				AppendTextSafe("\tVirtualization Firmware Enabled: " + cpu.VirtualizationFirmwareEnabled + nl);


				//	Clockspeeds
				AppendTextSafe("\tClockspeeds:" + nl);
				//	Current Clockspeed in mHz
				AppendTextSafe("\t\t" + cpu.CurrentClockSpeed + "mHz Current" + nl);
				//	Base Clockspeed in mHz
				AppendTextSafe("\t\t" + cpu.MaxClockSpeed + "mHz Base");
			}

			//	Graphics
			AppendTextSafe(nl + "Video: ");
			//	Create GPU ID
			int id = 0;
			foreach (var gpu in hardwareInfo.VideoControllerList)
			{
				//	GPU ID
				AppendTextSafe(nl + "\tGPU " + id + ":" + nl);

				//	Name
				AppendTextSafe("\t\tName: " + gpu.Name + nl);

				//	Manufacturer
				AppendTextSafe("\t\tManufacturer: " + gpu.Manufacturer + nl);
				
				//	Increment GPU ID
				id++;
			}

			//	Memory
			AppendTextSafe(nl + "Memory:");
			foreach (var memory in hardwareInfo.MemoryList)
			{
				//	Write capacity into float and convert to GB
				float memsize = memory.Capacity;
				memsize /= 1073741824;

				//	Bank number
				AppendTextSafe(nl + "\t" + memory.BankLabel + ":" + nl);

				//	Manufacturer
				AppendTextSafe("\t\tManufacturer: " + memory.Manufacturer + nl);

				//	Size
				AppendTextSafe("\t\t\tSize: " + memsize + "GB" + nl);

				//	Speed
				AppendTextSafe("\t\t\tSpeed: " + memory.Speed + "mT/s" + nl);

				//	Part Number
				AppendTextSafe("\t\t\tPart No.: " + memory.PartNumber + nl);

				//	Form Factor
				AppendTextSafe("\t\t\tForm Factor: " + memory.FormFactor + nl);

				//	Minimum Voltage
				AppendTextSafe("\t\t\tMin. Voltage: " + memory.MinVoltage + "mV" + nl);

				//	Maximum voltage
				AppendTextSafe("\t\t\tMax. Voltage: " + memory.MaxVoltage + "mV");
			}

			//	Motherboard
			foreach (var motherboard in hardwareInfo.MotherboardList)
			{
				AppendTextSafe(nl + "Motherboard: " + nl);
				//	Manufacturer
				AppendTextSafe("\tManufacturer: " + motherboard.Manufacturer + nl);
				//	Model
				AppendTextSafe("\tModel: " + motherboard.Product + nl);
				//	Serial Number
				AppendTextSafe("\tSerial No.: " + motherboard.SerialNumber);
			}

			//	BIOS Info
			foreach (var bios in hardwareInfo.BiosList)
			{
				AppendTextSafe(nl + "BIOS: " + nl);
				//	Manufacturer
				AppendTextSafe("\tManufacturer: " + bios.Manufacturer + nl);
				//	Name
				AppendTextSafe("\tName: " + bios.Name + nl);
				//	Version
				AppendTextSafe("\tVersion: " + bios.Version + nl);
				//	Release Date
				AppendTextSafe("\tRelease Date: " + bios.ReleaseDate + nl);
			}
		}

		//	TODO: Put CPU info in separate thread for improved speed

		//	collect system info and write to textBox1
		public void getdata()
		{
			var nl = Environment.NewLine;
			while (true)
			{
				//	Refresh lists
				hardwareInfo.RefreshCPUList(true);
				hardwareInfo.RefreshMemoryList();
				hardwareInfo.RefreshBIOSList();
				hardwareInfo.RefreshMotherboardList();
			
				foreach (var cpu in hardwareInfo.CpuList)
				{
					//	CPU Info
					WriteTextSafe("CPU:" + nl);
					
					//	CPU ID
					AppendTextSafe("\tID: " + cpu.ProcessorId + nl);

					//	Manufacturer and Model
					AppendTextSafe("\tManufacturer: " + cpu.Manufacturer + nl);
					AppendTextSafe("\tModel: " + cpu.Name.Replace("  ", "") + nl);

					// Description
					AppendTextSafe("\tDescription: " + cpu.Description + nl);

					//	Socket
					AppendTextSafe("\tSocket: " + cpu.SocketDesignation + nl);

					//	Cores and Threads
					AppendTextSafe("\tCore Amount: " + cpu.NumberOfCores + " Physical, " + cpu.NumberOfLogicalProcessors + " Logical" + nl);

					//	VM Firmware
					AppendTextSafe("\tVirtualization Firmware Enabled: " + cpu.VirtualizationFirmwareEnabled + nl);


					//	Clockspeeds
					AppendTextSafe("\tClockspeeds:" + nl);
					//	Current Clockspeed in mHz
					AppendTextSafe("\t\t" + cpu.CurrentClockSpeed + "mHz Current" + nl);
					//	Base Clockspeed in mHz
					AppendTextSafe("\t\t" + cpu.MaxClockSpeed +"mHz Base");
					
					//	Memory
					AppendTextSafe(nl + nl + "Memory:");
					foreach (var memory in hardwareInfo.MemoryList)
					{
						//	Write capacity into float and convert to GB
						float memsize = memory.Capacity;
						memsize /= 1073741824;

						//	Bank number
						AppendTextSafe(nl + "\t" + memory.BankLabel + ":" + nl);

						//	Manufacturer
						AppendTextSafe("\t\tManufacturer: " + memory.Manufacturer + nl);

						//	Size
						AppendTextSafe("\t\t\tSize: " + memsize + "GB" + nl);

						//	Speed
						AppendTextSafe("\t\t\tSpeed: " + memory.Speed + "mT/s" + nl);

						//	Part Number
						AppendTextSafe("\t\t\tPart No.: " + memory.PartNumber + nl);

						//	Form Factor
						AppendTextSafe("\t\t\tForm Factor: " + memory.FormFactor + nl);

						//	Minimum Voltage
						AppendTextSafe("\t\t\tMin. Voltage: " + memory.MinVoltage + "mV" + nl);

						//	Maximum voltage
						AppendTextSafe("\t\t\tMax. Voltage: " + memory.MaxVoltage + "mV");
					}

					//	Motherboard
					foreach (var motherboard in hardwareInfo.MotherboardList)
					{
						AppendTextSafe(nl + "Motherboard: " + nl);
						//	Manufacturer
						AppendTextSafe("\tManufacturer: " + motherboard.Manufacturer + nl);
						//	Model
						AppendTextSafe("\tModel: " + motherboard.Product + nl);
						//	Serial Number
						AppendTextSafe("\tSerial No.: " + motherboard.SerialNumber);
					}

					//	BIOS Info
					foreach (var bios in hardwareInfo.BiosList)
					{
						AppendTextSafe(nl + "BIOS: " + nl);
						//	Manufacturer
						AppendTextSafe("\tManufacturer: " + bios.Manufacturer + nl);
						//	Name
						AppendTextSafe("\tName: " + bios.Name + nl);
						//	Version
						AppendTextSafe("\tVersion: " + bios.Version + nl);
						//	Release Date
						AppendTextSafe("\tRelease Date: " + bios.ReleaseDate + nl);
					}
				}
			}
		}
		

		//	Safely overwrites text in textBox1
		private void WriteTextSafe(string text)
		{
			if (textBox1.InvokeRequired)
			{
				var d = new SafeCallDelegate(WriteTextSafe);
				textBox1.Invoke(d, new object[] { text });
			}
			else
			{
				textBox1.Text = text;
			}
		}

		//	Safely appends text in textBox1
		private void AppendTextSafe(string text)
		{
			if (textBox1.InvokeRequired)
			{
				var d = new SafeCallDelegate(AppendTextSafe);
				textBox1.Invoke(d, new object[] { text });
			}
			else
			{
				textBox1.AppendText(text);
			}
		}

		//	Starts thread, changes button states, update info text and increments progress bar
		public void loadInfo()
		{
			label1.Visible = true;
			progressBar1.Visible = true;
			button1.Enabled = false;
			label1.Text = "Loading System Info.";
			progressBar1.Value = 25;
			hardwareInfo.RefreshCPUList();
			button2.Enabled = true;
			label1.Text = "Loading System Info..";
			progressBar1.Value = 50;
			hardwareInfo.RefreshOperatingSystem();
			button3.Enabled = true;
			label1.Text = "Loading System Info...";
			progressBar1.Value = 75;
			thread = new Thread(new ThreadStart(getdata));
			progressBar1.Value = 85;
			thread.IsBackground = true;
			label1.Text = "Loading System Info....";
			progressBar1.Value = 100;
			label1.Visible = false;
			thread.Start();
			progressBar1.Visible = false;
		}

		//	Stop update thread
		public void stopUpdate()
		{
			button3.Enabled = false;
			thread.Abort();
			button2.Enabled = false;
			button1.Enabled = true;
		}

		//	Load System info when Start Button is pressed
		public void button1_Click(object sender, EventArgs e)
		{
			loadInfo();
		}

		//	Change Button state and abort thread when Stop Button is pressed
		private void button2_Click(object sender, EventArgs e)
		{
			stopUpdate();
		}

		//	Start/Stop thread when Play/Pause button is pressed. not used as of v1.4
		private void button3_Click(object sender, EventArgs e)
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
	}
}
