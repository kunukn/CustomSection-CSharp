using System.Configuration;

namespace ConsoleApplication.Code.Example02
{
	public class Company : ConfigurationElement
	{

		[ConfigurationProperty("name", IsRequired = true)]
		public string Name
		{
			get {return this["name"] as string;}
		}
		[ConfigurationProperty("code", IsRequired = true)]
		public string Code
		{
			get {return this["code"] as string;}
		}

		public override string ToString()
		{
			return string.Format("{0} - {1}", Name, Code);
		}
	}
}
