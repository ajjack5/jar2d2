using System.Collections.Generic;

namespace Jar2D2.Core.Commands
{
	public interface IOutCommand
	{
    IDictionary<int, int> CommandRegistry { get; set; }
    void Execute(ArduinoDriver.ArduinoDriver driver);
	}
}
