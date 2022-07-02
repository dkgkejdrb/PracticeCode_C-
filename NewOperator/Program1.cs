using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOperator
{
	public class LazyInitializer<T> where T : new() // 제약자로 추가
	{
		private T _value;
		public T Get()
		{
			if(_value == null)
			{
				_value = new T();
			}	
			return _value;
		}
	}

	class Animal
	{
		public string Name;
		public Animal(string name)
		{
			Name = name;
		}
	}

	internal class Program1
	{
		static void Main(string[] args)
		{
			var obj = new Animal("rabbit");

			// parameterless 생성자가 없기 때문에 객체 생성 불가
			//var lazyInitializerForAnimal = new LazyInitializer<Animal>();

			// parameterless 이기 때문에 객체 생성 가능
			var lazyInitializerForList = new LazyInitializer<List<int>>();
		}
	}
}
