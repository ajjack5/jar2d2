using System;

namespace Jar2D2.Core.Engine
{
  public class Engine : IEngine
  {
    private readonly ICommandProcessor CommandProcessor;

    public Engine(ICommandProcessor commandProcessor)
    {
      CommandProcessor = commandProcessor;
    }

    public void Start()
    {
      //while (true)
      //{
      //  var keyCommand = Console.ReadKey();

      //  if (keyCommand.Key == ConsoleKey.UpArrow)
      //  {
      //    CommandProcessor.Send(new UpCommand());
      //    continue;
      //  }

      //  else if (keyCommand.Key == ConsoleKey.DownArrow)
      //  {
      //    CommandProcessor.Send(new DownCommand());
      //    continue;
      //  }
      //}
    }
  }
}
