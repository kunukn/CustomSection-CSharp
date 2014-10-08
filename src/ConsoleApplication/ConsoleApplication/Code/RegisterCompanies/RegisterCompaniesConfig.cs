using System.Configuration;

namespace ConsoleApplication.Code.RegisterCompanies
{
	public class RegisterCompaniesConfig : ConfigurationSection
    {
        public static RegisterCompaniesConfig GetConfig()
        {
			var section  = ConfigurationManager.GetSection("example02");
	        return (RegisterCompaniesConfig) section;
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
