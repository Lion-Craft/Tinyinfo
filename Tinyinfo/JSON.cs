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
				
				if ( bankNo > 1)
				{
					output += ",\n";
				}
				else
				{
					output += "\n";
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

			output += "\n}\n";

			output += "}";
			return output;
		}
	}
}
