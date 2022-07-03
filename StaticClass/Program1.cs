using System;

namespace StaticClass
{
	static class SystemMonitor
	{
		private static readonly DateTime _startTime;
		
		static SystemMonitor() // static constructor
		{
			_startTime = DateTime.UtcNow;
		}

		public static string Report()
		{
			return $"{(DateTime.UtcNow - _startTime).TotalSeconds} seconds";
		}
	}
}
