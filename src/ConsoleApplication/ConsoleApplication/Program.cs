using System;
using ConsoleApplication.Code.MyConfig;
using ConsoleApplication.Code.RegisterCompanies;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{			
			Console.WriteLine("Example 1");
			MyInstanceElement myInstanceElement = MyConfig.Instance.Get("name1");

			Console.WriteLine(myInstanceElement);
			Console.WriteLine(MyConfig.Instance.Get("name2"));


			Console.WriteLine("\nExample 2");
			var config = RegisterCompaniesConfig.GetConfig();
			foreach (var item in config.Companies)
			{
				var company = (Company) item;
   				Console.WriteLine(company);		
			}




			Console.WriteLine("\npress a key to exit..");
			Console.ReadKey();
		}
	}
}
