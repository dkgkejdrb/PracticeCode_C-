using System;

namespace PartialClass
{
	partial class Duck
	{
		internal void Quack()
		{
			Console.WriteLine("Quack, quack, I'm a duck.");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new Duck();
			obj.Quack();
			obj.Swim();
		}
	}
}
