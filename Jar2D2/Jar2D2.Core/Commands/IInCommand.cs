using System.Collections.Generic;

namespace Jar2D2.Core.Commands
{
	public interface IInCommand
	{
    IList<IOutCommand> OutCommands { get; set; }
    void Execute();
	}
}
