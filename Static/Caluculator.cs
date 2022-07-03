using System;
using static System.Math; // using static 클래스 포함

namespace Static
{
	public static class Caluculator
	{
		public static double Sqaure(double side)
		{
			return Pow(side, 2);
		}

		public static double CircleArea(double radius)
		{
			return PI * Pow(radius, 2);
		}
	}
}
