using System.Configuration;

namespace ConsoleApplication.Code.MyConfig
{
	public class MyConfigSection : ConfigurationSection
	{
		[ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
		public MyInstanceCollection MyInstances
		{
			get { return (MyInstanceCollection)this[""]; }
			set { this[""] = value; }
		}
	}
	public class MyInstanceCollection : ConfigurationElementCollection
	{
		protected override ConfigurationElement CreateNewElement()
		{
			return new MyInstanceElement();
		}
		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((MyInstanceElement)element).Name;
		}
	}
	public class MyInstanceElement : ConfigurationElement
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
