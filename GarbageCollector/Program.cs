using System;

namespace GarbageCollector
{
	internal class Program
	{
		public class Person
		{
			public string Name;
			public string Country;
			public BirthDay Birth;

			public Person(string name, string country, BirthDay birth)
			{
				Name = name;
				Country = country;
				Birth = birth;
			}
		}


		static void Main(string[] args)
		{
			//var a = new int();
			//int b = 0;

			//if (args != null)
			//{
			//	a = 5;
			//	b = 5;
			//	// 변수 a, b가 처리되는 즉시 메모리에서 사라짐
			//}

			//Console.WriteLine($"{a} / {a.GetType()}");
			//Console.WriteLine($"{b} / {b.GetType()}");

			var Man = new Person("이동규", "대한민국", new BirthDay(1987, 10, 16));

			if (args != null)
			{
				Man.Name = "John";
				Man.Country = "USA";
				Man.Birth = new BirthDay(1911, 5, 5);
			}

			Console.WriteLine($"His name : {Man.Name}");
			Console.WriteLine($"His country : {Man.Country}");
			Console.WriteLine($"His Birthday : {Man.Birth.Year} / {Man.Birth.Month} / {Man.Birth.Day}");
			// class에 의해 정의된 Man이 처리되면 Garbage Collector에 의해 메모리에서 사라짐 
		}
	}
}
