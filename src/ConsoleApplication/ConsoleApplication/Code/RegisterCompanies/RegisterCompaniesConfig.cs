using System.Configuration;

namespace ConsoleApplication.Code.RegisterCompanies
{
	public class RegisterCompaniesConfig : ConfigurationSection
    {
        public static RegisterCompaniesConfig GetConfig()
        {
            return (RegisterCompaniesConfig)ConfigurationManager.GetSection("RegisterCompanies");
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
	}
}
