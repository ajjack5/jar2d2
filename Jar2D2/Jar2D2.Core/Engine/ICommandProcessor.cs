using Jar2D2.Core.Commands;

namespace Jar2D2.Core.Engine
{
  public interface ICommandProcessor
  {
    void Process(IInCommand command);
  }
}
