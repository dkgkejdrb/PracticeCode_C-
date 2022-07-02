using System;

namespace immutable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string res = String.Empty;
			for (int i = 0; i < 100; i++)
			{
				res += "Hello";
			}
			Console.WriteLine(res);
		}
	}
}
