using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			output += "\"RAM:\":\n{\n";
			foreach (var ram in hardwareInfo.MemoryList)
			{
				output += "\"" + ram.BankLabel + "\":\n{";

				output += "\"Manufacturer\": \"" + ram.Manufacturer + "\",\n";
				output += "\"Size\": \"" + ram.Capacity / 1073741824 + " GB\" \n";
				
				output += "},\n";
			}
			output += "}\n";

			output += "}";
			return output;
		}
	}
}
