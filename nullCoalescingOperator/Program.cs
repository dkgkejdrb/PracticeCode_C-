using System;
using System.Collections.Generic;
using static System.Console;

namespace nullCoalescingOperator
{
	class Greeter
	{
		internal string Greet1(string name)
		{
			if (name == null)
			{
				return "Hello, stranger!";
			}
			return $"Hello, {name}";
		}

		internal string Greet2(string name)
		{
			return $"Hello, {name ?? "stranger"}!";
		}
	}

	internal class Program
	{
		private static List<int> _numbers;

		private static void AddToNumbers(int number)
		{
			//if(_numbers == null)
			//{
			//	_numbers = new List<int>();
			//}
			//_numbers.Add(number);
			
			(_numbers ??= new List<int>()).Add(number); // ??= 추가
		}

		private static void ClearIfNotNull(List<int> numbers)
		{
			numbers?.Clear(); // ?. 추가
		}

		static void Main(string[] args)
		{
			//var obj = new Greeter();
			//WriteLine(obj.Greet1(null));
			//Write(obj.Greet1("이동규"));

			//var obj = new Greeter();
			//WriteLine(obj.Greet2(null));
			//WriteLine(obj.Greet2("이동규"));

			//AddToNumbers(10);
			//WriteLine(_numbers.Count);

			//AddToNumbers(20);
			//WriteLine(_numbers.Count);

			ClearIfNotNull(_numbers);
			WriteLine(_numbers.Count);
		}
	}
}
