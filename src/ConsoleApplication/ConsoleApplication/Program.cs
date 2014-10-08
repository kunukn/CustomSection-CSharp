using System;
using ConsoleApplication.Code.Example01;
using ConsoleApplication.Code.Example02;
using ConsoleApplication.Code.Example03;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Example 01");
			var example01 = Code.Example01.CustomSection.GetConfig();
			foreach (var element in example01.Customs)
			{
				Console.WriteLine(element as Code.Example01.CustomElement);
			}
			
			Console.WriteLine("\nExample 02");
			var example02 = Code.Example02.CustomSection.GetConfig();
			Console.WriteLine("Id: {0}", example02.Id);
			foreach (var element in example02.Companies)
			{
				Console.WriteLine(element as Code.Example02.Company);
			}

			Console.WriteLine("\nExample 03");
			var example03 = Code.Example03.CustomSection.GetConfig();

			foreach (var site in example03.Sites)
			{
				var siteElement = site as Code.Example03.SiteElement;
				Console.WriteLine(siteElement);

				if (siteElement != null)
				{
					foreach (var mapping in siteElement.Mappings)
					{
						var membershipElement = mapping as Code.Example03.MembershipElement;
						Console.WriteLine(membershipElement);
					}
				}
			}

			Console.WriteLine("\npress a key to exit..");
			Console.ReadKey();
		}
	}
}
