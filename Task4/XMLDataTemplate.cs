namespace Task4
{
    public class XMLDataTemplate : IDataTemplate
    {
        public string RootElement { get; set; }

        public IDataTemplate Clone()
        {
            return new XMLDataTemplate { RootElement = this.RootElement };
        }
    }

}