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
		public Company this[int index]
		{
			get
			{
				return base.BaseGet(index) as Company;
			}
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				this.BaseAdd(index, value);
			}
		}

		public new Company this[string responseString]
		{
			get { return (Company)BaseGet(responseString); }
			set
			{
				if (BaseGet(responseString) != null)
				{
					BaseRemoveAt(BaseIndexOf(BaseGet(responseString)));
				}
				BaseAdd(value);
			}
		}

		protected override System.Configuration.ConfigurationElement CreateNewElement()
		{
			return new Company();
		}

		protected override object GetElementKey(System.Configuration.ConfigurationElement element)
		{
			return ((Company)element).Name;
		}
	}

	public class Company : ConfigurationElement
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
