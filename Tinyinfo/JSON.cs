using System;
using NvAPIWrapper.GPU;
using Hardware.Info;

namespace Tinyinfo
{
	class JSON
	{
		private static readonly IHardwareInfo hardwareInfo = new HardwareInfo();
		public static string CreateJSON()
		{
			//	Is this bad?
			//	Yes.
			//	Does it work?
			//	Also Yes.

			hardwareInfo.RefreshAll();
			string output = "error";
			foreach (var cpu in hardwareInfo.CpuList)
			{
				//	CPU
				output = "{\n\"CPU\":\n{\n";
				output += "\"ID\": \"" + cpu.ProcessorId + "\",\n";
				output += "\"Manufacturer\": \"" + cpu.Manufacturer + "\",\n";
				output += "\"Model\": \"" + cpu.Name.Replace("  ", "") + "\",\n";
				output += "\"Description\": \"" + cpu.Description + "\",\n";
				output += "\"Socket\": \"" + cpu.SocketDesignation + "\",\n";

				output += "\"Core Amount\":\n{\n";
				output += "\"Physical\": \"" + cpu.NumberOfCores + "\",\n";
				output += "\"Logical\": \"" + cpu.NumberOfLogicalProcessors + "\"\n},\n";

				output += "\"Virtualization Firmware Enabled\": \"" + cpu.VirtualizationFirmwareEnabled + "\",\n";

				output += "\"Clockspeeds\":\n{\n";
				output += "\"Current\": \"" + cpu.CurrentClockSpeed + "mHz\",\n";
				output += "\"Base\": \"" + cpu.MaxClockSpeed + "mHz\"\n}\n";

				output += "},\n";
			}

			//	RAM
			output += "\"RAM:\":\n{";
			int bankNo = 0;
			foreach (var ram in hardwareInfo.MemoryList)
			{
				bankNo++;
				string endOfSection;
				if ( bankNo > 1)
				{
					endOfSection = ",\n";
					output += endOfSection;
				}
				else
				{
					endOfSection = "\n";
					output += endOfSection;
				}
				
				output += "\"" + ram.BankLabel + "\":\n{\n";

				output += "\"Manufacturer\": \"" + ram.Manufacturer + "\",\n";
				output += "\"Size\": \"" + ram.Capacity / 1073741824 + " GB\",\n";
				output += "\"Speed\": \"" + ram.Speed + "MT/s\",\n";
				output += "\"Part No\": \"" + ram.PartNumber + "\",\n";
				output += "\"Form Factor\": \"" + ram.FormFactor + "\",\n";
				output += "\"Min Voltage\": \"" + ram.MinVoltage + "mV\",\n";
				output += "\"Max Voltage\": \"" + ram.MaxVoltage + "mV\"\n";

				output += "}";
			}
			output += "\n},\n";

			//	GPU (WMI)
			output += "\"WMI GPU\":\n{";
			int gpuNo = 0;
			foreach (var gpu in hardwareInfo.VideoControllerList)
			{
				gpuNo++;

				if (gpuNo > 1)
				{
					output += ",\n";
				}
				else
				{
					output += "\n";
				}

				output += "\"GPU " + (gpuNo - 1) + "\": \n{\n";

				output += "\"Name\": \"" + gpu.Name + "\",\n";
				output += "\"Manufacturer\": \"" + gpu.Manufacturer + "\",\n";
				output += "\"Description\": \"" + gpu.Description + "\",\n";

				if (gpu.VideoModeDescription == "")
				{
					output += "\"Video Mode\": \"No Display\",\n";
				}
				else
				{
					output += $"\"Video Mode\": \"" + gpu.VideoModeDescription + " x " + gpu.CurrentRefreshRate + "Hz x " + gpu.CurrentBitsPerPixel + "Bit\",\n";
				}

				output += "\"VRAM Amount\": \"" + (gpu.AdapterRAM / 1073741824) + "GB\",\n";
				output += "\"Max Refresh Rate\": \"" + gpu.MaxRefreshRate + "\",\n";
				output += "\"Min Refresh Rate\": \"" + gpu.MinRefreshRate + "\",\n";
				output += "\"Driver Version\": \"" + gpu.DriverVersion + "\",\n";
				output += "\"Driver Date\": \"" + gpu.DriverDate + "\"\n";

				output += "}";
			}

			output += "\n}\n";

			output += "}";
			return output;
		}
	}
}
