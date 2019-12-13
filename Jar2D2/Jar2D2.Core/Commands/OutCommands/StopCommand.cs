using ArduinoDriver.SerialProtocol;
using Jar2D2.Core.ArduinoWrapper;
using System.Collections.Generic;

namespace Jar2D2.Core.Commands.OutCommands
{
  public class StopCommand : IOutCommand
  {
    public IDictionary<int, int> CommandRegistry { get; set; }

    public void Execute(IArduino arduino)
    {
      var leftWheel = new DigitalWriteRequest(1, ArduinoDriver.DigitalValue.Low);
      var rightWheel = new DigitalWriteRequest(2, ArduinoDriver.DigitalValue.Low);

      arduino.Send(rightWheel);
      arduino.Send(leftWheel);
    }
  }
}
