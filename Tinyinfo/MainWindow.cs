using Hardware.Info;
using IniParser;
using IniParser.Model;
using NvAPIWrapper.GPU;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Tinyinfo
{
	public partial class MainWindow : Form
	{
		//	Create Threads
		private Thread thread;
		private Thread cpuThread;
		private Thread batteryThread;
		private Thread netThread;

		private static readonly IHardwareInfo hardwareInfo = new HardwareInfo();

		private delegate void SafeCallDelegate(string text);

		public MainWindow()
		{
			InitializeComponent();
		}

		//	Create Splash
		Form splash = new Splash();

		//	Thread for updating info in background

		/// <summary>
		/// Runs on form load
		/// </summary>
		public void Startup(object sender, EventArgs e)
		{
			//	Load saved Theme settings
			LoadTheme();

			//	Show Splash
			splash.Show();

			//	Create Threads on start
			thread = new Thread(() => Getdata(true));
			cpuThread = new Thread(() => hardwareInfo.RefreshCPUList());
			batteryThread = new Thread(() => hardwareInfo.RefreshBatteryList());
			netThread = new Thread(() => hardwareInfo.RefreshNetworkAdapterList());

			//	Get info on load
			Getdata(false);

			//	Close Splash
			splash.Close();
		}

		/// <summary>
		/// Refreshes minimum amount of hardware info data needed
		/// </summary>
		private void RefreshMinimumHardwareInfo()
		{
			//	TODO: Make better. This entire thing is a mess. What the hell was i thinking.
			//	Check if Thread is alive
			if (cpuThread.IsAlive)
			{
				//	Wait for Thread to finish
				cpuThread.Join();
			}
			else
			{
				//	Start Thread for CPU info
				cpuThread = new Thread(() => hardwareInfo.RefreshCPUList());
				cpuThread.IsBackground = true;
				cpuThread.Start();
			}

			//	Check if Thread is alive
			if (batteryThread.IsAlive)
			{
				//	Wait for Thread to finish
				batteryThread.Join();
			}
			else
			{
				//	Start Thread for Battery info
				batteryThread = new Thread(() => hardwareInfo.RefreshBatteryList());
				batteryThread.IsBackground = true;
				batteryThread.Start();
			}

			//	Check if Thread is alive
			if (netThread.IsAlive)
			{
				//	Wait for Thread to finish
				netThread.Join();
			}
			else
			{
				//	Start Thread for Network info
				netThread = new Thread(() => hardwareInfo.RefreshNetworkAdapterList());
				netThread.IsBackground = false;
				netThread.Start();
			}
		}

		/// <summary>
		/// Refreshes all the hardware info data
		/// </summary>
		private void RefreshAllHardwareInfo()
		{
			//	Update info
			hardwareInfo.RefreshAll();
		}

		//	Set maximum theoretical Refresh rate in ms
		private int maxRefresh = 500;

		/// <summary>
		/// Collect system info and write to textBox1
		/// </summary>
		public void Getdata(bool loop)
		{
			if (loop)
			{
				do
				{
					//	Refresh minimum amount of info needed
					RefreshMinimumHardwareInfo();

					//	CPU Info
					LoadCPUData();

					//	Battery Info
					LoadBatteryData();

					//	Network Adapter Info
					LoadNetworkAdaptersData();

					//	TODO: Make better (This is just bad if were honest)
					Thread.Sleep(maxRefresh);
				} while (loop);
			}
			else
			{
				//	Refresh all hardware info
				RefreshAllHardwareInfo();

				//	CPU Info
				LoadCPUData();

				//	Graphics
				LoadVideoControllerData();

				//	Memory
				LoadMemoryData();

				//	Motherboard
				LoadMotherBoardData();

				//	BIOS Info
				LoadBIOSData();

				//	Battery Info
				LoadBatteryData();

				//	Drive Info
				LoadDrivesData();

				//	Network Adapter Info
				LoadNetworkAdaptersData();

				ShowInfo("");
			}
		}

		/// <summary>
		/// Loads the CPU data and appends it
		/// </summary>
		private void LoadCPUData()
		{
			//	TODO: Put CPU info in separate thread for improved speed

			string nl = Environment.NewLine;

			WriteTextSafe("CPU:" + nl);

			foreach (var cpu in hardwareInfo.CpuList)
			{
				string idInfo = $"\tID: {cpu.ProcessorId}{nl}";

				string manufacturerInfo = $"\tManufacturer: {cpu.Manufacturer}{nl}";

				string modelInfo = $"\tModel: {cpu.Name.Replace("  ", "")}{nl}";

				string descriptionInfo = $"\tDescription: {cpu.Description}{nl}";

				string socketInfo = $"\tSocket: {cpu.SocketDesignation}{nl}";

				string coresThreadsInfo = $"\tCore Amount: {cpu.NumberOfCores} Physical, {cpu.NumberOfLogicalProcessors} Logical{nl}";

				string vmFirmwareInfo = $"\tVirtualization Firmware Enabled: {cpu.VirtualizationFirmwareEnabled}{nl}";

				string clockspeedsInfo = $"\tClockspeeds:{nl}";

				string currentClockspeedInfo = $"\t\t{cpu.CurrentClockSpeed}mHz Current{nl}";

				string baseClockspeedInfo = $"\t\t{cpu.MaxClockSpeed}mHz Base{nl}";

				string result = idInfo + manufacturerInfo + modelInfo + descriptionInfo + socketInfo +
					coresThreadsInfo + vmFirmwareInfo + clockspeedsInfo + currentClockspeedInfo + baseClockspeedInfo;

				AppendTextSafe(result);

				ShowInfo("");
			}
		}

		/// <summary>
		/// Loads the GPU data and appends it
		/// </summary>
		private void LoadVideoControllerData()
		{
			int id = 0;

			string[] manufacturer = {"3dfx", "ati"};
			string nl = Environment.NewLine;
			//	Example usage
			/*
			foreach (var gpu in NvAPIWrapper.GPU.PhysicalGPU.GetPhysicalGPUs())
			{
				//	Displays Message Box with gpu chip name
				MessageBox.Show(gpu.ArchitectInformation.ShortName);
			}
			*/

			WriteTextSafe("Video: " + nl, "gpuOutputBox");

			foreach (var gpu in hardwareInfo.VideoControllerList)
			{
				float vmemSizeGB = gpu.AdapterRAM / 1073741824;

				string gpuIdInfo = $"\tGPU {id}:{nl}";

				string nameInfo = $"\t\tName: {gpu.Name}{nl}";

				string manufacturerInfo = $"\t\tManufacturer: {gpu.Manufacturer}{nl}";
				manufacturer[id] = gpu.Manufacturer;

				string descriptionInfo = $"\t\tDescription: {gpu.VideoProcessor}{nl}";

				string videoModeInfo;
				if (gpu.VideoModeDescription == "")
				{
					videoModeInfo = $"\t\tVideo Mode: No Display attached{nl}";
				}
				else
				{
					videoModeInfo = $"\t\tVideo Mode: {gpu.VideoModeDescription} x {gpu.CurrentRefreshRate}Hz x {gpu.CurrentBitsPerPixel} Bit{nl}";
				}

				string vramAmountInfo = $"\t\tVRAM Amount: {vmemSizeGB:F2}GB{nl}";

				string maxRefreshRateInfo = $"\t\tMaximum Refresh Rate: {gpu.MaxRefreshRate}Hz{nl}";

				string minRefreshRateInfo = $"\t\tMinimum Refresh Rate: {gpu.MinRefreshRate}Hz{nl}";

				string driverInfo = $"\t\tDriver:{nl}";

				string driverVersionInfo = $"\t\t\tVersion: {gpu.DriverVersion}{nl}";

				string driverDateInfo = $"\t\t\tDate: {gpu.DriverDate}{nl}";

				string result = gpuIdInfo + nameInfo + manufacturerInfo + descriptionInfo + videoModeInfo + vramAmountInfo +
					maxRefreshRateInfo + minRefreshRateInfo + driverInfo + driverVersionInfo + driverDateInfo;

				AppendTextSafe(result, "gpuOutputBox");

				id++;
				ShowInfo("");
			}

			//	Check what manufacturer the gpu is, if nvidia show nvapi info
			if (manufacturer[0].ToLower() == "nvidia" || manufacturer[1].ToLower() == "nvidia")
			{
				//	Clear nvapi Textbox
				nvapiOutputBox.Text = "";

				//	Set GPU ID to 0
				int nvid = 0;

				//	Get GPU info
				foreach (var nvgpu in PhysicalGPU.GetPhysicalGPUs())
				{
					//	GPU id
					string gpuid = $"GPU {nvid}:{nl}";
					//	Get GPU name
					string gpu = $"\tGraphics Card: {nvgpu.FullName}{nl}";
					//	Get GPU Chip name
					string chip = $"\tChip: {nvgpu.ArchitectInformation.ShortName}{nl}";
					//	Get amount of Cores
					string cores = $"\tCores: {nvgpu.ArchitectInformation.NumberOfCores}{nl}";
					//	Get amount of ROPs
					string rops = $"\tROPs: {nvgpu.ArchitectInformation.NumberOfROPs}{nl}";
					//	Get amount of Shader Pipelines
					string shaders = $"\tShader Pipelines: {nvgpu.ArchitectInformation.NumberOfShaderPipelines}{nl}";
					//	Get Graphics Base Freq
					string graphicsBase = $"\tGraphics Base Clock: {nvgpu.BaseClockFrequencies.GraphicsClock.Frequency / 1000}MHz{nl}";
					//	Get Graphics Boost Freq
					string graphicsBoost = $"\tGraphics Boost Clock: {nvgpu.BoostClockFrequencies.GraphicsClock.Frequency / 1000}MHz{nl}";
					//	Get Memory Base Freq
					string memoryBase = $"\tMemory Base Clock: {nvgpu.BaseClockFrequencies.MemoryClock.Frequency / 1000}MHz{nl}";
					//	Get Memory Boost Freq
					string memoryBoost = $"\tMemory Boost Clock: {nvgpu.BoostClockFrequencies.MemoryClock.Frequency / 1000}MHz{nl}";
					//	Get amount of TPCs
					//string tpcs = $"\tTPCs: {nvgpu.ArchitectInformation.TotalNumberOfTPCs}{nl}";	//	Kinda buggy
					//	Get Memory Bus Width
					string memoryBus = $"\tMemory Bus: {nvgpu.MemoryInformation.FrameBufferBandwidth} Bit{nl}";
					//	Get Memory Size
					string memorySize = $"\tPhysical Memory Size: {nvgpu.MemoryInformation.PhysicalFrameBufferSizeInkB / 1000}MB{nl}";
					//	Get Memory Type
					string memoryType;
					if (nvgpu.MemoryInformation.RAMType.ToString() == "14")
					{
						memoryType = $"\tMemory Type: GDDR6{nl}";
					}
					else
					{
						memoryType = $"\tMemory Type: {nvgpu.MemoryInformation.RAMType}{nl}";
					}
					//	Get Memory manufacturer
					string memoryManufacturer = $"\tMemory Manufacturer: {nvgpu.MemoryInformation.RAMMaker}{nl}";
					//	Get ECC Memory Support state
					string memoryEcc = $"\tECC Supported: {nvgpu.ECCMemoryInformation.IsSupported}{nl}";
					//	Get ECC Memory state
					string memoryEccOn = $"\t\tEnabled: {nvgpu.ECCMemoryInformation.IsEnabled}{nl}";
					//	Get vBIOS Version
					string bios = $"\tBIOS Version: {nvgpu.Bios.VersionString}{nl}";
					//	Get Bus type
					string bus = $"\tBUS Type: {nvgpu.BusInformation.BusType}{nl}";
					//	Get amount of PCIe Lanes
					string pcie = $"\t\tPCIe Lanes: {nvgpu.BusInformation.CurrentPCIeLanes}{nl}";
					//	Get AGP Bus info
					string agp = $"\t\tAGP: {nvgpu.BusInformation.AGPInformation}{nl}";

					//	Create Fan string
					string fan = "";
					//	Try reading Fan Speed, if not available print not available message
					try
					{
						fan = $"\tFan Speed: {nvgpu.CoolerInformation}{nl}";
					}
					catch (Exception ex)
					{
						if (ex.Message.ToLower() == "nvapi_not_supported")
						{
							fan = $"\tFan Speed: N/A {nl}";
						}
						else
						{
							fan = $"\tFan Speed: {ex.Message}{nl}";
						}
					}

					//	Get Temperatures
					string temp = $"\tTemperatures: {nl}";

					foreach (var sensor in nvgpu.ThermalInformation.ThermalSensors)
					{
						temp += $"\t\t{sensor}{nl}";
					}

					//	Get Grpahics Clockspeed
					string currentGraphicsClock = $"\tGraphics Clockspeed: {nvgpu.CurrentClockFrequencies.GraphicsClock.Frequency / 1000}MHz{nl}";
					//	Get Memory Clockspeed
					string currentMemoryClock = $"\tMemory Clockspeed: {nvgpu.CurrentClockFrequencies.MemoryClock.Frequency / 1000}MHz{nl}";
					//	Get Video Decode Clockspeed
					string currentVideoClock = $"\tVideo Decode Clockspeed (If available): {nvgpu.CurrentClockFrequencies.VideoDecodingClock.Frequency / 1000}MHz{nl}";

					//	Output GPU info
					nvapiOutputBox.Text += gpuid + gpu + chip + cores + rops + shaders + graphicsBase + graphicsBoost + memoryBase + memoryBoost+ memoryBus + memorySize + memoryType + memoryManufacturer + memoryEcc + memoryEccOn + bios + bus + pcie + agp + fan + temp + currentGraphicsClock + currentMemoryClock + currentVideoClock;
					
					//	Increment ID
					nvid++;
				}
			}
			else
			{
				nvapiOutputBox.Text = "Non NVIDIA Graphics detected. Unable to Display NvAPI information.";
			}
		}

		/// <summary>
		/// Loads the motherboard data and appends it
		/// </summary>
		private void LoadMotherBoardData()
		{
			string nl = Environment.NewLine;

			WriteTextSafe("Motherboard: " + nl, "boardOutputBox");

			foreach (var motherboard in hardwareInfo.MotherboardList)
			{
				string manufacturerInfo = $"\tManufacturer: {motherboard.Manufacturer}{nl}";

				string modelInfo = $"\tModel: {motherboard.Product}{nl}";

				string serialNumberInfo = $"\tSerial No.: {motherboard.SerialNumber}{nl}";

				string result = manufacturerInfo + modelInfo + serialNumberInfo;

				AppendTextSafe(result, "boardOutputBox");
				ShowInfo("");
			}
		}

		/// <summary>
		/// Loads the BIOS data and appends it
		/// </summary>
		private void LoadBIOSData()
		{
			string nl = Environment.NewLine;

			WriteTextSafe("BIOS: " + nl, "biosOutputBox");

			foreach (var bios in hardwareInfo.BiosList)
			{
				string manufacturerInfo = $"\tManufacturer: {bios.Manufacturer}{nl}";

				string nameInfo = $"\tName: {bios.Name}{nl}";

				string versionInfo = $"\tVersion: {bios.Version}{nl}";

				string releaseDateInfo = $"\tRelease Date: {bios.ReleaseDate}{nl}";

				string result = manufacturerInfo + nameInfo + versionInfo + releaseDateInfo;

				AppendTextSafe(result, "biosOutputBox");
				ShowInfo("");
			}
		}

		/// <summary>
		/// Loads the battery data and appends it. Appends "Not Present" when no battery is found.
		/// </summary>
		private void LoadBatteryData()
		{
			string nl = Environment.NewLine;

			WriteTextSafe("Battery: " + nl, "battOutputBox");

			if (hardwareInfo.BatteryList.Count == 0)
			{
				AppendTextSafe("\tNot Present" + nl, "battOutputBox");
			}

			foreach (var battery in hardwareInfo.BatteryList)
			{
				string statusInfo = $"\tStatus: {battery.BatteryStatus}{nl}";

				string statusDescriptionInfo = $"\tStatus Description: {battery.BatteryStatusDescription}{nl}";

				string batteryPercentageInfo = $"\tBattery Percentage: {battery.EstimatedChargeRemaining}%{nl}";

				string timeRemainingInfo = $"\tTime remaining: {battery.EstimatedRunTime} Minutes{nl}";

				string expectedLifeInfo = $"\tExpected Life: {battery.ExpectedLife}{nl}";

				string timeToChargeInfo = $"\tTime until fully charged: {battery.TimeToFullCharge}{nl}";

				string timeOnBatteryInfo = $"\tTime on Battery: {battery.TimeOnBattery}{nl}";

				string capacitiesInfo = $"\tCapacities:{nl}";

				string designCapacityInfo = $"\t\tDesign Capacity: {battery.DesignCapacity}{nl}";

				string fullChargeCapacityInfo = $"\t\tFull Charge Capacity: {battery.FullChargeCapacity}{nl}";

				string result = statusInfo + statusDescriptionInfo + batteryPercentageInfo + timeRemainingInfo +
					expectedLifeInfo + timeToChargeInfo + timeOnBatteryInfo + capacitiesInfo + designCapacityInfo +
					fullChargeCapacityInfo;

				AppendTextSafe(result, "battOutputBox");
			}
			ShowInfo("");
		}

		/// <summary>
		/// Loads the drives data and appends it
		/// </summary>
		private void LoadDrivesData()
		{
			string nl = Environment.NewLine;

			WriteTextSafe("Drives: " + nl, "diskOutputBox");

			foreach (var drive in hardwareInfo.DriveList)
			{
				float diskSizeGB = drive.Size / 1073741824;

				string driveInfo = $"\tDrive {drive.Index}:{nl}";

				string nameInfo = $"\t\tName: {drive.Name}{nl}";

				string sizeInfo = $"\t\tSize: {diskSizeGB:F2}GB{nl}";

				string manufacturerInfo = $"\t\tManufacturer: {drive.Manufacturer}{nl}";

				string modelInfo = $"\t\tModel: {drive.Model}{nl}";

				string firmwareInfo = $"\t\tFirmware Revision: {drive.FirmwareRevision}{nl}";

				string serialNumberInfo = $"\t\tSerial No.: {drive.SerialNumber}{nl}";

				string partitionsInfo = $"\t\tPartition Count: {drive.Partitions}{nl}";

				string result = driveInfo + nameInfo + sizeInfo + manufacturerInfo + modelInfo + firmwareInfo + serialNumberInfo + partitionsInfo;

				AppendTextSafe(result, "diskOutputBox");
				
				ShowInfo("");
			}
		}

		/// <summary>
		/// Loads the network adapters data and appends it
		/// </summary>
		private void LoadNetworkAdaptersData()
		{
			int netAdaptId = 0;

			string nl = Environment.NewLine;

			WriteTextSafe("Network Adapter: " + nl, "netOutputBox");

			foreach (var netAdapt in hardwareInfo.NetworkAdapterList)
			{
				string netAdaptInfo = $"\tNIC {netAdaptId}:{nl}";

				string nameInfo = $"\t\tName: {netAdapt.Name}{nl}";

				string productNameInfo = $"\t\tProduct Name: {netAdapt.ProductName}{nl}";

				string typeInfo = $"\t\tType: {netAdapt.NetConnectionID}{nl}";

				string manufacturerInfo = $"\t\tManufacturer: {netAdapt.Manufacturer}{nl}";

				string macAddressInfo = $"\t\tMAC Address: {netAdapt.MACAddress}{nl}";

				string bytesSentInfo = $"\t\tBytes sent per Second: {netAdapt.BytesSentPersec}{nl}";

				string bytesReceivedInfo = $"\t\tBytes received per Second: {netAdapt.BytesReceivedPersec}{nl}";

				string result = netAdaptInfo + nameInfo + productNameInfo + typeInfo + manufacturerInfo + macAddressInfo + bytesSentInfo + bytesReceivedInfo;

				AppendTextSafe(result, "netOutputBox");

				netAdaptId++;

				ShowInfo("");
			}
		}

		/// <summary>
		/// Loads the memory data and appends it
		/// </summary>
		private void LoadMemoryData()
		{
			string nl = Environment.NewLine;

			WriteTextSafe("Memory:" + nl, "ramOutputBox");

			foreach (var memory in hardwareInfo.MemoryList)
			{
				float memSizeGB = memory.Capacity / 1073741824;

				string bankInfo = $"\t{memory.BankLabel}:{nl}";

				string manufacturerInfo = $"\t\tManufacturer: {memory.Manufacturer}{nl}";

				string sizeInfo = $"\t\t\tSize: {memSizeGB:F2}GB{nl}";

				string speedInfo = $"\t\t\tSpeed: {memory.Speed}mT/s{nl}";

				string partNumberInfo = $"\t\t\tPart No.: {memory.PartNumber}{nl}";

				string formFactorInfo = $"\t\t\tForm Factor: {memory.FormFactor}{nl}";

				string minVoltageInfo = $"\t\t\tMin. Voltage: {memory.MinVoltage}mV{nl}";

				string maxVoltageInfo = $"\t\t\tMax. Voltage: {memory.MaxVoltage}mV{nl}";

				string result = bankInfo + manufacturerInfo + sizeInfo + speedInfo + partNumberInfo + formFactorInfo + minVoltageInfo + maxVoltageInfo;

				AppendTextSafe(result, "ramOutputBox");
				
				ShowInfo("");
			}
		}

		/// <summary>
		/// Safely Overwrite on textbox content
		/// </summary>
		/// <param name="text"></param>
		private void ShowInfo(string text)
		{
			//	TODO: Think of better names
			
			//	Create textbox variable to invoke
			TextBox textBox = cpuOutputBox;

			//	change textbox variable to correct textbox
			switch (outputBox)
			{
				default:
					break;
				case "cpuOutputBox":
					textBox = cpuOutputBox;
					break;
				case "ramOutputBox":
					textBox = ramOutputBox;
					break;
				case "gpuOutputBox":
					textBox = gpuOutputBox;
					break;
				case "boardOutputBox":
					textBox = boardOutputBox;
					break;
				case "biosOutputBox":
					textBox = biosOutputBox;
					break;
				case "battOutputBox":
					textBox = battOutputBox;
					break;
				case "diskOutputBox":
					textBox = diskOutputBox;
					break;
				case "netOutputBox":
					textBox = netOutputBox;
					break;
			}
			if (textBox.InvokeRequired)
			{
				var d = new SafeCallDelegate(ShowInfo);
				textBox.Invoke(d, new object[] { InfoTextBuffer });
			}
			else
			{
				textBox.Text = InfoTextBuffer;
			}
		}

		// Creating String To Push it later on textbox
		private string InfoTextBuffer = "";

		private string outputBox = "";

		private void WriteTextSafe(string text, string output = "cpuTextBox")
		{
			// NOTE (HOUDAIFA) : Faster Way

			InfoTextBuffer = text;
			outputBox = output;
		}

		/// <summary>
		/// Appand Text To Text Buffer
		/// </summary>
		private void AppendTextSafe(string text, string output = "cpuTextBox")
		{
			// NOTE (HOUDAIFA) : Faster Way

			InfoTextBuffer += text;
			outputBox = output;
		}

		/// <summary>
		/// Starts thread, changes button states, update info text and increments progress bar
		/// </summary>
		public void LoadInfo()
		{
			infoLabel.Visible = true;
			progressBar.Visible = true;
			startButton.Enabled = false;
			infoLabel.Text = "Loading System Info.";
			progressBar.Value = 25;
			thread = new Thread(() => Getdata(true));
			stopButton.Enabled = true;
			progressBar.Value = 50;
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

		/// <summary>
		/// Stop update thread
		/// </summary>
		public void StopUpdate()
		{
			if (thread.IsAlive)
			{
				thread.Abort();
				stopButton.Enabled = false;
				startButton.Enabled = true;
			}
		}

		/// <summary>
		/// Load System info when Start Button is pressed
		/// </summary>
		public void startButton_Click(object sender, EventArgs e)
		{
			LoadInfo();
		}

		/// <summary>
		/// Change Button state and abort thread when Stop Button is pressed
		/// </summary>
		private void stopButton_Click(object sender, EventArgs e)
		{
			StopUpdate();
			infoLabel.Visible = true;
			infoLabel.Text = "Press Start to continuously update System Info.";
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

		/// <summary>
		/// Loads theme to the application
		/// </summary>
		public void LoadTheme()
		{
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

			//	Read Settings
			//	Set theme
			if (data.GetKey("tinyinfo.theme") == "dark")
			{
				//	Dark theme
				ForeColor = Color.White;
				BackColor = Color.Gray;
				startButton.ForeColor = Color.Black;
				stopButton.ForeColor = Color.Black;
				onTopCheckbox.ForeColor = Color.White;
				onTopCheckbox.BackColor = Color.Gray;
				onTopBoxPanel.BackColor = Color.FromName("ButtonFace");
				onTopBoxPanel.ForeColor = Color.White;
				cpuOutputBox.BackColor = Color.DimGray;
				cpuOutputBox.ForeColor = Color.White;
				ramOutputBox.BackColor = Color.DimGray;
				ramOutputBox.ForeColor = Color.White; 
				gpuOutputBox.BackColor = Color.DimGray;
				gpuOutputBox.ForeColor = Color.White; 
				boardOutputBox.BackColor = Color.DimGray;
				boardOutputBox.ForeColor = Color.White; 
				biosOutputBox.BackColor = Color.DimGray;
				biosOutputBox.ForeColor = Color.White; 
				battOutputBox.BackColor = Color.DimGray;
				battOutputBox.ForeColor = Color.White; 
				diskOutputBox.BackColor = Color.DimGray;
				diskOutputBox.ForeColor = Color.White; 
				netOutputBox.BackColor = Color.DimGray;
				netOutputBox.ForeColor = Color.White;
				nvapiOutputBox.BackColor = Color.DimGray;
				nvapiOutputBox.ForeColor = Color.White;
			}
			else
			{
				//	Light theme
				ForeColor = Color.Black;
				BackColor = Color.White;
				startButton.ForeColor = Color.Black;
				stopButton.ForeColor = Color.Black;
				onTopCheckbox.ForeColor = Color.Black;
				onTopCheckbox.BackColor = Color.White;
				onTopBoxPanel.BackColor = Color.White;
				onTopBoxPanel.ForeColor = Color.Black;
				cpuOutputBox.BackColor = Color.White;
				cpuOutputBox.ForeColor = Color.Black;
				ramOutputBox.BackColor = Color.White;
				ramOutputBox.ForeColor = Color.Black;
				gpuOutputBox.BackColor = Color.White;
				gpuOutputBox.ForeColor = Color.Black;
				boardOutputBox.BackColor = Color.White;
				boardOutputBox.ForeColor = Color.Black;
				biosOutputBox.BackColor = Color.White;
				biosOutputBox.ForeColor = Color.Black;
				battOutputBox.BackColor = Color.White;
				battOutputBox.ForeColor = Color.Black;
				diskOutputBox.BackColor = Color.White;
				diskOutputBox.ForeColor = Color.Black;
				netOutputBox.BackColor = Color.White;
				netOutputBox.ForeColor = Color.Black;
				nvapiOutputBox.BackColor = Color.White;
				nvapiOutputBox.ForeColor = Color.Black;
			}

			//	Apply font changes
			FontStyle fontStyle;
			string savedStyle = data.GetKey("tinyinfo.fontstyle");
			switch (savedStyle)
			{
				default:
					fontStyle = FontStyle.Regular;
					break;
				case "Bold":
					fontStyle = FontStyle.Bold;
					break;
				case "Bold, Italic":
					fontStyle = FontStyle.Bold | FontStyle.Italic;
					break;
				case "Italic":
					fontStyle = FontStyle.Italic;
					break;
			}
			Font font = new Font(data.GetKey("tinyinfo.fontname"), Convert.ToInt32(data.GetKey("tinyinfo.fontsize")), fontStyle);

			//	Set refresh rate
			maxRefresh = Convert.ToInt32(data.GetKey("tinyinfo.refresh"));

			//	Apply font sizes
			cpuOutputBox.Font = font;
			ramOutputBox.Font = font;
			gpuOutputBox.Font = font;
			nvapiOutputBox.Font = font;
			diskOutputBox.Font = font;
			biosOutputBox.Font = font;
			battOutputBox.Font = font;
			boardOutputBox.Font = font;
			netOutputBox.Font = font;
			outputTabs.Font = font;
			gpuTabs.Font = font;
			startButton.Font = font;
			stopButton.Font = font;
			infoLabel.Font = font;
			onTopCheckbox.Font = font;
		}

		/// <summary>
		/// Opens Settings Window
		/// </summary>
		private void settingsItem_Click(object sender, EventArgs e)
		{
			//	Create Settings Window
			var settings = new SettingsWindow();
			settings.ShowDialog();
			//	Reload Theme
			LoadTheme();
		}

		/// <summary>
		/// Export system info to text file as plain text
		/// </summary>
		private void exportItem_Click(object sender, EventArgs e)
		{
			infoLabel.Visible = true;
			infoLabel.Text = "Exporting as Text...";
			ExportToTextFile(0);
			infoLabel.Text = "Press Start to continuously update System Info.";
		}

		/// <summary>
		/// Export system info to text file as JSON
		/// </summary>
		private void btnExportAsJSON_Click(object sender, EventArgs e)
		{
			infoLabel.Visible = true;
			infoLabel.Text = "Exporting as JSON...";
			ExportToTextFile(1);
			infoLabel.Text = "Press Start to continuously update System Info.";
		}

		/// <summary>
		/// Exports the content of hardwareinfo into a text file based on an integer.
		/// If the integer is 0, it exports it as a plain text.
		/// If the integer is 1, it exports it as a JSON.
		/// </summary>
		/// <param name="mode"></param>
		private void ExportToTextFile(int mode)
		{
			if (cpuOutputBox == null)
			{
				// Handle the case where outputBox is not set.
				return;
			}

			try
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					string filePath = "";
					switch (mode)
					{
						case 0:
							//	Defines allowed file types
							saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
							//	Sets default file name
							saveFileDialog.FileName = "export.txt";

							//	Set SaveFileDialog title
							saveFileDialog.Title = "Tinyinfo - Text Export";

							if (saveFileDialog.ShowDialog() != DialogResult.OK)
							{
								return;
							}

							//	Sets file path to users directory of choice
							filePath = saveFileDialog.FileName;

							using (StreamWriter writer = new StreamWriter(filePath))
							{
								string nl = Environment.NewLine;
								string outputText = cpuOutputBox.Text + ramOutputBox.Text + gpuOutputBox.Text + nvapiOutputBox.Text + boardOutputBox.Text + biosOutputBox.Text + battOutputBox.Text + diskOutputBox.Text + netOutputBox.Text;

								writer.Write(outputText);
							}
							break;

						case 1:
							//	Defines allowed file types
							saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
							//	Sets default file name
							saveFileDialog.FileName = "export.json";

							//	Set SaveFileDialog title
							saveFileDialog.Title = "Tinyinfo - JSON Export";

							if (saveFileDialog.ShowDialog() != DialogResult.OK)
							{
								return;
							}

							//	Sets file path to users directory of choice
							filePath = saveFileDialog.FileName;

							using (StreamWriter writer = new StreamWriter(filePath))
							{
								writer.Write(JSON.CreateJSON());
							}
							break;

						default:
							break;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		//	Create ShellAbout
		[DllImport("shell32.dll")]
		private static extern int ShellAbout(IntPtr hwnd, string szApp, string szOtherStuff, IntPtr hIcon);

		//	Write versions to strings
		private string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		private string majorVersion = Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();
		private string servicePack = Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
		private string revision = Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();

		/// <summary>
		/// Opens ShellAbout Dialog to display version info
		/// </summary>
		private void aboutItem_Click(object sender, EventArgs e)
		{
			//	Create ShellAbout dialog
			ShellAbout(IntPtr.Zero, "About Tinyinfo" + "#Tinyinfo V" + majorVersion + " Service Pack " + servicePack, "Detailed version info:\nTinyinfo v." + version, Icon.Handle);
		}

		/// <summary>
		/// Opens GitHub repo in browser
		/// </summary>
		private void githubItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Lion-Craft/Tinyinfo");
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			StopUpdate();
		}

		private void refreshItem_Click(object sender, EventArgs e)
		{
			//	Refresh system info
			Getdata(false);
		}

		private void exitItem_Click(object sender, EventArgs e)
		{
			//	Stop Updating
			StopUpdate();
			//	Exit Tinyinfo
			Application.Exit();
		}
	}
}
