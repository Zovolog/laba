namespace Task4
{
    public class JSONToXMLAdapter : IDataConverter
    {
        private JSONDataTemplate jsonTemplate;
        private XMLDataTemplate xmlTemplate;

        public JSONToXMLAdapter(JSONDataTemplate jsonTemplate, XMLDataTemplate xmlTemplate)
        {
            this.jsonTemplate = jsonTemplate;
            this.xmlTemplate = xmlTemplate;
        }

        public void ConvertData(string sourceData)
        {
            Console.WriteLine($"Converting JSON to XML using templates: {jsonTemplate.ObjectType} -> {xmlTemplate.RootElement}");
        }
    }

}