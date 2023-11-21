namespace Task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Виберіть формат вихідних даних (csv, json):");
            string sourceFormat = Console.ReadLine().ToLower();

            Console.WriteLine("Виберіть формат цільових даних (xml, json):");
            string targetFormat = Console.ReadLine().ToLower();

            IDataTemplate sourceTemplate, targetTemplate;

            switch (sourceFormat)
            {
                case "csv":
                    sourceTemplate = new CSVDataTemplate { Fields = new string[] { "field1", "field2" } };
                    break;
                case "json":
                    sourceTemplate = new JSONDataTemplate { ObjectType = "MyObject" };
                    break;
                default:
                    throw new ArgumentException("Невідомий формат вихідних даних.");
            }

            switch (targetFormat)
            {
                case "xml":
                    targetTemplate = new XMLDataTemplate { RootElement = "RootElement" };
                    break;
                case "json":
                    targetTemplate = new JSONDataTemplate { ObjectType = "TargetObject" };
                    break;
                default:
                    throw new ArgumentException("Невідомий формат цільових даних.");
            }

            IDataConverter dataConverter;

            if (sourceFormat == "csv" && targetFormat == "xml")
            {
                dataConverter = new CSVToXMLAdapter(sourceTemplate as CSVDataTemplate, targetTemplate as XMLDataTemplate);
            }
            else if (sourceFormat == "json" && targetFormat == "xml")
            {
                dataConverter = new JSONToXMLAdapter(sourceTemplate as JSONDataTemplate, targetTemplate as XMLDataTemplate);
            }
            else
            {
                throw new ArgumentException("Непідтримувана конвертація даних.");
            }

            dataConverter.ConvertData("SampleSourceData");
        }
    }

}