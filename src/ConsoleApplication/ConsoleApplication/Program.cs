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
			var example1 = CustomSection.GetConfig();
			foreach (var element in example1.Customs)
			{
				Console.WriteLine(element as CustomElement);
			}
			
			Console.WriteLine("\nExample 2");
			var config = RegisterCompaniesConfig.GetConfig();
			Console.WriteLine("Id: {0}", config.Id);
			foreach (var item in config.Companies)
			{
				var company = (Company)item;
				Console.WriteLine(company);
			}

			Console.WriteLine("\nExample 3");
			var siteSection = (SiteSection)System.Configuration.ConfigurationManager.GetSection("SiteSettings");			

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
