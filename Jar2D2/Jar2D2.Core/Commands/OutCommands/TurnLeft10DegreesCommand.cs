using ArduinoDriver.SerialProtocol;
using Jar2D2.Core.ArduinoWrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jar2D2.Core.Commands.OutCommands
{
  public class TurnLeft10DegreesCommand : IOutCommand
  {
    public IDictionary<int, int> CommandRegistry { get; set; }

    public async Task Execute(IArduino arduino)
    {
      var leftWheelOn = new DigitalWriteRequest(1, ArduinoDriver.DigitalValue.High);
      var leftWheelOff = new DigitalWriteRequest(1, ArduinoDriver.DigitalValue.Low);

      var rightWheelOn = new DigitalWriteRequest(2, ArduinoDriver.DigitalValue.High);
      var rightWheelOff = new DigitalWriteRequest(2, ArduinoDriver.DigitalValue.Low);

      Task delay = Task.Delay(2000);

      Task task1 = new Task(async () => {
        arduino.Send(leftWheelOff);
        arduino.Send(rightWheelOn);
      });

      Task task2 = new Task(async () => {
        arduino.Send(leftWheelOn);
        arduino.Send(rightWheelOn);
      });

      await task1;
      await delay;
      await task2;
    }
  }
}
