using System.Configuration;

namespace ConsoleApplication
{
	public class AcmeConfigSection : ConfigurationSection
	{
		[ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
		public AcmeInstanceCollection Instances
		{
			get { return (AcmeInstanceCollection)this[""]; }
			set { this[""] = value; }
		}
	}
	public class AcmeInstanceCollection : ConfigurationElementCollection
	{
		protected override ConfigurationElement CreateNewElement()
		{
			return new AcmeInstanceElement();
		}
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((AcmeInstanceElement)element).Name;
		}
	}
	public class AcmeInstanceElement : ConfigurationElement
	{
		[ConfigurationProperty("name", IsKey = true, IsRequired = true)]
		public string Name
		{
			get { return (string)base["name"]; }
			set { base["name"] = value; }
		}

		[ConfigurationProperty("connectionName", IsRequired = true)]
		public string ConnectionName
		{
			get { return (string)base["connectionName"]; }
			set { base["connectionName"] = value; }
		}

		[ConfigurationProperty("fileDir", IsRequired = true)]
		public string FileDir
		{
			get { return (string)base["fileDir"]; }
			set { base["fileDir"] = value; }
		}

		[ConfigurationProperty("baseUrl", IsRequired = true)]
		public string BaseUrl
		{
			get { return (string)base["baseUrl"]; }
			set { base["baseUrl"] = value; }
		}

		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}, {3}", Name, FileDir, BaseUrl, ConnectionName);
		}
	}
}
