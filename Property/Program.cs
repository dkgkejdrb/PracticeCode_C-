using System;

namespace Property
{
	// private 필드를 읽을수도 작성할 수도 있음
	class Person
	{
		private int _yearOfBirth; 

		public int yearOfBirth
		{
			get
			{
				return _yearOfBirth;
			}
			set
			{
				_yearOfBirth = value;
			}
		}

		public Person(int _yearOfBirth)
		{
			yearOfBirth = _yearOfBirth;
		}
	}


	// 읽을 수는 있지만, 작성할 수 없음
	class Account
	{
		public int pw
		{ get; private set; }
		
		public Account(int _pw) 
		{ pw = _pw; }
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			var person = new Person(1987);
			Console.WriteLine($"{person.yearOfBirth}"); // 읽을 수 있음
			person.yearOfBirth = 2000; // 작성할 수 없음


			var account = new Account(3663);
			Console.WriteLine($"{account.pw}"); // 읽을 수 있음
			// account.pw = 1234; // 작성할 수 없음
		}
	}
}