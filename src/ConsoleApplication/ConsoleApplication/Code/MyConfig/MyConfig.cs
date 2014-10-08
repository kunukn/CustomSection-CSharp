using System.Collections.Generic;

namespace ConsoleApplication.Code.MyConfig
{
	public class MyConfig
	{
		private static MyConfig myConfig;
		protected static Dictionary<string, MyInstanceElement> instances;

		// Singleton
		private MyConfig()
		{
			instances = new Dictionary<string, MyInstanceElement>();
			var sec = (MyConfigSection)System.Configuration.ConfigurationManager.GetSection("myConfiguration");
			foreach (MyInstanceElement i in sec.MyInstances)
			{
				instances.Add(i.Name, i);
			}
		}
		public MyInstanceElement Get(string instanceName)
		{
			return instances[instanceName];
		}

		public static MyConfig Instance
		{
			get { return myConfig ?? (myConfig = new MyConfig()); }
		}
	}
}
