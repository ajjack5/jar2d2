using Jar2D2.Core;
using Jar2D2.Core.Engine;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Jar2D2.Terminal
{
  class Program
  {
    public static void Main(string[] args)
    {
      InitialiseEngine();
    }

    public static void InitialiseEngine()
    {
      IServiceProvider serviceProvider = Startup.ConfigureServices();

      IEngine engine = serviceProvider.GetRequiredService<IEngine>();
      engine.Start();
    }
  }
}
