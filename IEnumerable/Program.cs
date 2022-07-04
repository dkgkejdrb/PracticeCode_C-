using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace IEnumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var words = new[] { "이", "동", "규" };
			//var words = new List<string>() { "이동규", "이동건", "조동희", "이만식" };


			// CustomCollection은 IEumerable 인터페이스가 없기 때문에 foreach로 읽을 수 없음
			var words = new CustomCollection( new string[] { "이동규", "이동건", "조동희", "이만식" });
			
			foreach (var word in words)
			{
				WriteLine(word);
			}
		}

		// IEnumerable 인터페이스의 GetEnumerator() 메소드를 작성
		class CustomCollection : System.Collections.IEnumerable
		{
			public string[] _Name;

			public CustomCollection(string[] _name)
			{
				_Name = _name;
			}

			public IEnumerator GetEnumerator() // IEnumerator 에 반복적으로 접근하는 메소드
			{
				return _Name.GetEnumerator();
			}
		}


		// 콜렉션 요소를 반복적으로 접근하기 위해 IEnumerator 인터페이스를 가지는 클래스를 구현
		class CustomCollectionIEnumerator : IEnumerator
		{
			public string[] _Name;
			private int _position = -1; // IEnumerator의 포인터 위치

			public CustomCollectionIEnumerator(string[] _name)
			{
				_Name = _name;
			}

			public object Current // IEnumerator의 포인터가 가르키는 요소를 리턴
			{
				get
				{
					try
					{
						return _Name[_position];
					}
					catch(IndexOutOfRangeException)
					{
						throw new InvalidOperationException("콜렉션의 범위에 벗어났습니다.");
					}
				}
			}

			public bool MoveNext() // 다음 요소가 있는지 bool로 리턴
			{
				_position++;
				return _position < _Name.Length;
			}

			public void Reset() // IEnumerator의 포인터를 초기화
			{
				_position = -1;
			}
		}
	}
}
