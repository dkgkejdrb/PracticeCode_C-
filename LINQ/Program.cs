using System;
using System.Collections.Generic;
using System.Linq; // LINQ 추가

namespace LINQ
{
	public class Person
	{
		public string Name;
		public string LastName;
		public int YearOfBirth;

		public Person(string _Name, string _LastName, int _YearOfBirth)
		{
			Name = _Name; 
			LastName = _LastName;
			YearOfBirth = _YearOfBirth;
		}

		public override string ToString()
		{
			return $"{Name} {LastName} {YearOfBirth}";
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var family = new List<Person>
			{
				new Person("동규", "이", 1987),
				new Person("동건", "이", 1989),
				new Person("동희", "조", 1960),
				new Person("만식", "이", 1961)
			};

			// LINQ(1) - query syntax
			// var [인스턴스] = from [인스턴스(행이 저장될 객체)] in [테이블명] where [조건식] select [인스턴스]
			var bornAfter1980QuerySyntax = from member in family
										   where member.YearOfBirth > 1980
										   select member;

			// LINQ(2) - method syntax
			// var [인스턴스] = [테이블명].Where( [인스턴스(행이 저장될 객체)] => [조건식] )
			var bornAfter1960QuerySyntax = family.Where(
				member => member.YearOfBirth > 1960);


			foreach(var member in bornAfter1980QuerySyntax)
			{
				Console.WriteLine(member);
			}

			foreach(var member in bornAfter1960QuerySyntax)
			{
				Console.WriteLine(member);
			}

			// .OrderBy: key값 기준 오름차순으로 정렬 
			IEnumerable<Person> orderByLastName = family.OrderBy(member => member.LastName);
			foreach (var i in orderByLastName)
			{
				Console.WriteLine(i);
			}

			// .Select: key 열만 추출
			IEnumerable<int> onlyYearsOfBirth = family.Select(member => member.YearOfBirth);
			foreach (var i in onlyYearsOfBirth)
			{
				Console.WriteLine(i);
			}

			// .Average: key 열 평균
			double averageYearOfBirth = family.Average(member => member.YearOfBirth);
			Console.WriteLine(averageYearOfBirth);

			// .Any: 조건식 기준의 요소가 있는지 체크
			bool isAnyMemberBefore1961 = family.Any(member => member.YearOfBirth < 1961);
			Console.WriteLine(isAnyMemberBefore1961);


			bool areAllMembersBornAfter2000 = family.All(member => member.YearOfBirth > 2000);
			Console.WriteLine(areAllMembersBornAfter2000);

			// .StartsWith(key): key를 갖고 있는 행 추출
			IEnumerable<Person> familyWithLastNameStartingCho = family.Where(
				member => member.LastName.StartsWith("조"));
			foreach (var i in familyWithLastNameStartingCho)
			{
				Console.WriteLine(i);
			}

			// .First(): 가장 첫번째 요소 추출
			Person firstMemberByHangl = family.OrderBy(member => member.LastName).First();
			Console.WriteLine(firstMemberByHangl);

			// .Reverse(): key기준으로 내림차순
			IEnumerable<Person> familyFromYoungestToOldest = family.OrderBy(
				member => member.YearOfBirth).Reverse();
			foreach (var i in familyFromYoungestToOldest)
			{
				Console.WriteLine(i);
			}
		}
	}
}