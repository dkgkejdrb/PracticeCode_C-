using System;
using static System.Console; // 추가

namespace StaticClass
{
	static class Calculator // 컨테이너 기능
	{
		public static double add(double a, double b)
		{
			return a + b;
		}

		public static double mul(double a, double b)
		{
			return a * b;
		}

		public static double power(double a)
		{
			return a * a;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			//WriteLine(Calculator.add(5, 2.5));
			//WriteLine(Calculator.mul(5, 2.5));
			//WriteLine(Calculator.power(5));

			WriteLine(SystemMonitor.Report());
		}
	}
}
