using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace AMWD.Modbus.Common.Interfaces;

public interface IErrorHandler
{
	void Handle(Exception ex, string message = null, [CallerMemberName]string caller = null);
}
