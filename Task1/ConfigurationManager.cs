namespace Task1
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private Dictionary<string, string> configurations;

        private ConfigurationManager()
        {
            configurations = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public string GetConfiguration(string key)
        {
            if (configurations.ContainsKey(key))
            {
                return configurations[key];
            }
            return null;
        }

        public void SetConfiguration(string key, string value)
        {
            configurations[key] = value;
        }

        public void DisplayConfigurations()
        {
            foreach (var kvp in configurations)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }

}