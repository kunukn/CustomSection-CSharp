using System;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			AcmeInstanceElement data = new AcmeConfig().Instances("ERCOT");

			Console.WriteLine(data.ToString());
			Console.WriteLine("press a key to exit..");
			Console.ReadKey();
		}
	}
}
