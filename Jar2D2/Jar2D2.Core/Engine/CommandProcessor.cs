using Jar2D2.Core.Commands;
using Jar2D2.Core.ArduinoWrapper;

namespace Jar2D2.Core.Engine
{
	public class CommandProcessor : ICommandProcessor
	{
		private readonly Arduino _Arduino;

		public CommandProcessor(Arduino arduino)
		{
      _Arduino = arduino;
		}

    public void Process(IInCommand command)
    {
      command.Execute();
    }
  }
}
