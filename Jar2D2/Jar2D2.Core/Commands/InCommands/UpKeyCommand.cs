using Jar2D2.Core.ArduinoWrapper;
using Jar2D2.Core.Commands.OutCommands;

namespace Jar2D2.Core.Commands.InCommands
{
  public class UpKeyCommand : BaseInCommand
  {
    public UpKeyCommand(IArduino arduino) : base(arduino)
    {
      OutCommands.Add(new TestLightOnCommand());
    }
  }
}
