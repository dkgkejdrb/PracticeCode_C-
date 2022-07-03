using System;
using static System.Console;

namespace ternaryOperator
{
	class Dog
	{
		internal double _weight;
		internal Dog(double weight)
		{
			_weight = weight;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var dog = new Dog(20);
			//string size;
			//if (dog._weight > 25)
			//{
			//	size = "big";
			//}
			//else if (dog._weight > 20)
			//{
			//	size = "normal";
			//}
			//else // dog._weight < 10
			//{
			//	size = "small";
			//}
			//Write($"The dog is {size}");

			var size = dog._weight > 25 ? "big" : dog._weight < 10 ? "small" : "normal";
			Write($"The dog is {size}");
		}
	}
}
