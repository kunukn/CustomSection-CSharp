using System.Configuration;

namespace ConsoleApplication.Code.SiteSettings
{
	public class SiteSection : ConfigurationSection
	{
		[ConfigurationProperty("", IsDefaultCollection = true)]
		public SiteCollection Sites
		{
			get { return (SiteCollection)base[""]; }
		}
	}

	public class SiteCollection : ConfigurationElementCollection
	{
		public new SiteElement this[string name]
		{
			get
			{
				if (IndexOf(name) < 0) return null;

				return (SiteElement)BaseGet(name);
			}
		}

		public SiteElement this[int index]
		{
			get { return (SiteElement)BaseGet(index); }
		}

		public int IndexOf(string name)
		{
			name = name.ToLower();

			for (int idx = 0; idx < base.Count; idx++)
			{
				if (this[idx].Name.ToLower() == name)
					return idx;
			}

			return -1;
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new SiteElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((SiteElement)element).Name;
		}

		protected override string ElementName
		{
			get { return "site"; }
		}
	}

	public class SiteElement : ConfigurationElement
	{
		[ConfigurationProperty("name", DefaultValue = "develop", IsRequired = true, IsKey = true)]
		public string Name
		{
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}

		[ConfigurationProperty("smtp", DefaultValue = "mail.develop.com", IsRequired = true, IsKey = false)]
		public string SmtpServer
		{
			get { return (string)this["smtp"]; }
			set { this["smtp"] = value; }
		}

		[ConfigurationProperty("host", DefaultValue = "localhost", IsRequired = true, IsKey = false)]
		public string Host
		{
			get { return (string)this["host"]; }
			set { this["host"] = value; }
		}

		[ConfigurationProperty("mappings", IsDefaultCollection = false)]
		public MembershipCollection Mappings
		{
			get { return (MembershipCollection)base["mappings"]; }
		}

		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}", Name, SmtpServer, Host);
		}
	}

	public class MembershipCollection : ConfigurationElementCollection
	{
		public new MembershipElement this[string name]
		{
			get
			{
				if (IndexOf(name) < 0) return null;

				return (MembershipElement)BaseGet(name);
			}
		}

		public MembershipElement this[int index]
		{
			get { return (MembershipElement)BaseGet(index); }
		}

		public int IndexOf(string name)
		{
			name = name.ToLower();

			for (int idx = 0; idx < base.Count; idx++)
			{
				if (this[idx].Name.ToLower() == name)
					return idx;
			}
			return -1;
		}

		public override ConfigurationElementCollectionType CollectionType
		{
			get { return ConfigurationElementCollectionType.BasicMap; }
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new MembershipElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((MembershipElement)element).Name;
		}

		protected override string ElementName
		{
			get { return "membership"; }
		}
	}

	public class MembershipElement : ConfigurationElement
	{
		[ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
		public string Name
		{
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}

		[ConfigurationProperty("column", DefaultValue = "", IsRequired = true, IsKey = false)]
		public string Column
		{
			get { return (string)this["column"]; }
			set { this["column"] = value; }
		}

		public override string ToString()
		{
			return string.Format("{0} {1}", Name, Column);
		}
	}
}
