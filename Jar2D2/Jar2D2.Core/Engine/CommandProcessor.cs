using ArduinoUploader.Hardware;
using Jar2D2.Core.Commands;

namespace Jar2D2.Core.Engine
{
	public class CommandProcessor : ICommandProcessor
	{
		private readonly ArduinoDriver.ArduinoDriver Driver;

		public CommandProcessor()
		{
			Driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "COM3", true);
		}

		public void Send(IOutCommand command)
		{
      command.Execute(Driver);
    }
  }
}
