namespace Task2
{
    using System;

    public class GraphFactory
    {
        public IGraph CreateGraph(string graphType)
        {
            switch (graphType.ToLower())
            {
                case "line":
                    return new LineGraph();
                case "bar":
                    return new BarGraph();
                case "pie":
                    return new PieChart();
                default:
                    throw new ArgumentException("Невідомий тип графіка.");
            }
        }
    }

}