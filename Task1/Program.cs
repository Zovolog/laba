namespace Task1
{
    class Program
    {
        static void Main()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            Console.WriteLine("Додайте чи змініть конфігураційні налаштування (наприклад, logLevel=debug):");
            string input = Console.ReadLine();

            string[] inputParts = input.Split('=');
            if (inputParts.Length == 2)
            {
                string key = inputParts[0].Trim();
                string value = inputParts[1].Trim();

                configManager.SetConfiguration(key, value);
                Console.WriteLine($"Конфігураційне налаштування {key} змінено на {value}.");
            }
            else
            {
                Console.WriteLine("Некоректний ввід.");
            }


            Console.WriteLine("Поточні конфігураційні налаштування:");
            configManager.DisplayConfigurations();
        }
    }

}