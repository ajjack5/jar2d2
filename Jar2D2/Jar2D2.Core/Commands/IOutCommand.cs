﻿using Jar2D2.Core.ArduinoWrapper;
using System.Collections.Generic;

namespace Jar2D2.Core.Commands
{
	public interface IOutCommand
	{
    IDictionary<int, int> CommandRegistry { get; set; }
    void Execute(IArduino arduino);
	}
}
