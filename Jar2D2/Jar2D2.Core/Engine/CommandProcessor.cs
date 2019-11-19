using ArduinoUploader.Hardware;
using Jar2D2.Core.Commands;
using ArduinoDriver.SerialProtocol;
using System;

namespace Jar2D2.Core.Engine
{
  public class CommandProcessor : ICommandProcessor
  {
    private readonly ArduinoDriver.ArduinoDriver InMemoryArduinoDriver;

    public CommandProcessor()
    {
      //ArduinoDriver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "TODO_Port_For_USB");
      try { 
      InMemoryArduinoDriver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, "COM3" , true);
      } catch(Exception e)
      {
        Console.WriteLine(e);
      }
    }

    public void Send(ICommand command)
    {
      int pin = 13;

      var request = new DigitalWriteRequest((byte)pin, ArduinoDriver.DigitalValue.High);

      InMemoryArduinoDriver.Send(request);
    }
  }
}
