using Hardware.Info;
using IniParser;
using IniParser.Model;
using Newtonsoft.Json;
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
        private Thread thread;

        private static readonly IHardwareInfo hardwareInfo = new HardwareInfo();

        private delegate void SafeCallDelegate(string text);

        public MainWindow()
        {
            InitializeComponent();

            LoadTheme();
        }

        //	Thread for updating info in background

        /// <summary>
        /// Runs on form load
        /// </summary>
        public void Startup(object sender, EventArgs e)
        {
            //	Create Thread on start
            thread = new Thread(() => Getdata(true));

            //	Get info on load
            Getdata(false);
        }

        private void RefreshAllHardwareInfo()
        {
            hardwareInfo.RefreshCPUList(true);

            hardwareInfo.RefreshMemoryList();

            hardwareInfo.RefreshBIOSList();

            hardwareInfo.RefreshMotherboardList();

            hardwareInfo.RefreshVideoControllerList();

            hardwareInfo.RefreshBatteryList();

            hardwareInfo.RefreshDriveList();

            hardwareInfo.RefreshNetworkAdapterList();
        }

        /// <summary>
        /// Collect system info and write to textBox1
        /// </summary>
        public void Getdata(bool loop)
        {
            do
            {
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
            } while (loop);
        }

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

                string baseClockspeedInfo = $"\t\t{cpu.MaxClockSpeed}mHz Base";

                string result = idInfo + manufacturerInfo + modelInfo + descriptionInfo + socketInfo +
                    coresThreadsInfo + vmFirmwareInfo + clockspeedsInfo + currentClockspeedInfo + baseClockspeedInfo;

                AppendTextSafe(result);
            }
        }

        private void LoadVideoControllerData()
        {
            int id = 0;

            string nl = Environment.NewLine;

            AppendTextSafe(nl + "Video: ");

            foreach (var gpu in hardwareInfo.VideoControllerList)
            {
                float vmemSizeGB = gpu.AdapterRAM / 1073741824;

                string gpuIdInfo = $"\tGPU {id}:{nl}";

                string nameInfo = $"\t\tName: {gpu.Name}{nl}";

                string manufacturerInfo = $"\t\tManufacturer: {gpu.Manufacturer}{nl}";

                string descriptionInfo = $"\t\tDescription: {gpu.VideoProcessor}{nl}";

                string videoModeInfo = $"\t\tVideo Mode: {gpu.VideoModeDescription} x {gpu.CurrentRefreshRate}Hz x {gpu.CurrentBitsPerPixel} Bit{nl}";

                string vramAmountInfo = $"\t\tVRAM Amount: {vmemSizeGB:F2}GB{nl}";

                string maxRefreshRateInfo = $"\t\tMaximum Refresh Rate: {gpu.MaxRefreshRate}Hz{nl}";

                string minRefreshRateInfo = $"\t\tMinimum Refresh Rate: {gpu.MinRefreshRate}Hz{nl}";

                string driverInfo = $"\t\tDriver:{nl}";

                string driverVersionInfo = $"\t\t\tVersion: {gpu.DriverVersion}{nl}";

                string driverDateInfo = $"\t\t\tDate: {gpu.DriverDate}";

                string result = gpuIdInfo + nameInfo + manufacturerInfo + descriptionInfo + videoModeInfo + vramAmountInfo +
                    maxRefreshRateInfo + minRefreshRateInfo + driverInfo + driverVersionInfo + driverDateInfo;

                AppendTextSafe(result);

                id++;
            }
        }

        private void LoadMotherBoardData()
        {
            string nl = Environment.NewLine;

            AppendTextSafe(nl + "Motherboard: " + nl);

            foreach (var motherboard in hardwareInfo.MotherboardList)
            {
                string manufacturerInfo = $"\tManufacturer: {motherboard.Manufacturer}{nl}";

                string modelInfo = $"\tModel: {motherboard.Product}{nl}";

                string serialNumberInfo = $"\tSerial No.: {motherboard.SerialNumber}";

                string result = manufacturerInfo + modelInfo + serialNumberInfo;

                AppendTextSafe(result);
            }
        }

        private void LoadBIOSData()
        {
            string nl = Environment.NewLine;

            AppendTextSafe(nl + "BIOS: " + nl);

            foreach (var bios in hardwareInfo.BiosList)
            {
                string manufacturerInfo = $"\tManufacturer: {bios.Manufacturer}{nl}";

                string nameInfo = $"\tName: {bios.Name}{nl}";

                string versionInfo = $"\tVersion: {bios.Version}{nl}";

                string releaseDateInfo = $"\tRelease Date: {bios.ReleaseDate}";

                string result = manufacturerInfo + nameInfo + versionInfo + releaseDateInfo;

                AppendTextSafe(result);
            }
        }

        private void LoadBatteryData()
        {
            string nl = Environment.NewLine;

            AppendTextSafe(nl + "Battery: ");

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

                AppendTextSafe(result);
            }
        }

        private void LoadDrivesData()
        {
            string nl = Environment.NewLine;

            AppendTextSafe(nl + "Drives: " + nl);

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

                string partitionsInfo = $"\t\tPartition Count: {drive.Partitions}";

                string result = driveInfo + nameInfo + sizeInfo + manufacturerInfo + modelInfo + firmwareInfo + serialNumberInfo + partitionsInfo;

                AppendTextSafe(result);
            }
        }

        private void LoadNetworkAdaptersData()
        {
            int netAdaptId = 0;

            string nl = Environment.NewLine;

            AppendTextSafe(nl + "Network Adapter: " + nl);

            foreach (var netAdapt in hardwareInfo.NetworkAdapterList)
            {
                string netAdaptInfo = $"\tNIC {netAdaptId}:{nl}";

                string nameInfo = $"\t\tName: {netAdapt.Name}{nl}";

                string productNameInfo = $"\t\tProduct Name: {netAdapt.ProductName}{nl}";

                string typeInfo = $"\t\tType: {netAdapt.NetConnectionID}{nl}";

                string manufacturerInfo = $"\t\tManufacturer: {netAdapt.Manufacturer}{nl}";

                string macAddressInfo = $"\t\tMAC Address: {netAdapt.MACAddress}{nl}";

                string bytesSentInfo = $"\t\tBytes sent per Second: {netAdapt.BytesSentPersec}{nl}";

                string bytesReceivedInfo = $"\t\tBytes received per Second: {netAdapt.BytesReceivedPersec}";

                string result = netAdaptInfo + nameInfo + productNameInfo + typeInfo + manufacturerInfo + macAddressInfo + bytesSentInfo + bytesReceivedInfo;

                AppendTextSafe(result);

                netAdaptId++;
            }
        }

        private void LoadMemoryData()
        {
            string nl = Environment.NewLine;

            AppendTextSafe(nl + "Memory:" + nl);

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

                string maxVoltageInfo = $"\t\t\tMax. Voltage: {memory.MaxVoltage}mV";

                string result = bankInfo + manufacturerInfo + sizeInfo + speedInfo + partNumberInfo + formFactorInfo + minVoltageInfo + maxVoltageInfo;

                AppendTextSafe(result + nl);
            }
        }

        // Safely Overwrite on textbox content
        private void ShowInfo(string text)
        {
            if (outputBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(ShowInfo);
                outputBox.Invoke(d, new object[] { InfoTextBuffer });
            }
            else
            {
                outputBox.Text = InfoTextBuffer;
            }
        }

        // Creating String To Push it later on textbox
        private string InfoTextBuffer = "";

        private void WriteTextSafe(string text)
        {
            // NOTE (HOUDAIFA) : Faster Way

            InfoTextBuffer = text;
        }

        // Appand Text To Text Buffer
        private void AppendTextSafe(string text)
        {
            // NOTE (HOUDAIFA) : Faster Way

            InfoTextBuffer += text;
        }

        //	Starts thread, changes button states, update info text and increments progress bar
        public void LoadInfo()
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
        public void StopUpdate()
        {
            if (thread.IsAlive)
            {
                thread.Abort();
                stopButton.Enabled = false;
                startButton.Enabled = true;
            }
        }

        //	Load System info when Start Button is pressed
        public void startButton_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        //	Change Button state and abort thread when Stop Button is pressed
        private void stopButton_Click(object sender, EventArgs e)
        {
            StopUpdate();
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

        public void LoadTheme()
        {
            //	Check if file exists, if it doesnt create it with default settings
            if (!File.Exists("./tinyinfo.ini"))
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
            LoadTheme();
        }

        /// <summary>
		/// Export system info to text file as plain text
		/// </summary>
        private void exportItem_Click(object sender, EventArgs e)
        {
            ExportToTextFile(0);
        }

        /// <summary>
        /// Export system info to text file as JSON
        /// </summary>
        private void btnExportAsJSON_Click(object sender, EventArgs e)
        {
            ExportToTextFile(1);
        }

        private void ExportToTextFile(int mode)
        {
            if (outputBox == null)
            {
                // Handle the case where outputBox is not set.
                return;
            }

            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    string filePath = saveFileDialog.FileName;
                    switch (mode)
                    {
                        case 0:
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                string outputText = outputBox.Text;

                                writer.Write(outputText);
                            }
                            break;

                        case 1:
                            string json = GetHardwareInfoAsJSON();

                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                writer.Write(json);
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

        private string GetHardwareInfoAsJSON()
        {
            string finalJson = string.Empty;

            try
            {
                string cpuListJson = JsonConvert.SerializeObject(hardwareInfo.CpuList);

                string videoControllerListJson = JsonConvert.SerializeObject(hardwareInfo.VideoControllerList);

                string memoryListJson = JsonConvert.SerializeObject(hardwareInfo.MemoryList);

                string motherboardListJson = JsonConvert.SerializeObject(hardwareInfo.MotherboardList);

                string biosListJson = JsonConvert.SerializeObject(hardwareInfo.BiosList);

                string batteryListJson = JsonConvert.SerializeObject(hardwareInfo.BatteryList);

                string driveListJson = JsonConvert.SerializeObject(hardwareInfo.DriveList);

                // I commented this one because for some reason it was the only one giving me a weird exception. I don't know.
                //string networkAdapterListJson = JsonConvert.SerializeObject(hardwareInfo.NetworkAdapterList);

                var combinedJson = new
                {
                    CpuList = cpuListJson,
                    VideoControllerList = videoControllerListJson,
                    MemoryList = memoryListJson,
                    MotherboardList = motherboardListJson,
                    BiosList = biosListJson,
                    BatteryList = batteryListJson,
                    DriveList = driveListJson,
                    //NetworkAdapterList = networkAdapterListJson
                };

                finalJson = JsonConvert.SerializeObject(combinedJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return finalJson;
        }

        //	Create ShellAbout
        [DllImport("shell32.dll")]
        private static extern int ShellAbout(IntPtr hwnd, string szApp, string szOtherStuff, IntPtr hIcon);

        //	Write versions to strings
        private string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private string majorVersion = Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();
        private string servicePack = Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
        private string revision = Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();

        //	Opens ShellAbout Dialog to display version info
        private void aboutItem_Click(object sender, EventArgs e)
        {
            //	Create ShellAbout dialog
            ShellAbout(IntPtr.Zero, "About Tinyinfo" + "#Tinyinfo V" + majorVersion + " Service Pack " + servicePack, "Detailed version info:\nTinyinfo v." + version, Icon.Handle);
        }

        //	Opens GitHub repo in browser
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
            System.Windows.Forms.Application.Exit();
        }
    }
}