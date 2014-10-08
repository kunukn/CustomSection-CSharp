using System.Configuration;

namespace ConsoleApplication.Code.Example04
{
	public class CustomSection : ConfigurationSection
	{
		[ConfigurationProperty("", IsDefaultCollection = true)]
		public ItemCollection Items
		{
			get { return (ItemCollection)base[""]; }
		}

		public static CustomSection GetConfig()
		{
			var section = ConfigurationManager.GetSection("example04");
			return (CustomSection)section;
		}
	}

	public class ItemCollection : ConfigurationElementCollection
	{
		public new ItemElement this[string name]
		{
			get
			{
				if (IndexOf(name) < 0) return null;

				return (ItemElement)BaseGet(name);
			}
		}

		public ItemElement this[int index]
		{
			get { return (ItemElement)BaseGet(index); }
		}

		public int IndexOf(string name)
		{
			name = name.ToLower();

			for (int i = 0; i < base.Count; i++)
			{
				if (this[i].Name.ToLower() == name)
					return i;
			}

			return -1;
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new ItemElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((ItemElement)element).Name;
		}

		protected override string ElementName
		{
			get { return "item"; }
		}
	}

	public class ItemElement : ConfigurationElement
	{
		[ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
		public string Name
		{
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}

		[ConfigurationProperty("area", DefaultValue = "", IsRequired = false, IsKey = false)]
		public string Area
		{
			get { return (string)this["area"]; }
			set { this["area"] = value; }
		}

		[ConfigurationProperty("host", DefaultValue = "", IsRequired = false, IsKey = false)]
		public string Host
		{
			get { return (string)this["host"]; }
			set { this["host"] = value; }
		}

		[ConfigurationProperty("types", IsDefaultCollection = false)]
		public TypeCollection Types
		{
			get { return (TypeCollection)base["types"]; }
		}

		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}", Name, Area, Host);
		}
	}

	public class TypeCollection : ConfigurationElementCollection
	{
		public new TypeElement this[string name]
		{
			get
			{
				if (IndexOf(name) < 0) return null;

				return (TypeElement)BaseGet(name);
			}
		}

		public TypeElement this[int index]
		{
			get { return (TypeElement)BaseGet(index); }
		}

		public int IndexOf(string name)
		{
			name = name.ToLower();

			for (int i = 0; i < base.Count; i++)
			{
				if (this[i].Name.ToLower() == name)
					return i;
			}
			return -1;
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new TypeElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((TypeElement)element).Name;
		}

		protected override string ElementName
		{
			get { return "type"; }
		}
	}

	public class TypeElement : ConfigurationElement
	{
		[ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
		public string Name
		{
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}

		[ConfigurationProperty("value", DefaultValue = "", IsRequired = false)]
		public string Value
		{
			get { return (string)this["value"]; }
			set { this["value"] = value; }
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", Name, Value);
		}
	}
}
