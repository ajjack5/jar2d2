using Jar2D2.Core.Engine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jar2D2.Core
{
  public static class Startup
  {
    public static ServiceProvider ConfigureServices()
    {
      IServiceCollection serviceCollection = new ServiceCollection();

      //serviceCollection
      //  .AddLogging(loggingBuilder =>
      //  {
          
      //  });

      serviceCollection
        .AddSingleton<IEngine, Engine.Engine>()
        .AddSingleton<ICommandProcessor, CommandProcessor>();

      return serviceCollection
        .BuildServiceProvider();
    }
  }
}
