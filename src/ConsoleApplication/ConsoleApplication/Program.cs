using System;
using System.Collections.Specialized;

namespace ConsoleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Example 01");
			NameValueCollection example01 = Code.Example01.CustomSection.GetConfig();
			foreach (var key in example01.AllKeys)
			{
				Console.WriteLine("{0} - {1}", key, example01[key]);
			}

			Console.WriteLine("\nExample 02");
			Code.Example02.CustomSection example02 = Code.Example02.CustomSection.GetConfig();
			foreach (var element in example02.Customs)
			{
				Console.WriteLine(element as Code.Example02.CustomElement);
			}

			Console.WriteLine("\nExample 03");
			Code.Example03.CustomSection example03 = Code.Example03.CustomSection.GetConfig();
			Console.WriteLine("Id: {0}", example03.Id);
			foreach (var element in example03.Companies)
			{
				Console.WriteLine(element as Code.Example03.CustomElement);
			}

			Console.WriteLine("\nExample 04");
			Code.Example04.CustomSection example04 = Code.Example04.CustomSection.GetConfig();

			foreach (var site in example04.Items)
			{
				var element = site as Code.Example04.ItemElement;
				Console.WriteLine(element);

				if (element != null)
				{
					foreach (var mapping in element.Types)
					{
						Console.WriteLine("  {0}", (mapping as Code.Example04.TypeElement));
					}
				}
			}

			Console.WriteLine("\nExample 05");
			Code.Example05.CustomSection example05 = Code.Example05.CustomSection.GetConfig();
			Console.WriteLine(example05.ActiveBranch);

			foreach (var site in example05.Toggles)
			{
				var element = site as Code.Example05.TogglesElement;
				Console.WriteLine(element);

				if (element != null)
				{
					foreach (var mapping in element)
					{
						Console.WriteLine("  {0}", (mapping as Code.Example05.ToggleElement));
					}
				}
			}

			Console.WriteLine("\npress a key to exit..");
			Console.ReadKey();
		}
	}
}
