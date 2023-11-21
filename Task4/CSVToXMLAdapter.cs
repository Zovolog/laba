namespace Task4
{
    public class CSVToXMLAdapter : IDataConverter
    {
        private CSVDataTemplate csvTemplate;
        private XMLDataTemplate xmlTemplate;

        public CSVToXMLAdapter(CSVDataTemplate csvTemplate, XMLDataTemplate xmlTemplate)
        {
            this.csvTemplate = csvTemplate;
            this.xmlTemplate = xmlTemplate;
        }

        public void ConvertData(string sourceData)
        {
            Console.WriteLine($"Converting CSV to XML using templates: {string.Join(", ", csvTemplate.Fields)} -> {xmlTemplate.RootElement}");
        }
    }
}