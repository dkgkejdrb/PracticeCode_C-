﻿using System;

namespace ExtensionMethod1
{
	public class Duck
	{
		public string Quack()
		{
			return "(확장 메소드 아님) 오리는 꽥꽥.";
		}
	}

	// 확장 매소드
	public static class DuckExtensions
	{
		public static string Quack(this Duck duck)
		{
			return "(확장 메소드 임) 오리는 꽥꽥.";
		}
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			var duck = new Duck();
			Console.WriteLine(duck.Quack());
			Console.WriteLine(DuckExtensions.Quack(duck));
		}
	}
}
