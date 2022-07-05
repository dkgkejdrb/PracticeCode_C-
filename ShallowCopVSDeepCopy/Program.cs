using System;

namespace ShallowCopVSDeepCopy
{
	class Person
	{
		public string Name;
		public double Height;
		public Pet Pet;

		public Person(string name, double height, Pet pet)
		{
			Name = name;
			Height = height;
			Pet = pet;
		}

		// 얕은 복사 MemberwiseClone(): 변수 타입은 복사, 참조 타입은 참조값만 복사 
		//public Person ShallowCopy()
		//{
		//	return (Person)MemberwiseClone();
		//}

		// 깊은 복사는 직접 정의해야 함.
		public Person DeepCopy()
		{
			return new Person(Name, Height, new Pet(Pet.Name, Pet.Height));
		}
	}

	class Pet
	{
		public string Name;
		public double Height;

		public Pet(string name, double height)
		{
			Name = name;
			Height = height;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			//var Man = new Person("이동규", 174.5, new Pet("해피", 4.5));
			//var ManShallowCopy = Man.ShallowCopy();
			//Man.Pet.Height = 10;
			//ManShallowCopy.Height = 190.5;
			//// 변수 타입과 참조 타입의 얕은 복사 비교 출력
			//Console.WriteLine($"Man's Pet's Height: { Man.Pet.Height} " +
			//	$"/ ManShallowCopy's Pet's Height: {ManShallowCopy.Pet.Height}");
			//Console.WriteLine($"Man's Height: {Man.Height} " +
			//	$"/ ManShallowCopy's Height: {ManShallowCopy.Height}");


			//Console.WriteLine();

			var Woman = new Person("정은정", 165.5, new Pet("럭키", 5.5));
			var WomanDeepCopy = Woman.DeepCopy();
			Woman.Pet.Height = 6.5;
			WomanDeepCopy.Height = 145.8;
			// 변수 타입과 참조 타입의 깊은 복사 비교 출력
			Console.WriteLine($"Woman's Pet's Height: {Woman.Pet.Height} " +
				$"/ WomanDeepCopy's Pet's Height: {WomanDeepCopy.Pet.Height}");
			Console.WriteLine($"Woman's Height: {Woman.Height} " +
				$"/ WomanDeepCopy's Height: {WomanDeepCopy.Height}");
		}
	}
}
