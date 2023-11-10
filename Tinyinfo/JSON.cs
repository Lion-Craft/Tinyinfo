using System;
using NvAPIWrapper.GPU;
using Hardware.Info;

namespace Tinyinfo
{
	class JSON
	{
		private static readonly IHardwareInfo hardwareInfo = new HardwareInfo();

		/// <summary>
		/// Creates JSON formatted text about the hardware
		/// </summary>
		/// <returns>JSON text</returns>
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
			string[] manufacturer = { "3dfx", "ati" };
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
				manufacturer[gpuNo - 1] = gpu.Manufacturer;
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

			output += "\n},\n";

			//	GPU (NVAPI)
			output += "\"NVAPI GPU\":\n{";
			int nvid = 0;
			if (manufacturer[0].ToLower() == "nvidia" || manufacturer[1].ToLower() == "nvidia")
			{
				foreach (var nvgpu in PhysicalGPU.GetPhysicalGPUs())
				{
					nvid++;

					if (nvid > 1)
					{
						output += ",\n";
					}
					else
					{
						output += "\n";
					}

					output += "\"GPU " + (nvid - 1) + "\": \n{\n";

					output += "\"Graphics Card\": \"" + nvgpu.FullName + "\",\n";
					output += "\"Chip\": \"" + nvgpu.ArchitectInformation.ShortName + "\",\n";
					output += "\"Cores\": \"" + nvgpu.ArchitectInformation.NumberOfCores + "\",\n";
					output += $"\"ROPs\": \"" + nvgpu.ArchitectInformation.NumberOfROPs + "\",\n";
					output += "\"Shader Pipelines\": \"" + nvgpu.ArchitectInformation.NumberOfShaderPipelines + "\",\n";
					output += "\"Graphics Base Clock\": \"" + (nvgpu.BaseClockFrequencies.GraphicsClock.Frequency / 1000) + " MHz\",\n";
					output += "\"Graphics Boost Clock\": \"" + (nvgpu.BoostClockFrequencies.GraphicsClock.Frequency / 1000) + " MHz\",\n";
					output += "\"Memory Base Clock\": \"" + (nvgpu.BaseClockFrequencies.MemoryClock.Frequency / 1000) + " MHz\",\n";
					output += "\"Memory Boost Clock\": \"" + (nvgpu.BoostClockFrequencies.MemoryClock.Frequency / 1000) + " MHz\",\n";
					output += "\"Memory Bus\": \"" + nvgpu.MemoryInformation.FrameBufferBandwidth + " Bit\",\n";
					output += "\"Physical Memory Size\": \"" + (nvgpu.MemoryInformation.PhysicalFrameBufferSizeInkB / 1000) + "\",\n";

					if (nvgpu.MemoryInformation.RAMType.ToString() == "14")
					{
						output += "\"Memory Type\": \"GDDR6\",\n";
					}
					else
					{
						output += "\"Memory Type\": \"" + nvgpu.MemoryInformation.RAMType +"\",\n";
					}

					output += "\"Memory Manufacturer\": \"" + nvgpu.MemoryInformation.RAMMaker + "\",\n";
					output += "\"ECC Supported\": \"" + nvgpu.ECCMemoryInformation.IsSupported + "\",\n";
					output += "\"ECC Enabled\": \"" + nvgpu.ECCMemoryInformation.IsEnabled + "\",\n";
					output += "\"BIOS Version\": \"" + nvgpu.Bios.VersionString + "\",\n";
					output += "\"Bus Type\": \"" + nvgpu.BusInformation.BusType + "\",\n";
					output += "\"PCIe Lanes\": \"" + nvgpu.BusInformation.CurrentPCIeLanes + "\",\n";
					output += "\"AGP\": \"" + nvgpu.BusInformation.AGPInformation + "\",\n";

					//	Create Fan string
					string fan = "";
					//	Try reading Fan Speed, if not available print not available message
					try
					{
						fan = nvgpu.CoolerInformation.ToString();
					}
					catch (Exception ex)
					{
						if (ex.Message.ToLower() == "nvapi_not_supported")
						{
							fan = "N/A";
						}
						else
						{
							fan = ex.Message;
						}
					}
					output += "\"Fan Speed\": \"" + fan + "\",\n";

					//	GPU Temps
					foreach (var sensor in nvgpu.ThermalInformation.ThermalSensors)
					{
						output += $"\"Temp {sensor.SensorId}\": \"" + sensor + "\",\n";
					}

					output += "\"Graphics Clock\": \"" + (nvgpu.CurrentClockFrequencies.GraphicsClock.Frequency / 1000) + " MHz\",\n";
					output += "\"Memory Clock\": \"" + (nvgpu.CurrentClockFrequencies.MemoryClock.Frequency / 1000) + " MHz\",\n";
					output += "\"Video Clock\": \"" + (nvgpu.CurrentClockFrequencies.VideoDecodingClock.Frequency / 1000) + " MHz\"\n";

					output += "}";
				}
			}
			
			output += "\n},\n";

			output += "\"Motherboard\":\n{\n";
			foreach (var board in hardwareInfo.MotherboardList)
			{
				output += "\"Manufacturer\": \"" + board.Manufacturer + "\",\n";
				output += "\"Model\": \"" + board.Product + "\",\n";
				output += "\"Serial Number\": \"" + board.SerialNumber + "\"";
			}

			output += "\n},\n";

			output += "\"BIOS\":\n{\n";
			foreach (var bios in hardwareInfo.BiosList)
			{
				output += "\"Manufacturer\": \"" + bios.Manufacturer + "\",\n";
				output += "\"Name\": \"" + bios.Name + "\",\n";
				output += "\"Version\": \"" + bios.Version + "\",\n";
				output += "\"Release Date\": \"" + bios.ReleaseDate + "\"";
			}

			output += "\n},\n";

			output += "\"Batteries\":\n{\n";
			if (hardwareInfo.BatteryList.Count == 0)
			{
				output += "\"Battery 0\": \"Not Present\"";
			}
			else
			{
				int batt = 0;
				foreach (var battery in hardwareInfo.BatteryList)
				{
					output += "\"Battery " + batt + "\":\n{\n";
					output += "\"Status\": \"" + battery.BatteryStatus + "\",\n";
					output += "\"Status Description\": \"" + battery.BatteryStatusDescription + "\",\n";
					output += "\"Percentage\": \"" + battery.EstimatedChargeRemaining + "\",\n";
					output += "\"Time Remaining\": \"" + battery.EstimatedRunTime + "\",\n";
					output += "\"Expected Life\": \"" + battery.ExpectedLife + "\",\n";
					output += "\"Time To Full\": \"" + battery.TimeToFullCharge + "\",\n";
					output += "\"Time On Battery\": \"" + battery.TimeOnBattery + "\",\n";
					output += "\"Design Capacity\": \"" + battery.DesignCapacity + "\",\n";
					output += "\"Full Capacity\": \"" + battery.FullChargeCapacity + "\"\n";
					output += "}\n";
					
					batt++;
				}
			}
			output += "\n}\n";

			output += "}";
			return output;
		}
	}
}
