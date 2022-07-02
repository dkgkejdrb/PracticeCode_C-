using System;

namespace immutableStruct
{
	struct add
	{
		public string join(string a, int b)
		{
			string res = String.Empty;
			for (int i = 0; i < b; i++)
			{
				res += a;
			}
			return res;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new add();
			Console.WriteLine(obj.join("Hello", 100));
		}
	}
}
