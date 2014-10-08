using System.Configuration;

namespace ConsoleApplication.Code.Example02
{
	public class CustomSection : ConfigurationSection
	{
		public static CustomSection GetConfig()
		{
			var section = ConfigurationManager.GetSection("example02");
			return (CustomSection)section;
		}	

		[ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
		public CustomCollection Customs
		{
			get { return (CustomCollection)this[""]; }
			set { this[""] = value; }
		}
	}
	public class CustomCollection : ConfigurationElementCollection
	{
		protected override ConfigurationElement CreateNewElement()
		{
			return new CustomElement();
		}
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((CustomElement)element).Name;
		}
	}
	public class CustomElement : ConfigurationElement
	{
		[ConfigurationProperty("name", IsKey = true, IsRequired = true)]
		public string Name
		{
			get { return (string)base["name"]; }
			set { base["name"] = value; }
		}

		[ConfigurationProperty("value", IsRequired = false)]
		public string Value
		{
			get { return (string)base["value"]; }
			set { base["value"] = value; }
		}

		[ConfigurationProperty("type", IsRequired = false)]
		public string Type
		{
			get { return (string)base["type"]; }
			set { base["type"] = value; }
		}		

		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}", Name, Value, Type);
		}
	}
}
