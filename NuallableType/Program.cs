using System;

namespace NuallableType
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// int Height = null; // value type 에 null 값을 할당할 수 없음, 에러
			int? Height = null;
			Nullable<int> Height2 = null;
			Nullable<int> Height3 = new Nullable<int>();

			if (Height.HasValue)
			{
				Console.WriteLine($"Height is {Height.Value}");
			}
			else
			{
				Console.WriteLine($"Height is null");
			}

			int number = Height.Value; // 정수에 null value를 할당할 수 있음
		}
	}
}
