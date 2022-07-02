using System;
using System.Collections.Generic;

namespace Params
{
	internal class Program
	{
		static int Sum1(int[] numbers)
		{
			int sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
				Console.Write($"{number}, ");
			}
			return sum;
		}

		static int Sum2(params int[] numbers)
		{
			int sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
				Console.Write($"{number}, ");
			}
			return sum;
		}

		static int Something(
			params int[] numbers1,
			int = 10;
			params int[] numbers2)
			{ 
			}


		static void Main(string[] args)
		{
			Console.WriteLine(Program.Sum1(new int[] { 1, 2, 3 }));
			Console.WriteLine(Program.Sum2(4, 5, 6)); // params
		}
	}
}
