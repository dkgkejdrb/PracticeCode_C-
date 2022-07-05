using System;

namespace EqualValueType
{
	struct CustomStruct
	{
		int X;

		public CustomStruct(int x)
		{
			X = x;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var customStruct1 = new CustomStruct(1);
			var customStruct2 = new CustomStruct(1);
			//Console.WriteLine($"customStruct1 == customStruct2: " +
			//	$"{customStruct1 == customStruct2}"); // error
			Console.WriteLine($"customStruct1.Equals(customStruct2): " +
				$"{customStruct1.Equals(customStruct2)}"); // true
		}
	}
}
