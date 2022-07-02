using AccessModifiers1;
using System;


namespace AccessModifierAnotherAssembly
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var testClassObject = new TestClass();
			Console.WriteLine(testClassObject.PublicField);
			// Console.WriteLine(testClassObject.InternalField);
		}
	}

	public class ChildOfTheClassFromAnotherAssembly : TestClass
	{
		public ChildOfTheClassFromAnotherAssembly()
		{
			Console.WriteLine(base.ProtectedField);
			Console.WriteLine(base.ProtectedInternalField);
			// Console.WriteLine(base.PrivateProtectedField); // syntax 에러
		}

	}
}
