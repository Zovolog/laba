namespace Task4
{
    public class CSVDataTemplate : IDataTemplate
    {
        public string[] Fields { get; set; }

        public IDataTemplate Clone()
        {
            return new CSVDataTemplate { Fields = this.Fields };
        }
    }

}