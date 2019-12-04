using Jar2D2.Core.ArduinoWrapper;
using Jar2D2.Core.Commands;
using Jar2D2.Core.Commands.InCommands;
using System;

namespace Jar2D2.Core.Engine
{
  public class Engine : IEngine
  {
    private readonly ICommandProcessor _CommandProcessor;
    private readonly IArduino _Arduino;

    public Engine(ICommandProcessor commandProcessor, IArduino arduino)
    {
      _CommandProcessor = commandProcessor;
      _Arduino = arduino;
    }

    public void Start()
    {
      while (true)
      {
        var keyCommand = Console.ReadKey();
        var inCommand = DetermineInCommand(keyCommand);

        _CommandProcessor.Process(inCommand);
      }
    }

    private IInCommand DetermineInCommand(ConsoleKeyInfo key)
    {
      if (key.Key == ConsoleKey.UpArrow)
      {
        return new UpKeyCommand(_Arduino);
      }

      if (key.Key == ConsoleKey.DownArrow)
      {
        return new DownKeyCommand(_Arduino);
      }

      throw new NotImplementedException();
    }
  }
}
