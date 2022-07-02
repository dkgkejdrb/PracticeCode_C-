using System;

namespace AccessModifiers1
{
	public class TestClass
	{
		public string PublicField = "public";
		internal string InternalField = "internal";
		protected string ProtectedField = "protected";
		protected internal string ProtectedInternalField = "protected internal";
		private protected string PrivateProtectedField = "private protected";
		private string PrivateField = "Private"; // Private  

		public TestClass()
		{
			Console.WriteLine(PrivateField); // 클래스 안에 있어야 접근 가능
		}
	}

	public class ChildOfTestClass : TestClass
	{
		public ChildOfTestClass()
		{
			Console.WriteLine(base.ProtectedField);
			Console.WriteLine(base.PrivateProtectedField);
		}
	}

	class Program
	{
		public int num1 = 100;
		static void Main(string[] args)
		{
			var testClassObject = new TestClass(); 
			Console.WriteLine($"{testClassObject.PublicField}");
			Console.WriteLine($"{testClassObject.InternalField}");
			// Console.WriteLine($"{testClassObject.ProtectedField}");
			Console.WriteLine($"{testClassObject.ProtectedInternalField}");
			// Console.WriteLine($"{testClassObject.PrivateProtectedField}"); // syntax 에러
		}
	}
}
