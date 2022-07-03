using System;
using static System.Console;
using static System.Math;

namespace encapsulation
{
	class Point
	{
		public double x;
		public double y;

		public Point(double _x, double _y) // constructor 추가
		{
			x = _x;
			y = _y;
		}
	}

	class Line
	{
		private Point start; // 정보은닉
		private Point end; // 정보은닉

		public Line(Point _start, Point _end) // constructor 추가
		{
			start = _start;
			end = _end;
		}

		public float Length() // 데이터가 있는 곳으로 메소드 이동
		{
			//double length = Sqrt(Pow((line.start.x - line.end.x), 2)
			//	+ Pow((line.start.y - line.end.y), 2));

			//return (float)length;

			var xCoordinatesDiff = end.x - start.x;
			var yCoordinatesDiff = end.y - start.y;
			return (float)Sqrt(Pow(xCoordinatesDiff, 2) + Pow(yCoordinatesDiff, 2));
		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			//var startPoint = new Point() { x = 5, y = 10 };		
			//var endPoint = new Point() { x = 0, y = 0 };
			//var Line = new Line() { start = startPoint, end = endPoint };

			var Line = new Line(new Point(5, 10), new Point(0, 0));

			Write(Line.Length());
		}
	}
}