using System.Configuration;

namespace ConsoleApplication.Code.Example03
{
	public class CustomSection : ConfigurationSection
    {
        public static CustomSection GetConfig()
        {
			var section  = ConfigurationManager.GetSection("example03");
	        return (CustomSection) section;
        }

        [ConfigurationProperty("companies")]
        [ConfigurationCollection(typeof(Companies), AddItemName = "company")]
        public Companies Companies
        {
            get
            {
				object o = this["companies"];
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
		public CompanyElement this[int index]
		{
			get
			{
				return BaseGet(index) as CompanyElement;
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

		public new CompanyElement this[string responseString]
		{
			get { return (CompanyElement)BaseGet(responseString); }
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
			return new CompanyElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((CompanyElement)element).Name;
		}
	}

	public class CompanyElement : ConfigurationElement
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
