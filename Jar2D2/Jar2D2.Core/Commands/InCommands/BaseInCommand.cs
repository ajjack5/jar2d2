using Jar2D2.Core.ArduinoWrapper;
using System.Collections.Generic;

namespace Jar2D2.Core.Commands.InCommands
{
  public abstract class BaseInCommand : IInCommand
  {
    private readonly IArduino _Arduino;

    public IList<IOutCommand> OutCommands { get; set; } = new List<IOutCommand>();

    public BaseInCommand(IArduino arduino)
    {
      _Arduino = arduino;
    }

    public void Execute()
    {
      foreach (var outCommand in OutCommands)
      {
        outCommand.Execute(_Arduino);
      }
    }
  }
}
