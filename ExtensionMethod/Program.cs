using System;

namespace ExtensionMethod
{

	//public class StringOperations
	//{
	//	public int GetNumberOfLines(string input)
	//	{
	//		return input.Split("\n").Length;
	//	}
	//}


	// extension method 는 class 외부에서 static 클래스로 선언
	public static class StringExtensions // static 추가
	{
		public static int GetNumberOfLines(this string input) // static 추가 / 매개 변수에 this 추가
		{
			return input.Split("\n").Length;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var multilineString = @"빨 - 빨 - 빨간 맛, 궁금해 honey 깨물면 점점 녹아든 strawberry 그 맛
									Corner candy shop 찾아봐 baby
									내가 제일 좋아하는 건 여름 그 맛
									야자나무 그늘 아래 졸고 싶고
									뜨거운 여름밤의 바람은 불고
									너무 쉽게 사랑 빠져 버릴 nineteen
									우린 제법 어울리고 또 멋져";

			// var numberOfLines = new StringOperations().GetNumberOfLines(multilineString);
			// Console.WriteLine(numberOfLines);

			var numberOfLines = StringExtensions.GetNumberOfLines(multilineString);
			Console.WriteLine(numberOfLines);
		}
	}
}
