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
			Driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "COM3", true);
		}

		public void Send(ICommand command)
		{
			var on = new DigitalWriteRequest((byte)command.GetPin(), ArduinoDriver.DigitalValue.High);

      Driver.Send(on);
			Thread.Sleep(10000);
			var off = new DigitalWriteRequest((byte)command.GetPin(), ArduinoDriver.DigitalValue.Low);

      Driver.Send(off);


      // lets try send a light to turn on for 10 second then off.
      // in the middle (5 seconds) after the first light turns on, we send another command which turns a different light on then off for 1 second
		}
	}
}
