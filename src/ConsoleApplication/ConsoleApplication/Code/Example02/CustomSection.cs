using System.Configuration;

namespace ConsoleApplication.Code.Example02
{
	public class CustomSection : ConfigurationSection
    {
        public static CustomSection GetConfig()
        {
			var section  = ConfigurationManager.GetSection("example02");
	        return (CustomSection) section;
        }

        [ConfigurationProperty("Companies")]
        [ConfigurationCollection(typeof(Companies), AddItemName = "Company")]
        public Companies Companies
        {
            get
            {
                object o = this["Companies"];
                return o as Companies ;
            }
        }

		[ConfigurationProperty("id", IsRequired = false)]
		public string Id
		{
			get { return this["id"] as string; }
		}
	}

	public class Companies : ConfigurationElementCollection
	{
		public CustomElement this[int index]
		{
			get
			{
				return BaseGet(index) as CustomElement;
			}
			set
			{
				if (BaseGet(index) != null)
				{
					BaseRemoveAt(index);
				}
				BaseAdd(index, value);
			}
		}

		public new CustomElement this[string responseString]
		{
			get { return (CustomElement)BaseGet(responseString); }
			set
			{
				if (BaseGet(responseString) != null)
				{
					BaseRemoveAt(BaseIndexOf(BaseGet(responseString)));
				}
				BaseAdd(value);
			}
		}

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

		[ConfigurationProperty("name", IsRequired = true)]
		public string Name
		{
			get { return this["name"] as string; }
		}
		[ConfigurationProperty("code", IsRequired = true)]
		public string Code
		{
			get { return this["code"] as string; }
		}

		public override string ToString()
		{
			return string.Format("{0} - {1}", Name, Code);
		}
	}
}
