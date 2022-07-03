using System;
using static System.Console;

namespace nullCoalescingOperator1
{
	class Person
	{
		public string Name;
		public string LastName;
		int Age;
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			PrintName(new Person { Name = "동규", LastName = "이" });
			PrintName(new Person { LastName = "정" });
			PrintName(new Person());
		}

		static void PrintName(Person person)
		{
			WriteLine(person.Name ?? person.LastName ?? "stranger");
		}

	}
}
