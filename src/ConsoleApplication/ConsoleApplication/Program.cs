using System;
using ConsoleApplication.Code.Example01;
using ConsoleApplication.Code.RegisterCompanies;
using ConsoleApplication.Code.SiteSettings;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Example 1");
			ConsoleApplication.Code.Example01.CustomSection example1 = ConsoleApplication.Code.Example01.CustomSection.GetConfig();
			foreach (var element in example1.Customs)
			{
				Console.WriteLine(element as CustomElement);
			}
			
			Console.WriteLine("\nExample 2");
			RegisterCompaniesConfig config = RegisterCompaniesConfig.GetConfig();
			Console.WriteLine("Id: {0}", config.Id);
			foreach (var element in config.Companies)
			{
				Console.WriteLine(element as Company);
			}

			Console.WriteLine("\nExample 3");
			SiteSection siteSection = SiteSection.GetConfig();

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
