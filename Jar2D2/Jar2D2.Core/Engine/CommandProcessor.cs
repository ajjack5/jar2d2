using ArduinoUploader.Hardware;
using Jar2D2.Core.Commands;
using ArduinoDriver.SerialProtocol;
using System.Threading;

namespace Jar2D2.Core.Engine
{
	public class CommandProcessor : ICommandProcessor
	{
		private readonly ArduinoDriver.ArduinoDriver Driver;

		public CommandProcessor()
		{
			Driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "COM9", true);
		}

		public void Send(ICommand command)
		{
			var on = new DigitalWriteRequest((byte)command.GetPin(), ArduinoDriver.DigitalValue.High);
			Driver.Send(on);
			Thread.Sleep(200);
			var off = new DigitalWriteRequest((byte)command.GetPin(), ArduinoDriver.DigitalValue.Low);
			Driver.Send(off);
		}
	}
}
