using System;

namespace defaultAccessModifier
{
	/*
	private class ClassAtNamespaceLevel // private 은 class level, error 발생
	{

	}
	*/

	class ClassAtNamespaceLevel // internal
	{
		class InnerClass // private
		{

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
