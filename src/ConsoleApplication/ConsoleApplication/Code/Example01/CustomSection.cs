using System.Collections.Specialized;
using System.Configuration;

namespace ConsoleApplication.Code.Example01
{
	public class CustomSection : ConfigurationSection
	{
		public static NameValueCollection GetConfig()
		{
			var section = ConfigurationManager.GetSection("example01");
			return (NameValueCollection)section;
		}
	}
}
