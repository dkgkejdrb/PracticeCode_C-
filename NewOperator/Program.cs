using System;
using System.Collections.Generic;

namespace NewOperator
{
	class People
	{
		public string Name;
		public People(string name)
		{
			Name = name;
		}
	}


	internal class Program
	{
		//static void Main(string[] args)
		//{
		//	var obj1 = new People("이동규"); // var로 class 인스턴스 생성
		//	People obj2 = new People("네이버"); // People로 class 인스턴스 생성

		//	var animal = new Dictionary<int, string>(); // var로 dictionary 인스턴스 생성
		//	animal[1] = "one";
		//	animal[2] = "two";

		//	var numbers = new int[] { 1, 2, 3, 4, 5 }; // var로 array 생성
			
		//	var alphabets = new List<string>(); // var로 list 생성
		//	alphabets.Add("one");
		//	alphabets.Add("two");

		//	Console.WriteLine(obj1.Name);
		//	Console.WriteLine(obj2.Name);
		//	Console.WriteLine($"{animal[1]}, {animal[2]}");
		//	for (int i = 0; i < numbers.Length; i++)
		//	{
		//		Console.WriteLine(numbers[i]);
		//	}
		//	for (int j = 0; j < alphabets.Count; j++)
		//	{
		//		Console.WriteLine(alphabets[j]);
		//	}
		//}
	}
}