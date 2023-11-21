namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Виберіть тип продукту (smartphone, laptop):");
            string productType = Console.ReadLine();

            TechProductFactory productFactory;
            switch (productType.ToLower())
            {
                case "smartphone":
                    productFactory = new SmartphoneFactory();
                    break;
                case "laptop":
                    productFactory = new LaptopFactory();
                    break;
                default:
                    throw new ArgumentException("Невідомий тип продукту.");
            }

            Screen screen = productFactory.CreateScreen();
            Processor processor = productFactory.CreateProcessor();
            Camera camera = productFactory.CreateCamera();

            Console.WriteLine("\nЗбираємо технологічний продукт:");
            Console.WriteLine("--------------------------------------------------");
            screen.Display();
            processor.Process();
            camera.Capture();
            Console.WriteLine("--------------------------------------------------");
        }
    }

}