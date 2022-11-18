using System;
using System.Runtime.CompilerServices;
using AMWD.Modbus.Common.Interfaces;
using Microsoft.Extensions.Logging;

namespace AMWD.Modbus.Common.Structures;

public class ExceptionHandler : IErrorHandler
{
	private readonly ILogger _logger;

	public ExceptionHandler(ILogger logger = null)
	{
		_logger = logger;
	}
	public void Handle(Exception ex, string message = null, [CallerMemberName]string caller = null)
	{
		_logger?.LogError(ex, "{0}: {1}", caller, message);
	}
}
