using System;

namespace Struct
{
	struct Point
	{
		public int X;
		public int Y;

		// 모든 필드에 값 할당
		public Point(int a, int b)
		{
			X = a;
			Y = b;
		}

		public void DoSomething()
		{
			Console.WriteLine($"{X}, {Y}");
		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new Point(10, 20); // 생성자에 값 전달
			obj.DoSomething();
		}
	}
}
