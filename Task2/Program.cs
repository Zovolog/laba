namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть тип графіка (line, bar, pie):");
            string graphType = Console.ReadLine();

            GraphFactory graphFactory = new GraphFactory();
            IGraph graph = graphFactory.CreateGraph(graphType);

            graph.Draw();
        }
    }

}