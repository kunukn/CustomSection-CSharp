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
}
