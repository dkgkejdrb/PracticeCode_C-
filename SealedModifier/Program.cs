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

	public class Derived : Base // public sealed class Derived : Base 이렇게 되면 상속할 수 없음
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
