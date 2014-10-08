using System;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			MyInstanceElement myInstanceElement = MyConfig.Instance.Get("name1");

			Console.WriteLine(myInstanceElement.ToString());
			Console.WriteLine("press a key to exit..");
			Console.ReadKey();
		}
	}
}
