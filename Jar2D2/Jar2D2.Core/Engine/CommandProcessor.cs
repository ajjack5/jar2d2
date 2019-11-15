using ArduinoUploader.Hardware;
using Jar2D2.Core.Commands;
using ArduinoDriver.SerialProtocol;

namespace Jar2D2.Core.Engine
{
  public class CommandProcessor : ICommandProcessor
  {
    private readonly ArduinoDriver.ArduinoDriver ArduinoDriver;

    public CommandProcessor()
    {
      //ArduinoDriver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "TODO_Port_For_USB");
      ArduinoDriver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3);

    }

    public void Send(ICommand command)
    {
      int pin = 9;
      int message = 1;

      var request = new AnalogWriteRequest((byte)pin, (byte)message);

      ArduinoDriver.Send(request);
    }
  }
}
