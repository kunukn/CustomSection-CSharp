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
				Console.WriteLine(element as CustomElement);
			}
			
			Console.WriteLine("\nExample 02");
			var example02 = Code.Example02.CustomSection.GetConfig();
			Console.WriteLine("Id: {0}", example02.Id);
			foreach (var element in example02.Companies)
			{
				Console.WriteLine(element as Company);
			}

			Console.WriteLine("\nExample 03");
			var siteSection = Code.Example03.CustomSection.GetConfig();

			foreach (var site in siteSection.Sites)
			{
				var siteElement = site as SiteElement;
				Console.WriteLine(siteElement);

				if (siteElement != null)
				{
					foreach (var mapping in siteElement.Mappings)
					{
						var membershipElement = mapping as MembershipElement;
						Console.WriteLine(membershipElement);
					}
				}
			}

			Console.WriteLine("\npress a key to exit..");
			Console.ReadKey();
		}
	}
}
