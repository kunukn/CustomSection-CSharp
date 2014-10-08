using System.Configuration;

namespace ConsoleApplication.Code.Example05
{
	public class CustomSection : ConfigurationSection
	{
		[ConfigurationProperty("", IsDefaultCollection = true)]
		public TogglesCollection Toggleses
		{
			get { return (TogglesCollection)base[""]; }
		}

		[ConfigurationProperty("activeBranch", IsRequired = true)]
		public string ActiveBranch
		{
			get { return (string)this["activeBranch"]; }
		}

		public static CustomSection GetConfig()
		{
			var section = ConfigurationManager.GetSection("example05");
			return (CustomSection)section;
		}
	}

	public class TogglesCollection : ConfigurationElementCollection
	{				
		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new TogglesElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((TogglesElement)element).Id;
		}

		protected override string ElementName
		{
			get { return "toggles"; }
		}
	}

	public class TogglesElement : ConfigurationElementCollection
	{
		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		[ConfigurationProperty("id", IsRequired = true, IsKey = true)]
		public string Id
		{
			get { return (string)this["id"]; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ToggleElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ToggleElement)element).Name;
		}

		protected override string ElementName
		{
			get { return "toggle"; }
		}

		public override string ToString()
		{
			return string.Format("{0}", Id);
		}
	}

	public class TogglezzCollection : ConfigurationElementCollection
	{		
		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ToggleElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ToggleElement)element).Name;
		}

		protected override string ElementName
		{
			get { return "toggle"; }
		}
	}

	public class ToggleElement : ConfigurationElement
	{
		[ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
		public string Name
		{
			get { return (string)this["name"]; }
		}

		[ConfigurationProperty("mode", DefaultValue = "disabled", IsRequired = false)]
		public string Mode
		{
			get { return (string)this["mode"]; }
		}

		[ConfigurationProperty("fromDate", DefaultValue = "", IsRequired = false)]
		public string FromDate
		{
			get { return (string)this["fromDate"]; }
		}		

		public override string ToString()
		{
			return string.Format("{0} {1} {2}", Name, Mode, FromDate);
		}
	}
}
