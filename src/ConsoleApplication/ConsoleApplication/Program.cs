using System;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Example 02");
			var example02 = Code.Example02.CustomSection.GetConfig();
			foreach (var element in example02.Customs)
			{
				Console.WriteLine(element as Code.Example02.CustomElement);
			}
			
			Console.WriteLine("\nExample 03");
			var example03 = Code.Example03.CustomSection.GetConfig();
			Console.WriteLine("Id: {0}", example03.Id);
			foreach (var element in example03.Companies)
			{
				Console.WriteLine(element as Code.Example03.CustomElement);
			}

			Console.WriteLine("\nExample 04");
			var example04 = Code.Example04.CustomSection.GetConfig();

			foreach (var site in example04.Sites)
			{
				var element = site as Code.Example04.SiteElement;
				Console.WriteLine(element);

				if (element != null)
				{
					foreach (var mapping in element.Mappings)
					{
						Console.WriteLine(mapping as Code.Example04.MembershipElement);
					}
				}
			}

			Console.WriteLine("\npress a key to exit..");
			Console.ReadKey();
		}
	}
}
