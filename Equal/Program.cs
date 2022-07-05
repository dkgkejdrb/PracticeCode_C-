using System;

namespace Equal
{
	//class CustomClass
	//{
	//	int X;
	//	public CustomClass(int x)
	//	{
	//		X = x;
	//	}
	//}

	class CustomClassOverridingEquals
	{
		int X;
		public CustomClassOverridingEquals(int x)
		{
			X = x;
		}

		// Equals() 오버라이드
		public override bool Equals(object obj) 
		{
			var item = obj as CustomClassOverridingEquals;

			if (item == null)
			{
				return false;
			}

			return X == item.X;
		}

		// Equalis() 오버라이드 하기 위해 필요한 메소드
		public override int GetHashCode()
		{
			return X.GetHashCode();
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			//var customClass1 = new CustomClass(1);
			//var customClass2 = new CustomClass(1);
			//Console.WriteLine($"customClass1 == customClass2: " +
			//	$"{customClass1 == customClass2}"); // false
			//Console.WriteLine($"customClass1.Equals(customClass2): " +
			//	$"{customClass1.Equals(customClass2)}"); // false

			var customClass1 = new CustomClassOverridingEquals(1);
			var customClass2 = new CustomClassOverridingEquals(1);
			Console.WriteLine($"customClass1 == customClass2: " +
				$"{customClass1 == customClass2}"); // true
			Console.WriteLine($"customClass1.Equals(customClass2): " +
				$"{customClass1.Equals(customClass2)}"); // false
		}
	}
}
