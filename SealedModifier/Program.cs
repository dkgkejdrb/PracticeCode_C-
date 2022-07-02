using System;

namespace SealedModifier
{
	public class Base
	{
		public virtual void DoSomething()
		{
			Console.WriteLine("Base class");
		}
	}

	public sealed class Derived : Base // 상속
	{
		public override void DoSomething() // 오버라이드
		{
			Console.WriteLine("Child class");
		}
	}

	public class DerviedFromDerived : Derived
	{
		public override void DoSomething()
		{
			Console.WriteLine("Grandchild class");
		}
	}




	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
