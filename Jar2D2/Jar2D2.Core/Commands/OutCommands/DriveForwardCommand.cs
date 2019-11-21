using ArduinoDriver.SerialProtocol;
using System.Collections.Generic;

namespace Jar2D2.Core.Commands.OutCommands
{
	public class DriveForwardCommand : IOutCommand
  {
    public IDictionary<int, int> CommandRegistry { get; set; }

    public void Execute(ArduinoDriver.ArduinoDriver driver)
    {
      var leftWheel = new DigitalWriteRequest(1, ArduinoDriver.DigitalValue.High);
      var rightWheel = new DigitalWriteRequest(2, ArduinoDriver.DigitalValue.High);

      driver.Send(leftWheel);
      driver.Send(rightWheel);
    }
  }
}
