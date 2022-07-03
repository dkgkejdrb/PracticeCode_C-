using System;
using System.Collections.Generic;

namespace Static
{
	class Box
	{
		public static int MaxCount = 50; // static 멤버
		private List<string> _elements = new List<string>();
		public void add(string element)
		{
			if(_elements.Count < MaxCount)
			{
				_elements.Add(element);
			}	
		}

		public int GetCurrentCount_1()
		{
			return _elements.Count;
		}

		public static int GetCurrentCount_2()
		{
			return MaxCount; // 선언된 클래스 안에서 static 멤버 호출
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var obj1 = new Box();
			obj1.add("Hello");

			Console.WriteLine(obj1.GetCurrentCount_1());
			// Console.WriteLine(obj1.GetCurrentCount_2()); // 호출할 수 없음
			Console.WriteLine(Box.GetCurrentCount_2()); // static 메소드 호출


			//var obj2 = new Box();
			////var invalidMaxCount = obj2.MaxCount; // non static 클래스에서 static 멤버를 호출할 수 없음
			//var validMaxCount = Box.MaxCount; // static 멤버 호출
			//Console.WriteLine(validMaxCount); // 50
			//validMaxCount++;
			//Console.WriteLine(Box.MaxCount); // 50
			//Box.MaxCount++;
			//Console.WriteLine(Box.MaxCount); // 51

			Console.WriteLine(Caluculator.Sqaure(5));
			Console.WriteLine(Caluculator.CircleArea(10));
		}
	}
}
