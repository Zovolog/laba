namespace Task4
{
    public class JSONDataTemplate : IDataTemplate
    {
        public string ObjectType { get; set; }

        public IDataTemplate Clone()
        {
            return new JSONDataTemplate { ObjectType = this.ObjectType };
        }
    }

}