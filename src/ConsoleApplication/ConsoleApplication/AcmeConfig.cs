using System.Collections.Generic;

namespace ConsoleApplication
{
	public class AcmeConfig
	{
		protected Dictionary<string, AcmeInstanceElement> _instances;
		
		public AcmeInstanceElement Instances(string instanceName)
		{
			_instances = new Dictionary<string, AcmeInstanceElement>();
			var sec = (AcmeConfigSection)System.Configuration.ConfigurationManager.GetSection("acmeConfiguration");			
			foreach (AcmeInstanceElement i in sec.Instances)
			{
				_instances.Add(i.Name, i);
			}

			return _instances[instanceName];
		}		
	}
}
